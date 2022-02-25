using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IRepository<T>
    {
        //CRUD
        //Type Name();
        List<T> List();

        //insert 
        void Insert(T p);

        //Update
        void Update(T p);

        //Delete
        void Delete(T p);

        List<T> List(Expression<Func<T, bool>> filter);
    }
}
