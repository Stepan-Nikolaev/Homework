using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    class Textile : Product
    {
        public override void Display()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"Наименование товара - {Name}. Координаты: Стеллаж - {RackNumber}" +
                $", полка - {ShelfNumber}");
            Console.ResetColor();
        }
    }
}
