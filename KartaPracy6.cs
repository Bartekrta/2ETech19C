//Zadanie 1
/*internal class Program
{
    static bool Artymetyczny(int a, int b, int c)
    {
        int tmp1 = c - b;
        int tmp2 = b - a;
        int tmp3 = a - b;
        int tmp4 = b - c;
        if (a == b || b == c) return false;
        else if (tmp1 == tmp2 || tmp3 == tmp4) return true;
        else return false;
    }
    static bool Geometryczny(int a, int b, int c)
    {
        int tmp1 = b / a;
        int tmp2 = a / b;
        if (tmp1 * b == c || c * tmp2 == b) return true;
        else return false;
    }
    static bool Rosnacy(int a, int b, int c)
    {
        if (a < b && b < c) return true;
        else return false;
    }
    private static void Main(string[] args)
    {

        int[] l = new int[3];
        for (int i = 0; i < 3; i++)
        {
            Console.Write($"Podaj {i + 1} liczbe: ");
            l[i] = int.Parse(Console.ReadLine());
        }
        if (Artymetyczny(l[0], l[1], l[2])) Console.WriteLine("Artymetyczny");
        if (Geometryczny(l[0], l[1], l[2])) Console.WriteLine("Geometryczny");
        if (l[0] == l[1] || l[1] == l[2]) Console.WriteLine("Ciąg stały");
        else if (Rosnacy(l[0], l[1], l[2])) Console.WriteLine("Ciąg rosnący");
        else Console.WriteLine("Ciąg malejący");
    }
}*/

//Zadanie 2
/*internal class Program
{
    private static void Main(string[] args)
    {
        int suma = 0;
        for (int i = 100; i < 1000; i++)
        {
            if (i % 8 == 0 && i % 16 != 0) suma += i;
        }
        Console.WriteLine($"Suma = {suma}");
    }
}*/

//Zadanie 3
/*int podstawa = 0;
int ile = 0;

for (int i = 99; i >= 10; i--)
{
    if (i % 7 == 0)
    {
        podstawa = i;
        break;
    }
}

for (int i = 1000; i < 10000; i++)
{
    if (i % podstawa == 0) ile++;
}

Console.WriteLine(ile);*/

//Zadanie4
/*int jednosci, dziesiatki, tmp, ile = 0;

for(int i = 10; i<100; i++)
{
    tmp = i;
    jednosci = tmp % 10;
    tmp /= 10;
    dziesiatki = tmp % 10;
    if (jednosci * 2 < dziesiatki) ile++;
}
Console.WriteLine(ile);*/

//Zadanie 5
/*int setki, dziesiatki, jednosci, tmp, ile=0, suma = 0;

for(int i = 100; i < 1000; i++)
{
    tmp = i;
    jednosci = tmp % 10;
    tmp /= 10;
    dziesiatki = tmp % 10;
    tmp /= 10;
    setki = tmp % 10;
    Console.WriteLine($"{setki}, {dziesiatki}, {jednosci}");
    if(setki > jednosci + dziesiatki)
    {
        ile++;
        suma += i;
    }
}
Console.WriteLine($"Ilość liczb: {ile} \n Suma: {suma}");*/

//Zadanie 6
/*Console.Write("Ile najmiejszych liczb: ");
int n = int.Parse(Console.ReadLine());
int suma = 0;

for(int i = 10; i < 100; i++)
{
    if (i % 19 == 0)
    {
        suma += i;
        n--; 
        if (n <= 0) break;
    }
}
Console.WriteLine(suma);*/

//Zadanie 7
/*int n = int.Parse(Console.ReadLine());
int suma = 0;

for(int i = 999; i>=100; i--)
{
    if (i % 37 == 0)
    {
        suma += i;
        n--;
        if (n <= 0) break;
    }
}
Console.WriteLine(suma);*/

//Zadanie 8
/*int suma = 0;
Console.Write("Ile elementów ciągu obliczyć: ");
int n = int.Parse(Console.ReadLine());
int znak = 1;
int elciagu = 2;

for (int i = 1; i <= n; i++)
{
    suma += znak * (elciagu);
    znak *= -1;
    elciagu += 3;
}

Console.WriteLine($"Suma n pierwszych elementów ciągu: {suma}");*/

//Zadanie 9
/*Console.Write("Ile elementów ciągu oblczyć: ");
int n = int.Parse(Console.ReadLine());
int iloczyn = 1;
int znak = 1;
int elciagu = 1;
if (n == 1) iloczyn = 1;
else
{
    for (int i = 1; i <= n; i++)
    {
        iloczyn *= znak * elciagu;
        elciagu *= 2;
        znak *= -1;
    }
}

Console.WriteLine($"Suma: {iloczyn}");*/

//Zadanie 10
/*internal class program
{
    public static int silnia(int n)
    {
        if (n > 1) return n * silnia(n - 1);
        else return 1;

    }
    static void Main(string[] args)
    {
        Console.Write("Ile elementów ciągu obliczyć: ");
        int n = int.Parse(Console.ReadLine());
        int suma = 0;

        for(int i = 1; i <= n; i++) 
        {
            suma += silnia(i);
        }
        Console.WriteLine($"Suma ciągu: {suma}");
    }
}*/

