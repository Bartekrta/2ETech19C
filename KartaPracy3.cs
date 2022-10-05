using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Runtime.InteropServices;
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
            /*int n = int.Parse(Console.ReadLine());
            for(int i = 0; i < n; i++)
            {
                Console.Write($"{i*i*i+3}, ");
            }*/

            //ZADANIE 2
            /*for (int i = 105; i < 1000; i+=15)
            {
                Console.Write($"{i}, ");
            }*/

            //ZADANIE 3
            /*int n = int.Parse(Console.ReadLine());
            for(int i=1; i<=(n*0.5); i++)
            {
                if (n % i == 0)
                {
                    Console.WriteLine(i);
                }
            }
            Console.WriteLine(n);*/

            //ZADANIE 4
            /*int suma = 0;
            for (int i = 10; i < 100; i++)
            {
                suma += i;
            }
            Console.WriteLine(suma);*/

            //ZADANIE 5
            /*Console.WriteLine("Podaj liczbe w którą gramy(n): ");
            int n = int.Parse(Console.ReadLine()),
                suma = (n * (n + 1) / 2),
                liczba;
            Console.WriteLine($"Podaj {n - 1} liczb a ja zgadne tą, której nie podałeś.");
            for(int i = 0; i < n-1; i++)
            {
                liczba = int.Parse(Console.ReadLine());
                suma = suma - liczba;
            }
            Console.WriteLine($"Wybrałeś {suma}");*/
            //ZADANIE 6
            /*int n = int.Parse(Console.ReadLine()),
                a = 0,
                b = 1,
                temp;
            for (int i = 0; i<n; i++)
            {
                temp = b;
                b = a + b;
                a = temp;
                Console.WriteLine(a);
            }*/
        }
    }
}
