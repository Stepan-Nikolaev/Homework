using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    public class Product
    {
        public string Name { get; set; }
        public int RackNumber { get; set; }
        public int ShelfNumber { get; set; }

        public virtual void Display()
        {
            Console.WriteLine($"Наименование товара - {Name}. Координаты: Стеллаж - {RackNumber}, полка - {ShelfNumber}");
        }
    }
}
