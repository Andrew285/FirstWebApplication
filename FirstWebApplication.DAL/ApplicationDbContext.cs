using FirstWebApplication.Domain;
using Microsoft.EntityFrameworkCore;
using System;

namespace FirstWebApplication.DAL
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {
            //Database.EnsureCreated();
        }

        public DbSet<Book> book { get; set; }
    }
}
