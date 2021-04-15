using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ContosoCrafts.WebSite.Data;
using ContosoCrafts.WebSite.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace ContosoCrafts.WebSite.Pages
{
    public class PrivacyModel : PageModel
    {
        private readonly ILogger<PrivacyModel> _logger;
        private readonly ProductContex _context;

        public PrivacyModel(ILogger<PrivacyModel> logger, ProductContex context)
        {
            _logger = logger;
            _context = context;
        }

        public IList<Product> Products { get; set; }


        public void OnGet()
        {
            Products = _context.ProductTable.ToList();
        }
    }
}