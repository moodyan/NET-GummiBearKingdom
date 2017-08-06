using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using GummiBearKingdom.Models;


namespace GummiBearKingdom.Controllers
{
    public class BlogController : Controller
    {
        private GummiBearKingdomDbContext db = new GummiBearKingdomDbContext();
        public IActionResult Index()
        {
            return View(db.Blogs.ToList());
        }

        public IActionResult Details(int id)
        {
            var thisBlog = db.Blogs.FirstOrDefault(blogs => blogs.BlogId == id);
            return View(thisBlog);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Blog blog)
        {
            db.Blogs.Add(blog);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Edit(int id)
        {
            var thisBlog = db.Blogs.FirstOrDefault(blogs => blogs.BlogId == id);
            return View(thisBlog);
        }

        [HttpPost]
        public IActionResult Edit(Blog blog)
        {
            db.Entry(blog).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            var thisBlog = db.Blogs.FirstOrDefault(blogs => blogs.BlogId == id);
            return View(thisBlog);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            var thisBlog = db.Blogs.FirstOrDefault(blogs => blogs.BlogId == id);
            db.Blogs.Remove(thisBlog);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}
