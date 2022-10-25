using System;

namespace KartaPracy3B
{
    class Program
    {
        public static void Main()
        {
            //Zadanie 1
            /*Console.Write("Dni listopada: ");
            for (int i = 0; i <= 30; i++) Console.Write(i + ", ");*/
            //Zadanie 2
            /*Console.Write("Podaj górny zakres liczb: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i = i + 2) Console.Write(i*i + ", ");*/
            //Zadanie 3
            /*for (int i = 1000; i < 10000; i++)
            {
                if (i % 379 == 0) Console.Write(i + ", ");
            }*/
            //Zadanie 4
            /*for (int i = 100; i < 1000; i++)
            {
                if (i % 5 == 0 || i % 6 == 0 || i % 11 == 0) Console.Write(i + ", ");
            }*/
            //Zadanie 5
            /*Console.Write("Ile liczb chcesz zsumować: ");
            int n = int.Parse(Console.ReadLine());
            int suma = 0, a = 0;
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Podaj {i + 1} liczbe: ");
                a = int.Parse(Console.ReadLine());
                suma += a;
            }
            Console.WriteLine($"Suma podanych liczb wynosi {suma}");*/
            //Zadanie 6
            /*Console.Write("Podaj ilość liczb: ");
            int suma = 0, k = int.Parse(Console.ReadLine());
            for (int i = 0; i <= k; i++)
            {
                if (i % 2 == 0) suma += i;
            }
            Console.WriteLine(suma);*/
            //Zadanie 7
            /*Console.Write("Podaj ilość liczb: ");
            int m = int.Parse(Console.ReadLine());
            int suma = 0;
            for (int i = 11; i < (m * 2) + 10; i += 2)
            {
                suma += i;
            }
            Console.WriteLine($"Suma liczb wynosi = {suma}");*/
            //Zadanie 8
            /*Console.Write("Podaj kwote wejściową: ");
            int w = int.Parse(Console.ReadLine());
            Console.Write("Podaj długość inwestycji: ");
            double l = double.Parse(Console.ReadLine()) * 2;
            double wy = w;
            while (true)
            {
                if (l - 2 >= 0)
                {
                    wy *= 1.06;
                    l -= 2;
                }
                else
                {
                    wy *= 1.03;
                    break;
                }
            }
            Console.WriteLine($"Kwota wyjściowa: {wy}");*/
            //Zadanie 9
            /*Console.WriteLine("Prosze podac liczbe");
            int n = int.Parse(Console.ReadLine());
            int suma = 0;
            for (int i = 21; i <= (n - 1) * 100 + 21; i += 100)
            {
                suma += i;
            }
            Console.WriteLine($"Suma wynosi {suma}");*/
            //Zadanie 10
            /*int j, i, rob, nieparzysta, pierwiastek, liczbacyfr, potegadziesiatki;
            for (j = 1; j <= 1000; j++)
            {
                pierwiastek = 0;
                nieparzysta = 1;
                rob = j;
                while (rob >= 0)
                {
                    rob -= nieparzysta;
                    nieparzysta += 2;
                    pierwiastek++;
                }

                pierwiastek--;

                if (pierwiastek * pierwiastek == j)
                {
                    //liczba cyfr pierwiastka
                    liczbacyfr = 0;
                    rob = pierwiastek;
                    while (rob != 0)
                    {
                        liczbacyfr++;
                        rob /= 10;

                    }
                    //potêga liczby 10
                    potegadziesiatki = 1;
                    for (i = 1; i <= liczbacyfr; i++) potegadziesiatki *= 10;

                    if (j % potegadziesiatki == pierwiastek) Console.WriteLine(j);
                }
            }*/
        }
       }
}
