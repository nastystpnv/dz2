using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboratoryWork1
{
    internal class Program
    {
        enum bankType
        {
            current,
            saving
        }
        enum university
        {
            KGU,
            KAI,
            KHTI
        }
        struct bankInfo
        {
            public int number;
            public bankType type;
            public int money;
        }
        struct Worker
        {
            public string name;
            public university university;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("1 номер");
            bankType q = bankType.saving;
            Console.WriteLine(q);
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("2 номер");
            bankInfo info = new bankInfo();
            info.number = 1;
            info.type = bankType.current;
            info.money = 100000000;
            Console.WriteLine(info.number + "\n" + info.type + "\n" + info.money);
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("1 номер дз");
            Worker worker1 = new Worker { name = "лиза баскетболистка", university = university.KGU };
            Worker worker2 = new Worker { name = "карим андрей", university = university.KAI };
            Worker worker3 = new Worker { name = "даша тяжелый люкс", university = university.KHTI };

            Console.WriteLine("Работники:");
            Console.WriteLine($"{worker1.name} ({worker1.university})");
            Console.WriteLine($"{worker2.name} ({worker2.university})");
            Console.WriteLine($"{worker3.name} ({worker3.university})");
            Console.ReadLine();
            Console.Clear();
        }
    }
}
