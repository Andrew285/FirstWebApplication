using FirstWebApplication.DAL.Interfaces;
using FirstWebApplication.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstWebApplication.DAL.Repositories
{
    class BookRepository : IBookRepository
    {
        private ApplicationDbContext db;
        public BookRepository(ApplicationDbContext db)
        {
            this.db = db;
        }
        public bool Create(Book obj)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Book obj)
        {
            throw new NotImplementedException();
        }

        public Book Get(int id)
        {
            throw new NotImplementedException();
        }

        public Book GetByName(string name)
        {
            throw new NotImplementedException();
        }

        public Task<List<Book>> Select()
        {
            return db.book.ToListAsync();
        }
    }
}
