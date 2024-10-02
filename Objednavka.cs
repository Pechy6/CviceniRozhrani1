namespace JednoduchyPriklad;

public class Objednavka : IOrder
{
    // atributy
    private int[] arrayTotalQuantities;
    private int totalQuantities = 0;
    private string[] products;

    // vlastnosti
    private Produkt Produkt { get; }
    private Zakaznik Zakaznik { get; }
    private Adresa Adresa { get; }


    public Objednavka(int id, Produkt produkt, Zakaznik zakaznik, Adresa adresa)
    {
        Produkt = produkt;
        Zakaznik = zakaznik;
        Adresa = adresa;
        totalQuantities += 1;
    }

    public override string ToString()
    {
        return Produkt + " " + Zakaznik;
    }


    public int Number
    {
        get { return Zakaznik.Id; }
    }

    public string FirstName
    {
        get { return Zakaznik.Jmeno; }
    }

    public string LastName
    {
        get { return Zakaznik.Prijmeni; }
    }

    public string Street
    {
        get { return Adresa.Ulice; }
    }

    public int HouseNumber
    {
        get { return Adresa.CisloDomu; }
    }

    public int RegistryNumber
    {
        get { return Adresa.CisloUlice; }
    }

    public string City
    {
        get { return Adresa.Mesto; }
    }

    public int Zip
    {
        get { return Adresa.SmerovaciCislo; }
    }

    public string Country
    {
        get { return Adresa.Zeme; }
    }

    public string[] Products
    {
        get
        {
            return products;
        }
        set
        {
            for (int i = 0; i < totalQuantities; i++)
            {
                products[i] = Produkt.Nazev;
            }
        }
    }

    public int[] Quantities { get; }

    public double[] Prices { get; }
}