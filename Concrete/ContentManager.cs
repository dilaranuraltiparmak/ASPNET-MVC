using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class ContentManager : IContentService
    {
        IContentDAL _contentDal;

        public ContentManager(IContentDAL contentDal)
        {
            _contentDal = contentDal;
        }
        public void ContentAdd(Content content)
        {
            throw new NotImplementedException();
        }

        public void ContentDelete(Content content)
        {
            throw new NotImplementedException();
        }

        public void ContentUpdate(Content content)
        {
            throw new NotImplementedException();
        }

        public Content GetListByHeadingID(int id)
        {
            throw new NotImplementedException();
        }

        public List<Content> GetList()
        {
            //parametreye bağlı olarak gerekli şartı çağırmak gerekiyor.
            throw new NotImplementedException();
        }

        public List<Content> GetListByID(int id)
        {
            return _contentDal.List(x => x.HeadingID == id);
        }

        //List<Content> IContentService.GetListByHeadingID(int id)
        //{
        //    return(id);
        //}

        public Content GetByID(int id)
        {
            throw new NotImplementedException();
        }

        List<Content> IContentService.GetListByHeadingID(int id)
        {
            throw new NotImplementedException();
        }
    }
}
