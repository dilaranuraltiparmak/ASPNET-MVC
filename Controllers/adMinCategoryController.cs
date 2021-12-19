using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules.FluentValidation;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using System.Web.Mvc;

namespace bitirmeprojesi.Controllers
{
    public class adMinCategoryController : Controller
    {
        CategoryManager cm = new CategoryManager(new EfCategoryDAL());
        public ActionResult Index()
        {
            var categoryValue = cm.GetList();
            return View(categoryValue);
        }
        [HttpGet]
        public ActionResult AddCategory()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddCategory(Category p)
        {
            CategoryValidator categoryValidator = new CategoryValidator();
            ValidationResult results = categoryValidator.Validate(p);
            if (results.IsValid)
            {
                cm.CategoryAddBL(p);
                return RedirectToAction("Index");

            }
            else
            {
                foreach (var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }

            return View();

        }
        public ActionResult DeleteCategory(int id)
        {
            var Categoryvalue = cm.GetByID(id);
            cm.CategoryDelete(Categoryvalue);
            return RedirectToAction("Index");
            //Beni tekrar indexe yönlendir.
        }
        [HttpGet]
        public ActionResult EditCategory(int id)
        {
            var Categoryvalue = cm.GetByID(id);
            return View(Categoryvalue);
        }
        [HttpGet]
        public ActionResult EditCategory(Category c)
        {
            cm.CategoryUpdate(c);
           return RedirectToAction("Index");
        }
    }
    }
