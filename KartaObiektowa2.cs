using System.Runtime;
using System.Transactions;

class Produkt
{
    string nazwa;
    double cena;
    string opis;

    public string getNazwa()
    {
        return nazwa;
    }
    public double getCena()
    {
        return cena;
    }
    public string getOpis()
    {
        return opis;
    }
    public Produkt(string nazwa, double cena, string opis)
    {
        this.nazwa = nazwa;
        this.cena = cena;
        this.opis = opis;
    }
}
class Koszyk
{
    int id;
    Produkt produkt;
    Uzytkownik uzytkownik;

    public int getId()
    {
        return id;
    }
    public void operation()
    {
        Console.WriteLine("Operation");
    }
    public Koszyk(int id,Produkt produkt)
    {
        this.id = id;
        this.produkt = produkt;
    }
    public void setUzytkownik(Uzytkownik uzytkownik)
    {
        this.uzytkownik = uzytkownik;
    }
}
class Uzytkownik
{
    string login;
    string haslo;
    Profil profil;

    public void loguj()
    {
        Console.WriteLine("Zalogowano");
    }
    public Uzytkownik(Profil profil, string login, string haslo)
    {
        this.profil = profil;
        this.login = login;
        this.haslo = haslo;
    }
}
class Profil
{
    string imie;
    string drugieimie;
    string nazwisko;

    public string getImie()
    {
        return imie;
    }
    public string getNazwisko()
    {
        return nazwisko;
    }
}

class Program
{
    static void Main(string[] args)
    {
        
    }
}
