using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1 номер");
            Console.WriteLine("Введите ваше имя: ");
            string name = Console.ReadLine();
            Console.WriteLine($"Доброго времени суток, {name}");
            Console.ReadLine();
            Console.Clear();


            Console.WriteLine("2 номер");
            Console.WriteLine("Введите первое число");
            int first;
            bool isNum1 = int.TryParse(Console.ReadLine(), out first);
            Console.WriteLine("Введите второе число");
            int second;
            bool isNum2 = int.TryParse(Console.ReadLine(), out second);
            if (isNum1 && isNum2)
            {
                if (second != 0)
                {
                    Console.WriteLine(first / second);

                }
                else Console.WriteLine("Деление на ноль");
            }
            else Console.WriteLine("Введено не число");
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("1 номер дз");
            Console.WriteLine("Введите букву");
            char letter = char.Parse(Console.ReadLine());
            if (letter == 'z')
                Console.WriteLine("a");
            else
                Console.WriteLine((char)(letter + 1));
            Console.ReadLine();
            Console.Clear();

            Console.Write("a: ");
            Console.WriteLine("2 номер дз");
            Console.WriteLine("Введите коэффициенты квадратного уравнения:");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("b: ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.Write("c: ");
            double c = Convert.ToDouble(Console.ReadLine());
            double discriminant = b * b - 4 * a * c;
            if (discriminant > 0)
            {
                double root1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
                double root2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
                Console.WriteLine($"Уравнение имеет два корня: x1 = {root1}, x2 = {root2}");
            }
            else if (discriminant == 0)
            {
                double root = -b / (2 * a);
                Console.WriteLine($"Уравнение имеет один корень: x = {root}");
            }
            else
            {
                Console.WriteLine("Уравнение не имеет корней");
            }
            Console.Clear();

           


        }



    }
}
