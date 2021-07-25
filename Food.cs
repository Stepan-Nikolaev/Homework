using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    class Food : Product
    {
        public string ShelfLife { get; set; }
        public override void Display()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Наименование товара - {Name}. Координаты: Стеллаж - {RackNumber}" +
                $", полка - {ShelfNumber}, срок годности - {ShelfLife}");
            Console.ResetColor();
        }
    }
}
