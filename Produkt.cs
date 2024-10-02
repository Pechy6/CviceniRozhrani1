namespace JednoduchyPriklad;

public class Produkt
{
    public int Id { get; private set; }
    public string Nazev { get; private set; }
    public string Popis { get; private set; }
    public double Cena { get; private set; }

    public Produkt(string nazev, string popis, double cena)
    {
        Id += 1;
        Nazev = nazev;
        Popis = popis;
        Cena = cena;
    }

    public override string ToString()
    {
        return Nazev + ", " + Popis;
    }
}