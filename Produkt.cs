namespace JednoduchyPriklad;

public class Produkt
{
    string Nazev { get; }
    string Popis { get; }

    public Produkt(string nazev, string popis)
    {
        Nazev = nazev;
        Popis = popis;
    }

    public override string ToString()
    {
        return Nazev + ", " + Popis;
    }
}