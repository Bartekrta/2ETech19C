using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ZADANIE 1
            /*int a = int.Parse(Console.ReadLine());
            if(a%3==0) Console.WriteLine("TAK");
            
            else Console.WriteLine("NIE");*/

            //ZADANIE 2
            /*int a = int.Parse(Console.ReadLine());
            if (a>=100 && a<1000 && a%17==0)
            {
                Console.WriteLine(TAK");
            }
            else
            {
                Console.WriteLine("NIE");
            }*/

            //ZADANIE 3
            /*int a = int.Parse(Console.ReadLine());
            if (a < 18)
            {
                Console.WriteLine("NIE");
            }
            else
            {
                Console.WriteLine("TAK");
            }*/

            //ZADANIE 4
            /*float limit = 20, waga = float.Parse(Console.ReadLine());
            if (waga > limit)
            {
                Console.WriteLine("NIE");
            }
            else
            {
                Console.WriteLine("TAK");
            }*/

            //ZADANIE 5
            /* int a = int.Parse(Console.ReadLine()),
                 b = int.Parse(Console.ReadLine()),
                 c = int.Parse(Console.ReadLine());
             if (a>b && a > c && c>b)
             {
                 Console.WriteLine("TAK");
             }
             else if (b>a && a<c && c<b)
             {
                 Console.WriteLine("TAK");
             }
             else
             {
                 Console.WriteLine("NIE");
             }*/

            //ZADANIE 6
            /*int a = int.Parse(Console.ReadLine()),
                p = int.Parse(Console.ReadLine());
            if ((Math.Pow(a,p) -a) % p == 0)
            {
                Console.WriteLine("TAK, spełniają MTF");
            }
            else
            {
                Console.WriteLine("NIE, nie spełniają MTF");
            }*/
            //ZADANIE 7
            /*int p = int.Parse(Console.ReadLine()),
                k = int.Parse(Console.ReadLine()),
                s = int.Parse(Console.ReadLine());
            if (p + 3 * s >= k)
            {
                Console.WriteLine("TAK, żaba da rade");
            }
            else
            {
                Console.WriteLine("NIe, żaba nie da rady");
            }*/
        }
    }
}
