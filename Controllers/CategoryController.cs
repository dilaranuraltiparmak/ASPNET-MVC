using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules.FluentValidation;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace bitirmeprojesi.Controllers
{
    public class CategoryController : Controller
    {
        // GET: Category
        CategoryManager cm = new CategoryManager(new EfCategoryDAL());
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult GetCategoryList()
        {
            var categoryvalue = cm.GetList();
            return View(categoryvalue);
        }
        [HttpGet]
        //Sayfa yüklendiğinde çalışır.HttpGet
        public ActionResult AddCategory()
        {
            return View();
        }
        [HttpPost]
        //HttpPost sayfada butona tıklanıldığında çalışır
        public ActionResult AddCategory(Category ct)
        {
            //   cm.CategoryAddBl(ct);
            CategoryValidator cv = new CategoryValidator();
            ValidationResult result = cv.Validate(ct);
            if (result.IsValid)
            {
                cm.CategoryAddBL(ct);
                return RedirectToAction("GetCategoryList");
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
        }
    }
}