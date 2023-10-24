using CA_Week6_1.Models;

namespace CA_Week6_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book bk1 = new("Book 1", "Somebody 1", 240);
            Book bk2 = new("Book 2", "Somebody 2", 140);
            Book bk3 = new("Book 3", "Somebody 3", 320);


            Library lib = new();

            lib.Add(bk1).Add(bk2).Add(bk3);

            /* foreach (Book book in Library.Books)
             {

                 Console.WriteLine(book);
             }*/


            //lib.RemoveAllBooksByName("book");

            //lib.RemoveBookByCode("bo1");


            /* foreach (Book book in lib.FindAllBooksByName("book")) {

                 Console.WriteLine(book);
             }*/

            /* foreach (Book book in lib.FindAllBooksByPageCountRange(300, 2000))
             {

                 Console.WriteLine(book);
             }*/

       /*     foreach (Book book in lib.SeachBooks("book"))
            {

                Console.WriteLine(book);
            }*/


            Dictionary<int, string> names = new Dictionary<int, string>();
            names[1] = "Somebody1";
            names[2] = "Somebody2";
            names[3] = "Somebody3";

            foreach(KeyValuePair<int, string> kvp in names)
            {
                //Console.WriteLine($"{kvp.Key} : {kvp.Value}");
            }

            SortedList<int, string> names2 = new SortedList<int, string>();
            names2[3] = "Somebody1";
            names2[1] = "Somebody2";
            names2[2] = "Somebody3";
            foreach(KeyValuePair<int, string> kvp in names2)
            {
                //Console.WriteLine($"{kvp.Key} : {kvp.Value}");
            }

            Queue<string> customers = new Queue<string>();
      
            string customer1 = "Customer1";
            string customer2 = "Customer2";
            string customer3 = "Customer3";

            customers.Enqueue(customer1);
            customers.Enqueue(customer3);
            customers.Enqueue(customer2);

            foreach(string c in customers)
            {
                //Console.WriteLine(c);
            }

            Stack<string> doner = new Stack<string>();

            List<string> ingredients = new List<string>() {"bread", "ketchup", "onion", "meat", "bread" };

            foreach(string i in ingredients)
            {
                doner.Push(i);
            }

            for (int i = 0; i < ingredients.Count; i++){
                //Console.WriteLine(doner.Pop());
            }

            //remove dublicates

            List<int> ints = new List<int>() { 1, 1, 1, 2, 3, 4, 4 };
            HashSet<int> hs = new HashSet<int>();

            foreach (int i in ints)
            {
                hs.Add(i);
            }

            foreach (int i in hs)
            {
                //Console.WriteLine(i);
            }
        }
    }
}