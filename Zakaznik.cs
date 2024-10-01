namespace JednoduchyPriklad;

public class Zakaznik
{
    public int Cislo { get; }
    public string Jmeno { get; }
    public string Prijmeni { get; }

    Adresa Adresa { get; } // zatim nechapu jak a proc

    public Zakaznik(int cislo, string jmeno, string prijmeni)
    {
        Cislo = cislo;
        Jmeno = jmeno;
        Prijmeni = prijmeni;
    }

    public override string ToString()
    {
        return Cislo + ", " + Jmeno + ", " + Prijmeni;
    }
}