using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Semenov_Ln5
{
    class Program
    {
        static void Main()
        {
            //Реализовать перевод из десятичной в двоичную систему счисления с использованием стека.
            IntToBinStack(2);
            IntToBinStack(3);
            IntToBinStack(10);
            Console.WriteLine();
            //*Реализовать очередь.
            Console.WriteLine("Заполняем очередь");
            Queue queue = new Queue(10);
            queue.Push(10);
            Console.WriteLine("Выводим очередь");
            queue.Pop();
            queue.PrintAll();
            Console.ReadLine();

        }
        public static void IntToBinStack(int i)
        {
            Stack stack = new Stack();
            int number = i;
            while(number>=2)
            {
                stack.Push(number % 2);
                number /= 2;
            }
            stack.Push(number);
            Console.Write(i+" = ");
            stack.PrintAll();
            Console.WriteLine();
        }
        public class Stack
        {
            int count;
            int[] stack = new int[1000];
            public Stack()
            {
                count = -1;
            }
            public void Push(int i)
            {
                count++;
                stack[count] = i;
            }
            public bool Pop()
            {
                if(count!=-1)
                {
                    count--;
                    Console.Write(stack[count+1]);
                    return true;
                }
                return false;
            }
            public void PrintAll()
            {
                bool flag = true;
                if(count!=-1)
                {
                    while(flag)
                    {
                        flag=Pop();
                    }
                }
            }
        }
        public class QueueEl
        {
            public int i;
            public QueueEl nextQu;
            public QueueEl(int value, QueueEl next)
            {
                i = value;
                nextQu = next;
            }
        }
        public class Queue
        {
            int count;
            public QueueEl first;
            QueueEl end;
            public int Count
            {
                get { return count + 1; }
            }
            public Queue(int i)
            {
                count = -1;
                while(count<i-1)
                {
                    Push(count+1);
                }
            }
            public void Push(int value)
            {
                
                if(count==-1)
                {
                    first = new QueueEl(value, null);
                    end = first;
                }
                else
                {
                    end.nextQu = new QueueEl(value, null);
                    end = end.nextQu;
                }
                count++;
                Console.WriteLine("Add " + value);
            }
            public bool Pop()
            {
                if(count!=-1)
                {
                    Console.WriteLine(first.i);
                    first = first.nextQu;
                    count--;
                    return true;
                }
                else Console.WriteLine("Очередь пуста");
                return false;
            }
            public void PrintAll()
            {
                if(count!=-1)
                {
                    bool flag = true;
                    while(flag)
                    {
                        flag = Pop();
                    }
                }
                
            }

        }
    }
}
