using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semenov_Ln2
{
    class Program
    {
        static int i = -1;
        static void Main()
        {
            while (i != 0)
            {
                Console.WriteLine("0 - Выход");
                Console.WriteLine("1 - перевода из десятичной системы в двоичную ");
                Console.WriteLine("2 - возведения числа a в степень b ");
                Console.WriteLine("3 - Найти максимальное из четырех чисел. Массивы не использовать.");
                i = Convert.ToInt32(Console.ReadLine());
                switch (i)
                {
                    case 1:
                        Task1();
                        break;
                    case 2:
                        Task2();
                        break;
                    case 0:
                        Console.WriteLine("Выход");
                        break;
                    default:
                        Console.WriteLine("Нет такого значения");
                        i = -1;
                        break;
                }
            }
            Console.ReadLine();
        }
        public static void Task1()
        {
            //Реализовать функцию перевода из десятичной системы в двоичную, используя рекурсию.
            Console.Write("Введите целое число для перевода в двоичную систему ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write($"a = {IntToBin(a)}");
            Console.WriteLine();
        }
        public static string IntToBin(int value)
        {
            string str=null;
            int a;
            if (value > 0)
            {
                a = value / 2;
                if (a > 0) str+=IntToBin(a);
                a = value % 2;
                str += a;
                return str;
            }
            else
            {
                str += 0;
                return str;
            }
        }
        public static void Task2()
        {
            //Реализовать функцию возведения числа a в степень b:
            //a.без рекурсии;
            //b.рекурсивно;
            //c. * рекурсивно, используя свойство четности степени. Не нашел нигде что это такое
            int a = 2;
            int b = 1;//При условии что степень >= 0
            int c = 1;
            if(b>0)
            {
                for(int i=1; i<=b; i++)
                {
                    c *= a;
                }
            }
            Console.WriteLine($"{a}^{b} = {c}");
            Console.WriteLine($"Rec {a}^{b} = {Task2Rec(a,b)}");
        }
        public static int Task2Rec(int a, int b)
        {
            int c=1;
            if(b>0)
            {
                c *= a * Task2Rec(a, b - 1);
            }
            else return c;
            return c;
        }
    }
}
