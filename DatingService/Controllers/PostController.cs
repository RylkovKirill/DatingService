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

namespace DatingService.Controllers
{
    public class PostController : Controller
    {
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
            IImageService imageService)
        {
            _postService = postService;
            _commentService = commentService;
            _userManager = userManager;
            _postOptions = postOptions.Value;
            _fileService = fileService;
            _environment = environment;
            _imageService = imageService;
        }

        public async Task<IActionResult> Index()
        {
            var user = await _userManager.GetUserAsync(HttpContext.User);
            if (user == null)
            {
                return NotFound();
            }

            return View(_postService.GetAll(user));
        }

        //// GET: Blog/Details/5
        //public async Task<IActionResult> Details(Guid? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var post = await _context.Posts
        //        .Include(p => p.Image)
        //        .Include(p => p.User)
        //        .FirstOrDefaultAsync(m => m.Id == id);
        //    if (post == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(post);
        //}

        // GET: Blog/Create
        public IActionResult Create()
        {
            return View(new Post());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Post post, IFormFile file)
        {
            var user = await _userManager.GetUserAsync(HttpContext.User);

            if (ModelState.IsValid)
            {
                post.UserId = user.Id;

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
                return RedirectToAction(nameof(Index));
            }

            return View(post);
        }

        //// GET: Blog/Edit/5
        //public async Task<IActionResult> Edit(Guid? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var post = await _context.Posts.FindAsync(id);
        //    if (post == null)
        //    {
        //        return NotFound();
        //    }
        //    ViewData["ImageId"] = new SelectList(_context.Images, "Id", "Name", post.ImageId);
        //    ViewData["UserId"] = new SelectList(_context.Users, "Id", "FirstName", post.UserId);
        //    return View(post);
        //}

        //// POST: Blog/Edit/5
        //// To protect from overposting attacks, enable the specific properties you want to bind to.
        //// For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Edit(Guid id, [Bind("Title,Content,IsPublished,ImageId,UserId,Id,DateCreated,DateUpdated")] Post post)
        //{
        //    if (id != post.Id)
        //    {
        //        return NotFound();
        //    }

        //    if (ModelState.IsValid)
        //    {
        //        try
        //        {
        //            _context.Update(post);
        //            await _context.SaveChangesAsync();
        //        }
        //        catch (DbUpdateConcurrencyException)
        //        {
        //            if (!PostExists(post.Id))
        //            {
        //                return NotFound();
        //            }
        //            else
        //            {
        //                throw;
        //            }
        //        }
        //        return RedirectToAction(nameof(Index));
        //    }
        //    ViewData["ImageId"] = new SelectList(_context.Images, "Id", "Name", post.ImageId);
        //    ViewData["UserId"] = new SelectList(_context.Users, "Id", "FirstName", post.UserId);
        //    return View(post);
        //}

        //// GET: Blog/Delete/5
        //public async Task<IActionResult> Delete(Guid? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var post = await _context.Posts
        //        .Include(p => p.Image)
        //        .Include(p => p.User)
        //        .FirstOrDefaultAsync(m => m.Id == id);
        //    if (post == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(post);
        //}

        //// POST: Blog/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> DeleteConfirmed(Guid id)
        //{
        //    var post = await _context.Posts.FindAsync(id);
        //    _context.Posts.Remove(post);
        //    await _context.SaveChangesAsync();
        //    return RedirectToAction(nameof(Index));
        //}

        //private bool PostExists(Guid id)
        //{
        //    return _context.Posts.Any(e => e.Id == id);
        //}
    }
}
