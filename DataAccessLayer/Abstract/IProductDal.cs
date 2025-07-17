using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer.Concrete;

namespace DataAccessLayer.Abstract
{
    public interface IProductDal:IGenericDal<Product>
    {
        void Insert(Product p);
        void Update(Product p);
        void Delete(Product p);
        List<Product> GetList(); 

    }
}
