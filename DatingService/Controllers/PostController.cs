using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DatingService.Domain.Entities;
using DatingService.Persistence;
using DatingService.Service.Interfaces;
using Microsoft.AspNetCore.Identity;
using DatingService.Domain.Auth;
using Microsoft.AspNetCore.Http;
using DatingService.Domain.Options;
using Microsoft.AspNetCore.Hosting;
using System.IO;
using Microsoft.Extensions.Options;
using DatingService.Infrastructure.ViewModels;

namespace DatingService.Controllers
{
    public class PostController : Controller
    {
        private const int PageSize = 5;

        private readonly IOrderService _orderService;
        private readonly IPostService _postService;
        private readonly ICommentService _commentService;
        private readonly IImageService _imageService;
        private readonly PostOptions _postOptions;
        private readonly IFileService _fileService;
        private readonly IWebHostEnvironment _environment;
        private readonly UserManager<ApplicationUser> _userManager;

        public PostController(IPostService postService,
            ICommentService commentService,
            UserManager<ApplicationUser> userManager,
            IOptions<PostOptions> postOptions,
            IFileService fileService,
            IWebHostEnvironment environment,
            IImageService imageService,
            IOrderService orderService)
        {
            _postService = postService;
            _commentService = commentService;
            _userManager = userManager;
            _postOptions = postOptions.Value;
            _fileService = fileService;
            _environment = environment;
            _imageService = imageService;
            _orderService = orderService;
        }

        public async Task<IActionResult> ListAsync(int page = 1, string filter = null)
        {
            var user = await _userManager.GetUserAsync(HttpContext.User);
            if (user == null)
            {
                return NotFound();
            }

            var posts = _postService.GetAll(user);

            if (filter != null)
            {
                posts = posts.Where(p => p.Title.ToUpper().Contains(filter.ToUpper()));
            }

            var count = await posts.CountAsync();
            var items = await posts.Skip((page - 1) * PageSize).Take(PageSize).ToListAsync();

            PageViewModel pageViewModel = new PageViewModel(count, page, PageSize);
            PostListViewModel viewModel = new PostListViewModel
            {
                Filter = filter,
                PageViewModel = pageViewModel,
                Posts = items
            };

            return View(viewModel);
        }

        public async Task<IActionResult> DetailsAsync(Guid id)
        {
            var post = _postService.Get(id);
            if (post == null)
            {
                return NotFound();
            }
            var user = await _userManager.GetUserAsync(HttpContext.User);
            if (user == null)
            {
                return NotFound();
            }

            var comments = _commentService.GetAll(post).ToList();
            foreach (Comment comment in comments)
            {
                comment.User = await _userManager.FindByIdAsync(comment.UserId.ToString());
            }

            ViewBag.Comments = comments;
            return View(post);
        }

        public async Task<IActionResult> CreateAsync()
        {
            var user = await _userManager.GetUserAsync(HttpContext.User);
            if (user == null)
            {
                return NotFound();
            }

            var postCount = _postService.GetAll(user).Count();
            if(postCount == user.PostCount)
            {
                return RedirectToAction("Index", "Order");
            }

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(PostViewModel model, IFormFile file)
        {
            var user = await _userManager.GetUserAsync(HttpContext.User);
            if(user == null)
            {
                return NotFound();
            }


            if (ModelState.IsValid)
            {
                var post = new Post
                {
                    Id = Guid.NewGuid(),
                    UserId = user.Id,
                    Title = model.Title,
                    Content = model.Content
                };

                if (file != null)
                {
                    var image = new Image();
                    var fileName = user.Id.ToString() + "-" + post.DateCreated.ToString("dd-MM-yyyy-hh-mm-ss") + Path.GetExtension(file.FileName);
                    var path = Path.Combine(_environment.WebRootPath, _postOptions.Path, fileName);
                    _fileService.Save(file, path);
                    image.Name = user.UserName;
                    image.Path = fileName;
                    image.PostId = post.Id;
                    post.Image = image;
                }

                _postService.Add(post);
                return RedirectToAction("List");
            }

            return View(model);
        }

        [HttpGet]
        public IActionResult Edit(Guid id)
        {
            var post = _postService.Get(id);
            if (post == null)
            {
                return NotFound();
            }

            if (post.ImageId != null)
            {
                post.Image = _imageService.Get(post.Id);
            }

            var model = new PostViewModel
            {
                Id = post.Id,
                Title = post.Title,
                Content = post.Content,
                ImagePath = post.Image?.Path
            };

            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(PostViewModel model, IFormFile file)
        {
            var user = await _userManager.GetUserAsync(HttpContext.User);

            if (ModelState.IsValid)
            {
                var post = _postService.Get(model.Id);
                if (post == null)
                {
                    return NotFound();
                }

                if (file != null)
                {
                    var image = post.ImageId == null ? new Image() : _imageService.Get(post.ImageId.Value);
                    var fileName = user.Id.ToString() + "-" + post.DateCreated.ToString("dd-MM-yyyy-hh-mm-ss") + Path.GetExtension(file.FileName);
                    var path = Path.Combine(_environment.WebRootPath, _postOptions.Path, fileName);
                    _fileService.Save(file, path);
                    image.Name = user.UserName;
                    image.Path = fileName;
                    image.PostId = post.Id;
                    post.Image = image;
                }

                post.Title = model.Title;
                post.Content = model.Content;
                post.DateUpdated = DateTime.Now;

                _postService.Update(post);
                return RedirectToAction("List");
            }

            return View(model);
        }

        public IActionResult Delete(Guid id)
        {
            var post = _postService.Get(id);
            if (post == null)
            {
                return NotFound();
            }

            return View(post);
        }

        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(Guid id)
        {
            var post = _postService.Get(id);
            if (post == null)
            {
                return NotFound();
            }

            _postService.Remove(id);

            return RedirectToAction("List");
        }

    }
}
