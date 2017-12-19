using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab7_3
{
    class Program
    {
        static void Main(string[] args)
        {
            book b1 = new book();
            b1.SetBook("Достоевский Ф.М.", "Братья Карамазовы", "Вильямс", 2035, 2000);
            book.SetPrice(12);
            b1.Show();
            Console.WriteLine("\n Finally price for rent: {0} p.", b1.PriceBook(3));
            book b2 = new book("Лондон Джек", "Мартин Иден", "Литература", 560, 2006, 101, true);
            book.SetPrice(30);
            b2.TakeItem();
            b2.Show();
            Console.WriteLine("\n Finally price for rent: {0} p.", b2.PriceBook(14));
            book b3 = new book("Герберт Уэллс", "Ярмарка тщеславия");
            book.SetPrice(100);
            b3.Show();
            Console.WriteLine("\n Finally price for rent: {0} p.", b3.PriceBook(5));
            item item1 = new item();
            item1.Show();
            magazine m1 = new magazine("FORBES", 5, "Top programmers", 2014, 1235, true);
            book.SetPrice(75);
            m1.TakeItem();
            m1.Show();
            Console.WriteLine("\nТестирование полиморфизма");
            item it;
            it = b2;
            it.TakeItem();
            it.Show();
            it = m1;
            it.TakeItem();
            it.Show();
            Console.ReadKey();
        }
    }
}
