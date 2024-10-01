namespace JednoduchyPriklad;

public class Produkt
{
    string Nazev { get; }
     string Popis { get; }
    public double Cena { get; }

    public Produkt(string nazev, string popis, double cena)
    {
        Nazev = nazev;
        Popis = popis;
        Cena = cena;
    }

    public override string ToString()
    {
        return Nazev + ", " + Popis;
    }
}