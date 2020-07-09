using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Семенов Дмитрий
namespace LN1
{
    class Program
    {
        static int i=-1;
        static void Main()
        {
            while(i!=0)
            {
                Console.WriteLine("0 - Выход");
                Console.WriteLine("1-программу обмена значениями двух целочисленных переменных");
                Console.WriteLine("2 - Используя только операции сложения и вычитания, найти частное от деления нацело N на K, а также остаток от этого деления.");
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
                    case 3:
                        Task3();
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
            //Написать программу обмена значениями двух целочисленных переменных:
            //a.с использованием третьей переменной;
            //b. * без использования третьей переменной.
            int a = 5;
            int b = 4;
            int c;
            Console.WriteLine($"a = {a}  b = {b}");
            Console.WriteLine("3 переменные");
            c = a;
            a = b;
            b = c;
            Console.WriteLine($"a = {a}  b = {b}");
            Console.WriteLine("2 переменные");
            a += b;
            b = a - b;
            a -= b;
            Console.WriteLine($"a = {a}  b = {b}");
        }
        public static void Task2()
        {
            //Даны целые положительные числа N и K.Используя только операции сложения и вычитания, найти частное от деления нацело N на K, а также остаток от этого деления.
            int a = 2;
            int b = 3;
            int c = a;
            int count = 0;
            while (c >= b)
            {
                c -= b;
                i++;
            }
            Console.WriteLine($"частное от деления нацело {a} на {b} = {count}");
            Console.WriteLine($"остаток от этого деления {a} на {b} = {c}");
        }
        public static void Task3()
        {
            //Найти максимальное из четырех чисел.Массивы не использовать.
            int count = 0;
            int max=0;
            while(count<3)
            {
                Console.WriteLine("Введите целое число");
                int number = Convert.ToInt32(Console.ReadLine());
                if (count == 0) max = number;
                if (number > max) max = number;
                count++;
            }
            Console.WriteLine($"Максималье число {max}");
        }
    }
}
