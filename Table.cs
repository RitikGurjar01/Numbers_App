using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace table
{
    internal class Table
    {
        public void TakeInput()
        {
            Console.WriteLine("  ");
            Again();
        }
        public void Odd(int a)
        { 
            for (int i = 1; i <= a; i = i + 2)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);

                }
            }
            Again();
        }

        public void Even(int a)
        {
            for (int i = 1; i <= a; i = i + 1)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);

                }
            }
            Again();
        }

        public void Prime(int a)
        {
            for (int i = 1; i <= a; i++)
            {
                int b = i;
                int c = 0;
                for (int j = 2; j <= b - 1; j++)
                {
                    if (b % j == 0)
                    {
                        c = 1;
                        break;
                    }
                }
                if (c == 0)
                    
                    Console.WriteLine(b);

            }
            Again();
        }
        public void table(int a)
        {
            for (int i = 1; i <= 10; i++)
            {
                int c = i * a;
                Console.WriteLine(c);


            }
            Again();
        }
        public void Again()
        {
                Console.WriteLine("Print Odd number so Tab = 1");
                Console.WriteLine("Print Even number so Tab = 2");
                Console.WriteLine("Print Prime number so Tab = 3");
                Console.WriteLine("Print Table of number so Tab = 4");
                Console.WriteLine("What do you want");
                int n = Convert.ToInt32(Console.ReadLine());
                Console.Write("enter number between you want print=");
                int a = Convert.ToInt32(Console.ReadLine());
                if (n == 1)
                {
                    Odd(a);
                }
                else if (n == 2)
                {
                    Even(a);
                }
                else if (n == 3)
                {
                    Prime(a);
                }
                else if (n == 4)
                {
                    table(a);
                }
                else
                {
                    Console.WriteLine("wrong input");
                }

            }
        }

    }


