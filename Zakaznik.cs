namespace JednoduchyPriklad;

public class Zakaznik
{
    /// <summary>
    /// Id zakaznika 
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// Jmeno zakaznika
    /// </summary>
    public string Jmeno { get; }

    /// <summary>
    /// Prijmeni zakaznika
    /// </summary>
    public string Prijmeni { get; }

    /// <summary>
    /// Pristup ke tride Adresa
    /// </summary>
    Adresa Adresa { get; } // zatim nechapu ucel 

    /// <summary>
    /// Instance zakaznika
    /// </summary>
    /// <param name="id">Id</param>
    /// <param name="jmeno">Jmeno</param>
    /// <param name="prijmeni">Prijmeni</param>
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