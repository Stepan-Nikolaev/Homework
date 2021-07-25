using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            Product id245 = new Product() { Name = "Ручка", RackNumber = 63, ShelfNumber = 2 };
            Food id765 = new Food() { Name = "Кефир Простоквашино", RackNumber = 72, ShelfNumber = 4, ShelfLife = "30.07.2021" };
            Technique id558 = new Technique() { Name = "Блендер Сатурн", RackNumber = 39, ShelfNumber = 6, FragileParts = true };
            HouseholdChemicals id387 = new HouseholdChemicals() { Name = "Средство для мытья посуды Fairy", RackNumber = 39, 
                ShelfNumber = 6, StorageConditions = "в темном прохладном месте" };
            Textile id836 = new Textile() { Name = "Ткань Велюр", RackNumber = 28, ShelfNumber = 5, };

            Product[] waybill = new Product[] { id245, id765, id558, id387, id836 };

            Console.WriteLine("Накладная:");
            foreach (var item in waybill)
            {
                item.Display();
            }

            Console.ReadKey();
        }

    }
}