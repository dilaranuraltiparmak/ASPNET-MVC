using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete.Repositories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CategoryManager : ICategoryService
    {


        ICategoryDAL _categoryDal;
        public CategoryManager (ICategoryDAL categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public void CategoryAdd(Category category)
        {
            _categoryDal.Insert(category);
        }
        public void CategoryAddBL(Category category)
        {
            _categoryDal.Insert(category);
        }

        public void CategoryDelete(Category category)
        {
            _categoryDal.Delete(category);

        }

        public void CategoryUpdate(Category category)
        {
            _categoryDal.Update(category);
        }

        public Category GetByID(int id)
        {
            return _categoryDal.Get(x => x.CategoryID == id);
        }

        // GenericRepository<Category> repo = new GenericRepository<Category>();
        //public List<Category> GetAllBl()
        //{
        //    return repo.List();
        //}

        //public void CategoryAddBl(Category cp)
        //{

        //    if (cp.CategoryName == "" || cp.CategoryName.Length <= 3 || cp.CategoryDescription == "" || cp.CategoryName.Length >= 51)
        //    {
        //        //hata mesajı

        //    }
        //    else
        //    {
        //        repo.Insert(cp);
        //    }
        public List<Category> GetList()
        {
            return _categoryDal.List();
        }

        //public void CategoryAddBl(Category p)
        //{
        //    if(p.CategoryName=="" || p.CategoryStatus==false|| p.CategoryName.Length <= 2)
        //    {
        //        //hata mesajı
        //    }
        //    else
        //    {
        //        _categoryDal.Insert(p);
        //    }
        }
    }




