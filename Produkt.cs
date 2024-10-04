namespace JednoduchyPriklad;

public class Produkt
{
    /// <summary>
    /// Id produktu
    /// </summary>
    public int Id { get; private set; }

    /// <summary>
    /// Nazev produktu
    /// </summary>
    public string Nazev { get; private set; }

    /// <summary>
    /// Popis produktu
    /// </summary>
    public string Popis { get; private set; }

    /// <summary>
    /// Cena produktu
    /// </summary>
    public double Cena { get; private set; }

    /// <summary>
    /// Instance produktu
    /// </summary>
    /// <param name="nazev">Nazev</param>
    /// <param name="popis">Popis</param>
    /// <param name="cena">Cena</param>
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