using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EntityFrameworkHM1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using var db = new CategoryesContext();
            db.Database.EnsureCreated();

            Menu menu = new Menu();
            while (true)
            {
                menu.ShowMenu();
                int item = menu.GetMenuItem();
                switch (item)
                {
                    case 1:
                        #region     Добавление категории
                        Console.WriteLine("Введите название категории:");

                        string name = Console.ReadLine();

                        List<int> l  = new List<int>();

                        Add_number_to_list.add_int_to_list(l);

                        var category = new Categoryes { Name = name, Example = l };

                        db.Categoryess.Add(category);

                        db.SaveChanges();

                        Console.WriteLine("Категория добавлена.");

                        break;
                        #endregion
                    case 2:
                        #region Показание всех категорий
                        var categories = db.Categoryess.ToList();
                        Console.WriteLine("Категории:");
                        foreach (var cat in categories)
                        {
                            string result = string.Join(", ", cat.Example);
                            Console.WriteLine($"ID: {cat.Id}, Name: {cat.Name}, Examle:{result}");
                        }
                        break;
                        #endregion
                    case 3:
                        #region Удаление    категории
                        #region Показание всех категорий
                        categories = db.Categoryess.ToList();
                        Console.WriteLine("Категории:");
                        foreach (var cat in categories)
                        {
                            string result = string.Join(", ", cat.Example);
                            Console.WriteLine($"ID: {cat.Id}, Name: {cat.Name}, Examle:{result}");
                        }

                        #endregion


                        Console.WriteLine("Введите ID категории для удаления:");
                        Guid ID = Guid.Parse(Console.ReadLine());


                        var categoryToDelete = db.Categoryess.FirstOrDefault(c => c.Id == ID);

                        if (categoryToDelete != null)
                        {
                            db.Categoryess.Remove(categoryToDelete); 
                            db.SaveChangesAsync();             
                            Console.WriteLine("Категория удалена.");
                        }
                        else
                        {
                            Console.WriteLine("Категория с таким ID не найдена.");
                        }
                        break;
                        #endregion
                    case 4:
                        #region Обновление категории
                        #region Удаление    категории
                        #region Показание всех категорий
                        categories = db.Categoryess.ToList();
                        Console.WriteLine("Категории:");
                        foreach (var cat in categories)
                        {
                            string result = string.Join(", ", cat.Example);
                            Console.WriteLine($"ID: {cat.Id}, Name: {cat.Name}, Examle:{result}");
                        }

                        #endregion


                        Console.WriteLine("Введите ID категории для удаления:");
                        ID = Guid.Parse(Console.ReadLine());


                        categoryToDelete = db.Categoryess.FirstOrDefault(c => c.Id == ID);

                        if (categoryToDelete != null)
                        {
                            db.Categoryess.Remove(categoryToDelete);
                            db.SaveChangesAsync();
                            Console.WriteLine("Категория удалена.");
                        }
                        else
                        {
                            Console.WriteLine("Категория с таким ID не найдена.");
                        }

                        #endregion

                        #region     Добавление категории
                        Console.WriteLine("Введите название категории:");

                        name = Console.ReadLine();

                         l = new List<int>();

                        Add_number_to_list.add_int_to_list(l);

                         category = new Categoryes { Name = name, Example = l };

                        db.Categoryess.Add(category);

                        db.SaveChanges();

                        Console.WriteLine("Категория добавлена.");

                        break;
                        #endregion
                        #endregion
                    case 5:
                        #region Поиск по имени
                        Console.WriteLine("Pls enter name");
                        string name1 = Console.ReadLine();

                        categories = db.Categoryess.ToList();
                        Console.WriteLine("Категории:");
                        foreach (var cat in categories)
                        {
                            if (cat.Name == name1)
                            {
                                string result = string.Join(", ", cat.Example);
                                Console.WriteLine($"ID: {cat.Id}, Name: {cat.Name}, Examle:{result}");
                            }
                        }
                        break;
                        #endregion
                    case 6:
                        #region Поиск по айди
                        Console.WriteLine("Pls enter ID");
                        Guid id1 = Guid.Parse(Console.ReadLine());

                        categories = db.Categoryess.ToList();
                        Console.WriteLine("Категории:");
                        foreach (var cat in categories)
                        {
                            if (cat.Id == id1)
                            {
                                string result = string.Join(", ", cat.Example);
                                Console.WriteLine($"ID: {cat.Id}, Name: {cat.Name}, Examle:{result}");
                            }
                        }
                        break;
                        #endregion
                    case 7:
                        return;
                    default:
                        Console.WriteLine("Неверный пункт меню. Попробуйте снова.");
                        break;
                }
            }

        }
    }
}