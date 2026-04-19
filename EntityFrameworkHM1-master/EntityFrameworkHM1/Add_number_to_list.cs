using System;
using System.Collections.Generic;
using System.Text;

namespace EntityFrameworkHM1
{
    public static class Add_number_to_list
    {
        public static void add_int_to_list(List<int> l)
        {
            Console.WriteLine(@"
Type numbers before you finish, when you finish type any letter
");
            while (true)
            {
                string input = Console.ReadLine();
                if (int.TryParse(input, out int number))
                {
                    l.Add(number);
                }
                else
                {
                    Console.WriteLine("Finished adding numbers.");
                    break;
                }
            }
        }



    }
}
