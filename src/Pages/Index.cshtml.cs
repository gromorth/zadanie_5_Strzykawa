using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ContosoCrafts.WebSite.Data;
using ContosoCrafts.WebSite.Models;
using ContosoCrafts.WebSite.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace ContosoCrafts.WebSite.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly ProductContex _context;

        public IndexModel(ILogger<IndexModel> logger, ProductContex context,
            JsonFileProductService productService)
        {
            _logger = logger;
            _context = context;
            ProductService = productService;
        }
        public JsonFileProductService ProductService { get; }
        public IEnumerable<Product> Products { get; private set; }

        public void OnGet()
        {
            Products = ProductService.GetProducts();
            //Products = _context.Product.ToList();

        }

       

       
    }
}
