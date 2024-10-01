namespace JednoduchyPriklad;

public class Objednavka: IOrder
{
    private Produkt Produkt { get; }
    private Zakaznik Zakaznik { get; }
    private Adresa Adresa { get; }
    

    public Objednavka(int id, Produkt produkt, Zakaznik zakaznik)
    {
        Produkt = produkt;
        Zakaznik = zakaznik;
    }

    public override string ToString()
    {
        return Produkt + " " + Zakaznik;
    }


    public int Number
    {
        get
        {
            return Zakaznik.Cislo;
        }
    }

    public string FirstName
    {
        get
        {
            return Zakaznik.Jmeno;
        }
    }

    public string LastName
    {
        get
        {
            return Zakaznik.Prijmeni;
        }
    }

    public string Street
    {
        get
        {
            return Adresa.Ulice;
        }
    }

    public int HouseNumber
    {
        get
        {
            return Adresa.CisloDomu;
        }
    }

    public int RegistryNumber
    {
        get
        {
            return Adresa.CisloUlice;
        }
    }

    public string City
    {
        get
        {
            return Adresa.Mesto;
        }
    }

    public string ZipCode
    {
        get
        {
            // return Adresa.SmerovaciCislo
            return null;
        }
    }

    public string Country
    {
        get
        {
            return Adresa.Zeme;
        }
    }

    public string[] Products { get; }
    public int[] Quantities { get; }
    private double cena;

    public double[] Prices
    {
        get
        {
            return new[] { cena };
        }
        set
        {
            cena = Produkt.Cena;
        }
    }
}