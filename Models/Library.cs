using System;

namespace CA_Week6_1.Models
{
    internal class Library
    {
        public static List<Book> Books = new List<Book>();


        private static bool _checkStringExistence(string searchValue, string searchedOnValue) {

            return
                
                searchValue.Trim().ToLower() == searchedOnValue.Trim().ToLower() ||
                //
                searchedOnValue.Trim().ToLower().Split().Contains(searchValue.Trim().ToLower());

        }

        public Library Add(Book book){
            
            Books.Add(book);


            return this;
        }

        public List<Book> FindAllBooksByName(string searchValue)
        {
            List<Book> _ = new();

            foreach(Book book in Books)
            {
                if(Library._checkStringExistence(searchValue, book.Name))
                {
                    _.Add(book);
                }
            }


            return _;
        }

        public void RemoveAllBooksByName(string searchValue)
        {
            List<Book> _ = new();

            for(int i = 0; i < Books.Count; i++)
            {

                Book book = Books[i];
                if(!Library._checkStringExistence(searchValue, book.Name))
                {
                    _.Add(book);
                }
            }

            Books = _;

        }

        public List<Book> SeachBooks(string searchValue)
        {
            List<Book> _ = new();

            foreach(Book book in Books)
            {
                if (

                    Library._checkStringExistence(searchValue, book.Name) ||
                    Library._checkStringExistence(searchValue, book.AuthorName) ||
                    Library._checkStringExistence(searchValue, book.PageCount.ToString())

                    )
                {
                    _.Add(book);
                }
            }


            return _;
        }


        public List<Book> FindAllBooksByPageCountRange(int min, int max)
        {
            List<Book> _ = new();

            foreach(Book book in Books)
            {
                if(book.PageCount >= min && book.PageCount <= max)
                {
                    _.Add(book);
                }
            }


            return _;
        }

        public void RemoveBookByCode(string code)
        {
            List<Book> _ = new();

            for (int i = 0; i < Books.Count; i++)
            {

                Book book = Books[i];
                if (! ( code.Trim().ToLower() == book.Code.Trim().ToLower() ) )
                {
                    _.Add(book);
                }
            }

            Books = _;
        }
    }
}
