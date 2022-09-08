using Entities.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IEntityRepository<T> where T : class,IEntity,new()  //T can only be reference type 
    {
        List<T> GelAll(Expression<Func<T,bool>> filter = null); //When we want to filter something, we use Expression delegate

        T Get(Expression<Func<T,bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);

    }
}
