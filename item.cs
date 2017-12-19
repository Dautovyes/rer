using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab7_3
{
    class item
    {
        protected long invNumber;
        protected bool taken;

        public item(long invNumber, bool taken)
        {
            this.invNumber = invNumber;
            this.taken = taken;
        }
        public item()
        {
            this.taken = true;
        }
        public bool IsAvailable()
        {
            if (taken == true)
                return true;
            else
                return false;
        }
        public long GetInvNumber()
        {
            return invNumber;
        }

        private void Take()
        {
            taken = false;
        }
        public virtual void Return()
        {
            taken = true;
        }
        public virtual void Show()
        {
            Console.WriteLine("Состояние единицы хранения:\nИнвентарный номер: {0}\nНаличие: {1}", invNumber, taken);
        }
        public void TakeItem()
        {
            if (this.IsAvailable())
                this.Take();
        }
    }
}
