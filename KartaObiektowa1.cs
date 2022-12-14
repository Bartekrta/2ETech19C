using System.Drawing;
using System.Reflection.Metadata;

class Rower
{
    string color;
    Producent producent;
    Material material;

    public void jedz()
    {
        Console.WriteLine("Jade");
    }
    public void setColor(string color)
    {
        this.color = color;
    }
    public void setMaterial(Material material)
    {
        this.material = material;
    }
    public string getColor()
    {
        return color;
    }
    public Rower(Producent producent, string color)
    {
        this.producent = producent;
        this.color = color;
    }
}
class Producent
{
    string nazwa;
    string nip;

    public string getNazwa()
    {
        return nazwa;
    }
    public string getNip()
    {
        return nip;
    }
    public void setNazwa(string nazwa)
    {
        this.nazwa = nazwa;
    }
}
class Material
{
    string typ;
    int id;
    double cena;

    public void setTyp(string typ)
    {
        this.typ = typ;
    }
    public string getTyp()
    {
        return typ;
    }
    public double getCena()
    {
        return cena;
    }
    public void setId(int id)
    {
        this.id = id;
    }
}
