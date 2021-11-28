using DatingService.Infrastructure.ViewModels;
using DatingService.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace DatingService.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class OrderController : Controller
    {
        public const int PageSize = 10;

        private readonly IOrderService _orderService;

        public OrderController(IOrderService orderService)
        {
            _orderService = orderService;
        }

        public async Task<IActionResult> ListAsync(int page = 1, string filter = null)
        {
            var orders = filter == null ? _orderService.GetAll() : _orderService.GetAll().Where(p => p.User.FirstName.ToUpper().Contains(filter.ToUpper()));

            var count = await orders.CountAsync();
            var items = await orders.Skip((page - 1) * PageSize).Take(PageSize).ToListAsync();

            var pageViewModel = new PageViewModel(count, page, PageSize);
            var viewModel = new OrderListViewModel
            {
                Filter = filter,
                PageViewModel = pageViewModel,
                Orders = items
            };

            return View(viewModel);
        }

        public IActionResult Details(Guid id)
        {
            var order = _orderService.Get(id);
            if (order == null)
            {
                return NotFound();
            }

            return View(order);
        }
    }
}
