using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Написать консольное приложение, которое будет запрашивать ввод данных пользователя.

            Console.Write("Введите ФИО: ");
            string name = Console.ReadLine();
           
            Console.Write("Введите возраст: ");
            string age = Console.ReadLine();

            Console.Write("Введите номер тел.: ");
            string number = Console.ReadLine();

            Console.WriteLine("Введите домашний адрес: ");
            Console.Write("Город: ");
            string city = Console.ReadLine();
            Console.Write("Улица: ");
            string street = Console.ReadLine();
            Console.Write("Дом: ");
            string home = Console.ReadLine();

            Console.WriteLine();
           
            Console.WriteLine($"Данные человека:\nФИО:{name.Trim()}\nВозраст:{age.Trim()}\nНомер тел.:{number.Trim()}\nДомаш.адрес:{city.Trim()},{street.Trim()},{home.Trim()}");
           
            Console.Beep();

            Console.ReadKey();
            

        }
    }
}
