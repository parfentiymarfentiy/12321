using System;
using System.Collections.Generic;
using System.Text;

namespace EntityFrameworkHM1
{
    internal class Menu
    {
        public void ShowMenu()
        {
            Console.WriteLine(@"
1)add category
2)show all category
3)delete category
4)update category
5)search category by name
6)search category by id
7)exit
");
        }

        public int GetMenuItem()
        {
            Console.Write("Enter menu item: ");
            int menuItem;
            while (!int.TryParse(Console.ReadLine(), out menuItem) || menuItem < 1 || menuItem > 7)
            {
                Console.Write("Invalid input. Please enter a number between 1 and 6: ");
            }
            return menuItem;
        }
    }
}