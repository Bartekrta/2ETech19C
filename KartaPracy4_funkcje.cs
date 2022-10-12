using System;
using System.CodeDom.Compiler;
using System.Collections;
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
    class Program
    {
        public static int kp1z1(int a, int b)
        {
            return a * a + b * b;
        }
        public static bool kp2z2(int a)
        {
            return a >= 100 && a < 1000 && a % 17 == 0 ? true : false;
        }
        public static bool kp2z6(int a, int p)
        {
            return (Math.Pow(a, p) - a) % p == 0 ? true : false;
        }
        public static void kp3z1(int n)
        {
            for (int i = 0; i < n; i++) Console.Write($"{i * i * i + 3}, ");
        }
        public static ArrayList kp3z3(int n)
        {
            ArrayList alist = new ArrayList();
            for (int i = 1; i <= (n * 0.5); i++)
            {
                if (n % i == 0)
                {
                    alist.Add(i);
                }
            }
            alist.Add(n);
            return alist;
        }
        public static int Zad2(int n)
        {
            int sumaCyfr = 0, cyfra = 0;
            while (n > 0)
            {
                cyfra = n % 10;
                sumaCyfr += cyfra;
                n = n / 10;
            }
            return sumaCyfr;
        }
        public static int silnia(int n)
        {
            if(n==0) return 1;
            return n * silnia(n - 1);
        }
        public static int Fibo(int n)
        {
            if (n == 0) return 0;
            if (n < 2) return 1;
            return Fibo(n - 1) + Fibo(n - 2);
        }
        static void Main()
        {
            //ZAD 1 KP1Z1
            /*int a = int.Parse(Console.ReadLine()),
                b = int.Parse(Console.ReadLine());
            Console.WriteLine(kp1z1(a,b));*/
            //ZAD 1 KP2Z2
            /*int a = int.Parse(Console.ReadLine());
            Console.WriteLine(kp2z2(a) ? "TAK":"NIE");*/
            //ZAD 1 KP2z6
            /*int a = int.Parse(Console.ReadLine()),
                p = int.Parse(Console.ReadLine());
            Console.WriteLine(kp2z6(a,p) ? "TAK":"NIE");*/
            //ZAD 1 KP3z1
            /*int n = int.Parse(Console.ReadLine());
            kp3z1(n);*/
            //ZAD 1 KP3z3
            /*int n = int.Parse(Console.ReadLine());
            ArrayList dzielniki = new ArrayList();
            dzielniki = kp3z3(n);

            foreach(int a in dzielniki)
            {
                Console.WriteLine(a + " ");
            }*/

            //ZADANIE 2
            /*int n = int.Parse(Console.ReadLine());
            Console.WriteLine(Zad2(n));*/
            //ZADANIE 3
            /*int n = int.Parse(Console.ReadLine());
            Console.WriteLine(silnia(n));*/
            //ZADANIE 4
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(Fibo(n));
        }
        
    }
}
