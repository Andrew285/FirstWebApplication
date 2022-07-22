using System;

namespace FirstWebApplication.Domain
{
    public class Book
    {
        private string name;
        private string author;
        private decimal price;

        public string Name
        {
            get { return name; }
        }
        public string Author
        {
            get { return author; }
        }
        public decimal Price
        {
            get { return price; }
        }

        public Book(string name, string author)
        {
            this.name = name;
            this.author = author;
            this.price = 0;
        }

        public Book(string name, string author, decimal price)
        {
            this.name = name;
            this.author = author;
            this.price = price;
        }
    }
}
