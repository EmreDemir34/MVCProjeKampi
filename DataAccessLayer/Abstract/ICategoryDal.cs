using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface ICategoryDal:IRepository<Category>
    {
        //CRUD
        //Type Name();
        List<Category> List();

        //insert 
        void Insert(Category p);

        //Update
        void Update(Category p);

        //Delete
        void Delete(Category p);
    }

}
