using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork1._2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Написать консольное приложение, которое будет запрашивать ввод данных о продукте.

            Console.WriteLine("Введите данные о продукте:");

            Console.Write("Название: ");
            string name = Console.ReadLine();
                      
            Console.Write("Количество: ");
            string number = Console.ReadLine();
            float numb = Single.Parse(number.Replace('.',','));
            
            Console.Write("Единицы измерения.: ");
            string units = Console.ReadLine();

            Console.Write($"Цена за един. в грн.: "); ;
            string price = Console.ReadLine();
            float price1 = Single.Parse(price.Replace('.', ','));
                        
            float allPrice = price1 * numb;

            Console.Clear();

            Console.WriteLine($"Данные о продукте:\nНазвание: {name.Trim().ToUpper()}.\nКоличество: {numb} {units.ToLower()}.\nЦена: {price1} грн.\n\nОбщая цена: {allPrice} грн.");
            Console.Beep();
            Console.ReadKey();



        }
    }
}
