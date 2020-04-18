using System;
namespace MyClass
{
    abstract public class Item : IComparable
    {
        int IComparable.CompareTo(object obj)
        {
            Item it = (Item)obj;
            if (this.invNumber == it.invNumber) return 0;
            else if (this.invNumber > it.invNumber) return 1;
            else return -1;
        }

        public abstract void Return();
        public virtual void Print()
        {
            Console.WriteLine("Состояние единицы хранения: \nИнвентарный номер:{0} \nНаличие: {1}", invNumber, taken);
        }

        public void TakeItem()
        {
            if (this.IsAvailable())
                this.Take();
        }


        public Item(long invNumber, bool taken)
        {
            this.invNumber = invNumber;
            this.taken = taken;
        }
        public Item()
        {
            taken = true;
        }
        // инвентарный номер — целое число
        protected long invNumber;
        // хранит состояние объекта - взят ли на руки
        protected bool taken;
        // истина, если этот предмет имеется в библиотеке
        public bool IsAvailable()
        {
            if (taken == true)
                return true;
            else
                return false;
        }
        // инвентарный номер
        public long GetInvNumber()
        {
            return invNumber;
        }
        // операция "взять"
        public void Take()
        {
            taken = false;
        }
    }
}
