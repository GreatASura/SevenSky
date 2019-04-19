using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RanobeLib.Data
{
    interface IRepository<T>:IDisposable where T:class 
    {
        IEnumerable<T> GetItemList();
        T GetItem(int Id);
        void Create(T item);
        void Update(T item);
        void Delete(int Id);
        void Save();
    }
}
