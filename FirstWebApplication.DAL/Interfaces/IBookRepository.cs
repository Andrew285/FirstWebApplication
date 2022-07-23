using FirstWebApplication.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstWebApplication.DAL.Interfaces
{
    public interface IBookRepository: IBaseRepository<Book>
    {
        Book GetByName(string name);
    }
}
