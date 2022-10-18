using System;

namespace Program
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Zadanie 1

            /*Console.Write("Podaj pierwszą liczbe: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Podaj drugą liczbe:");
            int b = int.Parse(Console.ReadLine());
            string suma = ((a + b) % 2 == 0) ? "Suma podanych liczb jest parzysta" : "Suma podanych liczb jest nieparzysta";
            Console.WriteLine(suma);*/

            //Zadanie 2

            /*Console.Write("Podaj pierwszą liczbe: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Podaj drugą liczbe:");
            int b = int.Parse(Console.ReadLine());
            double artymetyczna = a + b / 2;
            double geometryczna = Math.Pow(a + b,1/2);
            string text = (artymetyczna > geometryczna) ? "Średnia artymetyczna podanych liczb jest większa" : "Średnia geometryczna podanych liczb jest większa";
            Console.WriteLine(text);*/

            //Zadanie 3

            /*Console.Write("Podaj pierwszą liczbe: ");
            int k = int.Parse(Console.ReadLine());
            Console.Write("Podaj drugą liczbe: ");
            int l = int.Parse(Console.ReadLine());
            Console.Write("Podaj trzecią liczbe: ");
            int m = int.Parse(Console.ReadLine());

            if (k == l && k != m) Console.WriteLine($"{k} == {l}");
            else if (k == m && k != l) Console.WriteLine($"{k} == {m}");
            else if (l == m && k != m) Console.WriteLine($"{l == m}");
            else Console.WriteLine("Żadne z podanych liczb nie są sobie równe");*/

            //Zadanie 4

            /*int[] liczby = new int[4];
            for(int i = 0; i < 4; i++)
            {
                Console.Write($"Podaj {i+1} liczbe: ");
                liczby[i] = int.Parse(Console.ReadLine());
            }
            int min  = liczby[0];
            for(int i = 1; i < 4; i++) 
            {
                if (liczby[i] < min) min = liczby[i];
            }
            Console.WriteLine($"Najmniejsza liczba to {min}");*/

            //Zadanie 5

            /*Console.Write("Podaj długość pierwszego boku trójkąta: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Podaj długość drugiego boku trójkąta: ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Podaj długość trzeciego boku trójkąta: ");
            int c = int.Parse(Console.ReadLine());

            if (a<b+c && b<a+c && c<a+b) Console.WriteLine("Podany trójkąt spełnia nierówności trójkąta");
            else Console.WriteLine("Podany trójkąt nie spełnia nierówności trójkąta");*/

            //Zadanie 6

            /*Console.Write("Podaj długość pierwszego boku trójkąta: ");
            float a = float.Parse(Console.ReadLine());
            Console.Write("Podaj długość drugiego boku trójkąta: ");
            float b = float.Parse(Console.ReadLine());
            Console.Write("Podaj długość trzeciego boku trójkąta: ");
            float c = float.Parse(Console.ReadLine());

            if (a>0 && b>0 && c>0 && a+b>c && b+c>a && a+c>b)
            {
                Console.Write("Podane liczby mogą być bokami dowolnego trójkąta i jest ");

                if (a*a + b*b > c*c) Console.Write("ostrokątny");

                else if ((a*a + b*b == c*c) || (a*a + c*c == b*b) || (c*c + b*b == a*a)) Console.WriteLine("prostokątny");

                else Console.WriteLine("rozwartokątny");
            }
            else Console.WriteLine("Podane liczby nie mogą być bokami trójkąta");*/
        }
    }
}
