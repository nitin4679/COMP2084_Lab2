using Lab2.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace Lab2.Controllers
{
    public class CategoriesController : Controller
    {
        static List<CategoriesModel> CategoriesList = new List<CategoriesModel>
        {
            new CategoriesModel {CategoryId = 1, CategoryName = "Food"},
            new CategoriesModel {CategoryId = 2, CategoryName = "Tech"},
            new CategoriesModel {CategoryId = 3, CategoryName = "Sports"}
        };
        // GET: CategoriesController
        public ActionResult Index()
        {
            return View(CategoriesList);
        }

        // GET: CategoriesController/Details/5
        public ActionResult Details(int id)
        {
            var selected = CategoriesList.First<CategoriesModel>(x => x.CategoryId == id);
            ViewBag.Message = "You selected category: " + selected.CategoryName;
            return View(selected);
        }

        // GET: CategoriesController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CategoriesController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CategoriesController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CategoriesController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CategoriesController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CategoriesController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
