using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboratoryWork
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Минимальные и максимальные значения различных типов данных:");

            Console.WriteLine("byte: Минимальное значение = {0}, Максимальное значение = {1}", byte.MinValue, byte.MaxValue);
            Console.WriteLine("sbyte: Минимальное значение = {0}, Максимальное значение = {1}", sbyte.MinValue, sbyte.MaxValue);
            Console.WriteLine("short: Минимальное значение = {0}, Максимальное значение = {1}", short.MinValue, short.MaxValue);
            Console.WriteLine("ushort: Минимальное значение = {0}, Максимальное значение = {1}", ushort.MinValue, ushort.MaxValue);
            Console.WriteLine("int: Минимальное значение = {0}, Максимальное значение = {1}", int.MinValue, int.MaxValue);
            Console.WriteLine("uint: Минимальное значение = {0}, Максимальное значение = {1}", uint.MinValue, uint.MaxValue);
            Console.WriteLine("long: Минимальное значение = {0}, Максимальное значение = {1}", long.MinValue, long.MaxValue);
            Console.WriteLine("ulong: Минимальное значение = {0}, Максимальное значение = {1}", ulong.MinValue, ulong.MaxValue);
            Console.WriteLine("float: Минимальное значение = {0}, Максимальное значение = {1}", float.MinValue, float.MaxValue);
            Console.WriteLine("double: Минимальное значение = {0}, Максимальное значение = {1}", double.MinValue, double.MaxValue);
            Console.WriteLine("decimal: Минимальное значение = {0}, Максимальное значение = {1}", decimal.MinValue, decimal.MaxValue);
            Console.WriteLine("char: Минимальное значение = {0}, Максимальное значение = {1}", char.MinValue, char.MaxValue);
            Console.WriteLine("bool: Минимальное значение = {0}, Максимальное значение = {1}", bool.FalseString, bool.TrueString);

            Console.WriteLine("2 номер");
            Console.Write("Введите ваше имя: ");
            string name = Console.ReadLine();
            Console.Write("Введите ваш town: ");
            string town = Console.ReadLine();
            Console.Write("Введите ваш age: ");
            int age = int.Parse(Console.ReadLine());
            Console.Write("Введите ваш PIN-код: ");
            string pin = Console.ReadLine();
            Console.WriteLine("\nИнформация о пользователе:");
            Console.WriteLine("Имя: " + name);
            Console.WriteLine("town: " + town);
            Console.WriteLine("age: " + age + " лет");
            Console.WriteLine("PIN-код: " + pin);
            Console.ReadKey();

            Console.WriteLine("3 номер");

            Console.Write("Введите строку: ");
            string inputAr = Console.ReadLine();

            char[] charAr = inputAr.ToCharArray();
            for (int i = 0; i < charAr.Length; i++)
            {
                if (char.IsLower(charAr[i]))
                {
                    charAr[i] = char.ToUpper(charAr[i]);
                }
                else if (char.IsUpper(charAr[i]))
                {
                    charAr[i] = char.ToLower(charAr[i]);
                }
            }
            for (int i = 0; i < charAr.Length; i++)
            {
                Console.Write(charAr[i]);
            }
            Console.ReadKey();


        }


    }

}
