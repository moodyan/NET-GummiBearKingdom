using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using GummiBearKingdom.Models;

namespace GummiBearKingdom.Controllers
{
    public class ProductsController : Controller
    {
        private GummiBearKingdomDbContext db = new GummiBearKingdomDbContext();
        public IActionResult Index()
        {
            return View(db.Products.ToList());
        }
    }
}
