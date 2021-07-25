using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    class Technique : Product
    {
        public bool FragileParts { get; set; }
        public override void Display()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Наименование товара - {Name}. Координаты: Стеллаж - {RackNumber}" +
                $", полка - {ShelfNumber}, наличие хрупких частей - {FragileParts}");
            Console.ResetColor();
        }
    }
}
