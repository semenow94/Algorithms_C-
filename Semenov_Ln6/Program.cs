using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semenov_Ln6
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine(EasyHash("Это простая хэш функция"));
            Console.WriteLine();
            BinaryTree bTree = new BinaryTree(20);
            Console.WriteLine("Распечатка двоичного дерева в виде скобочной записи");
            bTree.PrintTree();
            Console.WriteLine();
            Console.WriteLine("Прямой обход");
            bTree.PreOrderTreeTravers(bTree.head);
            Console.WriteLine();
            Console.WriteLine("Поиск цифры 5");
            Console.WriteLine(bTree.Search(5));
            Console.ReadLine();
        }
        //Реализовать простейшую хеш-функцию.На вход функции подается строка, на выходе сумма кодов символов.
        public static int EasyHash(string str)
        {
            int hash = 0;
            for(int i=0; i<str.Length; i++)
            {
                hash += Convert.ToInt32(str[i]);
            }
            return hash;
        }
        //Переписать программу, реализующую двоичное дерево поиска.
        //а) Добавить в него обход дерева различными способами;
        //б) Реализовать поиск в двоичном дереве поиска;
        public class TreeNode
        {
            public int value;
            public TreeNode left;
            public TreeNode right;
            public TreeNode parent;
            public TreeNode(int val, TreeNode par)
            {
                value = val;
                parent = par;
                left = null;
                right = null;
            }
        }
        public class BinaryTree
        {
            public TreeNode head=null;
            public BinaryTree(int count)
            {
                Random rand = new Random();
                for(int i=0; i<count; i++)
                {
                    InsertNode(rand.Next(1, 100));
                }
            }
            void PrintTree(TreeNode root)
            {
                if (root != null)
                {
                    Console.Write($"{root.value}");
                    if (root.left != null || root.right != null)
                    {
                        Console.Write("(");
                        if (root.left != null)
                            PrintTree(root.left);
                        else
                            Console.Write("Null");
                        Console.Write(",");
                        if (root.right != null)
                            PrintTree(root.right);
                        else
                            Console.Write("Null");
                        Console.Write(")");
                    }
                }
            }
            public void PrintTree()
            {
                PrintTree(head);
            }
            public void InsertNode(int value)
            {
                if(head==null)
                {
                    head = new TreeNode(value, null);
                    return;
                }
                bool flag = true;
                TreeNode par = head;
                while(flag)
                {
                    if(value<par.value)
                    {
                        if(par.left==null)
                        {
                            par.left = new TreeNode(value, par);
                            flag = false;
                        }
                        else
                        {
                            par = par.left;
                            continue;
                        }
                    }
                    else //равные значения тоже попадают в эту ветку
                    {
                        if (par.right == null)
                        {
                            par.right = new TreeNode(value, par);
                            flag = false;
                        }
                        else
                        {
                            par = par.right;
                            continue;
                        }
                    }
                }
            }
            public void PreOrderTreeTravers(TreeNode parent)
            {
                if (parent != null)
                {
                    Console.Write(parent.value+" ");
                    PreOrderTreeTravers(parent.left);
                    PreOrderTreeTravers(parent.right);
                }
            }
            public bool Search(int value)
            {
                if (Search(value, head)) return true;
                return false;
            }
            bool Search(int value, TreeNode searchIn)
            {
                if(searchIn!=null)
                {
                    if (searchIn.value == value)
                    {
                        return true;
                    }
                    else
                    {
                        if (Search(value, searchIn.left)) return true;
                        if (Search(value, searchIn.right)) return true;
                    }
                }
                return false;
            }  
        }        
    }
}
