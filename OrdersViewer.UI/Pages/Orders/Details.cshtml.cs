﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using OrdersViewer.Models;
using OrdersViewer.UI.Data;

namespace OrdersViewer.UI.Pages.Orders
{
    public class DetailsModel : PageModel
    {
        private readonly OrdersViewer.UI.Data.ApplicationDbContext _context;

        public DetailsModel(OrdersViewer.UI.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public Order Order { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Order = await _context.Order.SingleOrDefaultAsync(m => m.Id == id);

            if (Order == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
