using System;

namespace CA_Week6_1.Models
{
    internal class Book
    {
        private static int _count = 1;
        private string _name;
        public string AuthorName { get; set; }
        public int PageCount { get; set; }
        public string Code { get; set; }
        public string Name 
        { 
            get => _name; 
            set
             {
                if(value.Length < 2)
                {
                    throw new Exception("book name should be at least 2 letter length");
                }

                _name = value;
             }
        }
        


        public Book(string name, string author, int pageCount)
        {
            Name = name; 
            AuthorName = author;
            PageCount = pageCount;
            Code = $"{ Char.ToUpper(Name[0]) }{Char.ToUpper(Name[1])}{Book._count}";
            Book._count++;
        }

        public override string ToString()
        {
            return $"{Name} - {AuthorName} - {Code} - {PageCount}";
        }
    }
}
