using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using OrdersViewer.Models;
using OrdersViewer.UI.Data;
using OrdersViewer.UI.Services;

namespace OrdersViewer.UI.Pages.Orders
{
    public class IndexModel : PageModel
    {
        private readonly IApiClient _Client;
        public IndexModel(IApiClient client)
        {
            _Client = client;
        }

        public IList<Order> Orders { get; set; }

        public async Task OnGetAsync()
        {
            Orders = await _Client.GetOrdersAsync();
        }
    }
}