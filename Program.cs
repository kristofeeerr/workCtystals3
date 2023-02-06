using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace workCrystals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int crystalPrice = 15;
            
            Console.WriteLine($" Добро пожаловать в магазин! Сегодня один кристалл стоит {crystalPrice} золотых монет:");
            Console.Write($"Сколько у вас золотых монет: " );
            int gold = Convert.ToInt32(Console.ReadLine());
            
            Console.Write($"Сколько кристаллов вам нужно:");
            int crystals = Convert.ToInt32(Console.ReadLine());

            gold -= crystalPrice * crystals;
            Console.WriteLine($"У вас {crystals} кристаллов и {gold} золотых монет");
        }
    }
}
