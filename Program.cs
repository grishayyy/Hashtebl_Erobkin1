using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hashtebl_Erobkin1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Hashtable phoneBook = new Hashtable();
                int choice;

                do
                {
                    Console.WriteLine("\n1 - Добавить запись");
                    Console.WriteLine("2 - Удалить запись");
                    Console.WriteLine("3 - Найти номер по фамилии");
                    Console.WriteLine("4 - Найти фамилию по номеру");
                    Console.WriteLine("0 - Выход");
                    Console.Write("Выберите действие: ");

                    choice = Convert.ToInt32(Console.ReadLine());

                    switch (choice)
                    {
                        case 1:
                            Console.Write("Введите фамилию: ");
                            string surname = Console.ReadLine();

                            Console.Write("Введите телефон: ");
                            string phone = Console.ReadLine();

                            phoneBook[surname] = phone;
                            Console.WriteLine("Запись добавлена.");
                            break;

                        case 2:
                            Console.Write("Введите фамилию для удаления: ");
                            surname = Console.ReadLine();

                            if (phoneBook.ContainsKey(surname))
                            {
                                phoneBook.Remove(surname);
                                Console.WriteLine("Запись удалена.");
                            }
                            else
                            {
                                Console.WriteLine("Такой записи нет.");
                            }
                            break;

                        case 3:
                            Console.Write("Введите фамилию: ");
                            surname = Console.ReadLine();

                            if (phoneBook.ContainsKey(surname))
                            {
                                Console.WriteLine("Телефон: " + phoneBook[surname]);
                            }
                            else
                            {
                                Console.WriteLine("Фамилия не найдена.");
                            }
                            break;

                        case 4:
                            Console.Write("Введите телефон: ");
                            phone = Console.ReadLine();

                            bool found = false;

                            foreach (DictionaryEntry e in phoneBook)
                            {
                                if (e.Value.ToString() == phone)
                                {
                                    Console.WriteLine("Фамилия: " + e.Key);
                                    found = true;
                                    break;
                                }
                            }

                            if (!found)
                                Console.WriteLine("Телефон не найден.");

                            break;
                    }

                } while (choice != 0);
            }
            catch { Console.WriteLine("Неккоректный ввод данных"); }
        }
    }
}
