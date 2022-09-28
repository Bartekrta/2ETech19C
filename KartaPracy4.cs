using System;
using System.Collections.Generic;
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
            //ZADANIE1
            /*int a, b, suma;
            Console.WriteLine("Podaj liczbe a: ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj liczbe b: ");
            b = int.Parse(Console.ReadLine());
            a = a * a;
            b = b * b;
            suma = a + b;
            Console.WriteLine($"Suma kwadratów liczb = {suma}");*/
            //ZADANIE 3
            /*int x, y, z, a, b, c;
            try
            {
                x = int.Parse(Console.ReadLine());
                y = int.Parse(Console.ReadLine());
                z = int.Parse(Console.ReadLine());
                if (x > y && x > z)
                {
                    a = x;
                    if (y > z)
                    {
                        b = y;
                        c = z;
                    }
                    else
                    {
                        b = z;
                        c = y;
                    }
                }
                else if (y > x && y > z)
                {
                    a = y;
                    if (x > z)
                    {
                        b = x;
                        c = z;
                    }
                    else
                    {
                        b = z;
                        c = x;
                    }
                }
                else
                {
                    a = z;
                    if (x > y)
                    {
                        b = x;
                        c = y;
                    }
                    else
                    {
                        b = y;
                        c = x;
                    }
                }
                Console.WriteLine($"{c} {b} {a}");
            }
            catch
            {
                Console.WriteLine("Błąd.");
            }*/
            //ZADANIE 4
            /*int n, silnia=1;
            n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++) 
            {
                silnia = silnia * i; 
            }
            Console.WriteLine(silnia);*/
            //ZADANIE 5
            /*for(int i=-7; i<=17; i = i + 4)
            {
                Console.Write($"{i}, ");
            }*/
            //ZADANIE 6
            /*int wynik = 2,i=0;
            while(i<5)
            {
                wynik *= 3;
                Console.Write($"{wynik}, ");
                i++;
            }*/
            //ZADANIE 9
            /*            int licznik = 0, x = int.Parse(Console.ReadLine());
                        while (x > 0)
                        {
                            x = x / 10;
                            licznik++;
                        }
                        Console.WriteLine(licznik);*/
            //ZADANIE 8
            /*int n = int.Parse(Console.ReadLine());
            bool b = true;
            for (int i = 2; i < Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    b = false;
                    break;
                }
            }
            if (b) Console.WriteLine("Jest pierwsza");
            else Console.WriteLine("Nie jest pierwsza");*/
            //ZADANIE 10
            int licznik = 0, x = int.Parse(Console.ReadLine());
            while (x > 0)
            {

                x = x / 10;
                licznik++;
            }
            Console.WriteLine(licznik);
        }
    }
}
