using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstWebApplication.DAL.Interfaces
{
    public interface IBaseRepository<T>
    {
        bool Create(T obj);

        T Get(int id);

        Task<List<T>> Select();

        bool Delete(T obj);
    }
}
