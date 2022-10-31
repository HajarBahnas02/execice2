using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace execice2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
                int[] t = { 2, 9, 14, 18, 26 };
                int i;
                Console.WriteLine("entrez un nombre:");
                int x = Convert.ToInt32(Console.ReadLine());
                t[4] = x;
                for (i = 4; i > 0; i--)
                {
                    if (t[i - 1] > x)
                    {
                        t[i] = t[i - 1];
                        t[i - 1] = x;
                    }
                }
                for (i = 0; i < 5; i++)
                {
                    Console.Write("\t" + t[i]);
                }
                  Console.ReadLine();
        }
        }
    }


   