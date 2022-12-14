
internal class Program
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
    static bool Geometryczny(int a,int b,int c)
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
}


using System.Runtime.ExceptionServices;

internal class Program
{
    private static void Main(string[] args)
    {
        int suma = 0;
        for(int i = 100; i<1000; i++)
        {
            if (i % 8 == 0 && i % 16 != 0) suma+=i;
        }
        Console.WriteLine($"Suma = {suma}");
    }
}

