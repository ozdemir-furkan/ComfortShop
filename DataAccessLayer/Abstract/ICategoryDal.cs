using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer.Concrete;

namespace DataAccessLayer.Abstract
{
    public interface ICategoryDal:IGenericDal<Category>
    {
        void Insert(Category p);
        void Update(Category p);
        void Delete(Category p);
        List<Category> GetList();

    }
}
