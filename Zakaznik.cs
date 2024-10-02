namespace JednoduchyPriklad;

public class Zakaznik
{
    public int Id { get; private set; }
    public string Jmeno { get; }
    public string Prijmeni { get; }

    Adresa Adresa { get; } // zatim nechapu jak a proc

    public Zakaznik(int id, string jmeno, string prijmeni)
    {
        Id = id;
        Jmeno = jmeno;
        Prijmeni = prijmeni;
    }

    public override string ToString()
    {
        return Id + ", " + Jmeno + ", " + Prijmeni;
    }
}