using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    class HouseholdChemicals : Product
    {
        public string StorageConditions { get; set; }
        public override void Display()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"Наименование товара - {Name}. Координаты: Стеллаж - {RackNumber}" +
                $", полка - {ShelfNumber}, условия хранения - {StorageConditions}");
            Console.ResetColor();
        }
    }
}
