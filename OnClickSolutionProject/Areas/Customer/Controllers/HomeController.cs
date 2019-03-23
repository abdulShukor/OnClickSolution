using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OnClickSolution.Models;
using OnClickSolution.Data;
using Microsoft.EntityFrameworkCore;
using OnClickSolution.Extensions;
using OnClickSolution.Models.ViewModel;

namespace OnClickSolution.Controllers
{
    [Area("Customer")]
    public class HomeController : Controller
    {

        private readonly ApplicationDbContext _db;

        public HomeController(ApplicationDbContext db)
        {
            _db = db;
        }
        public async Task<IActionResult> Index(int id)
        {
            var viewData = new CustomerHomeVM();
            if (id > 0)
            {
                viewData.Products = await _db.Products.Where(m => m.CategoryId == id).ToListAsync();

            }
            else
            {
                viewData.Products = await _db.Products.Include(m => m.Categories).Include(m => m.SpecialTags).ToListAsync();

            }
            viewData.Categories = await _db.Categories.ToListAsync();
            viewData.SpecialTags = await _db.SpecialTags.ToListAsync();

            return View(viewData);
        }

        public async Task<IActionResult> Filter(int id)
        {
            var viewData = new CustomerHomeVM();
            if (id > 0)
            {
                viewData.Products = await _db.Products.Where(m => m.SpecialTagsID == id).ToListAsync();

            }
            else
            {
                viewData.Products = await _db.Products.ToListAsync();

            }
            viewData.Categories = await _db.Categories.ToListAsync();
            viewData.SpecialTags = await _db.SpecialTags.ToListAsync();


            return View("Index", viewData);
        }

        public async Task<IActionResult> OnSale()
        {
            var viewData = new CustomerHomeVM();
            viewData.Products = await _db.Products.Where(x => x.PromotionalPrice > 0).ToListAsync();
            viewData.Categories = await _db.Categories.ToListAsync();
            viewData.SpecialTags = await _db.SpecialTags.ToListAsync();

            return View("Index", viewData);
        }

        [HttpPost]
        public async Task<IActionResult> Search(string keyword)
        {
            var viewData = new CustomerHomeVM();
            viewData.Products = await _db.Products.Include(m => m.Categories).Where(m => m.Name.Contains(keyword)).ToListAsync();
            viewData.Categories = await _db.Categories.ToListAsync();
            viewData.SpecialTags = await _db.SpecialTags.ToListAsync();

            return View("Index", viewData);
        }

        public async Task<IActionResult> Details(int id)
        {
            var product = await _db.Products.Include(m => m.Categories).Include(m => m.SpecialTags).Where(m => m.Id == id).FirstOrDefaultAsync();


            return View(product);
        }


        [HttpPost, ActionName("Details")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DetailsPost(int id)
        {
            List<int> lstShoppingCart = HttpContext.Session.Get<List<int>>("ShoppingCartList");
            if (lstShoppingCart == null)
            {
                lstShoppingCart = new List<int>();
            }
            lstShoppingCart.Add(id);
            HttpContext.Session.Set<List<int>>("ShoppingCartList", lstShoppingCart);

            return RedirectToAction("Index", "Home", new { area = "Customer" });

        }

        public IActionResult Remove(int id)
        {
            List<int> lstShoppingCart = HttpContext.Session.Get<List<int>>("ShoppingCartList");
            if (lstShoppingCart.Count > 0)
            {
                if (lstShoppingCart.Contains(id))
                {
                    lstShoppingCart.Remove(id);
                }
            }

            HttpContext.Session.Set("ShoppingCartList", lstShoppingCart);

            return RedirectToAction(nameof(Index));
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

    }
}
