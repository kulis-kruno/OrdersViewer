using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OrdersViewer.Models;

namespace OrdersViewer.Controllers
{
    [Route("api/[controller]")]
    public class OrdersController : Controller
    {
        OrderContext _context;
        public OrdersController(OrderContext context)
        {
            _context = context;
        }

        // GET api/orders
        [HttpGet]
        public async Task<IActionResult> GetAsync()
        {
            var orders = await _context.Orders.AsNoTracking().ToListAsync();
            return Ok(orders);
        }
    }
}