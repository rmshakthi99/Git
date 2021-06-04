using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RegMVC.Repos
{
   public interface IRepo<T>
    {
        void Add(T t);
        IEnumerable<T> GetAll();
        bool Login(T t); 

    }
}
