using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab7_3
{
    class magazine : item
    {
        private String volume;
        private String title;
        private int number;
        private int year;

        public magazine(String volume, int number, String title, int year, long invNumber, bool taken) : base(invNumber, taken)
        {
            this.volume = volume;
            this.number = number;
            this.title = title;
            this.year = year;
        }

        public magazine()
        {

        }

        public override void Show()
        {
            Console.WriteLine("\nЖурнал:\nТом: {0}\nНомер: {1}\nНазвание: {2}\nГод выпуска: {3}", volume, number, title, year);
            base.Show();
        }
        public override void Return()
        {
                taken = true;
        }
    }
}
