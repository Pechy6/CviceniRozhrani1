namespace JednoduchyPriklad;

public class Objednavka : IOrder
{
    /// <summary>
    /// Pocet kusu objednavky
    /// </summary>
    public int Number { get; private set; }

    /// <summary>
    /// pristup ke tride produkt
    /// </summary>
    private Produkt _produkt;

    /// <summary>
    /// Pristup ke tride zakaznik
    /// </summary>
    private Zakaznik _zakaznik;

    /// <summary>
    /// Pristup ke tride adresa
    /// </summary>
    private Adresa _adresa;

    /// <summary>
    /// List do ktereho ukladame nazev produktu
    /// </summary>
    private List<string> nazevProduktu;

    private List<int> quantityOfProtucts;

    private List<double> prices;

    /// <summary>
    /// Instance objednavky
    /// </summary>
    /// <param name="number">cislo objednavky</param>
    /// <param name="produkt">produkt</param>
    /// <param name="zakaznik">zakaznik</param>
    /// <param name="fakturacni">fakturacni adresa</param>
    /// <param name="dodaci">dodaci adresa</param>
    public Objednavka(int number, Produkt produkt, Zakaznik zakaznik, Adresa fakturacni, Adresa dodaci)
    {
        Number = number;
        _produkt = produkt;
        _zakaznik = zakaznik;
        _adresa = fakturacni;
        _adresa = dodaci;
        nazevProduktu = new List<string>();
        quantityOfProtucts = new List<int>();
        prices = new List<double>();
        PridejNazevProduktu(produkt.Nazev); // add nazev produktu
        PridejQuantitu(Number); // add pocet objednanych kusu
        PridejCenu(produkt.Cena);
    }

    /// <summary>
    /// Metoda slouzici k pridani nazvu do listu
    /// </summary>
    /// <param name="nazev"></param>
    private void PridejNazevProduktu(string nazev)
    {
        nazevProduktu.Add(nazev);
    }

    /// <summary>
    /// Metoda slouzici k pridani poctu kusu do listu
    /// </summary>
    /// <param name="quantita"></param>
    private void PridejQuantitu(int quantita)
    {
        quantityOfProtucts.Add(quantita);
    }

    /// <summary>
    /// Metoda slouzici k pridani ceny kusu do listu
    /// </summary>
    /// <param name="cena">Cena za kus</param>
    private void PridejCenu(double cena)
    {
        for (int i = 0; i < Number; i++)
        {
            prices.Add(cena);
        }
    }

    public override string ToString()
    {
        return _produkt + " " + _zakaznik;
    }

    /// <summary>
    /// Jmeno
    /// </summary>
    public string FirstName
    {
        get { return _zakaznik.Jmeno; }
    }

    /// <summary>
    /// Prijmeni
    /// </summary>
    public string LastName
    {
        get { return _zakaznik.Prijmeni; }
    }

    /// <summary>
    /// Ulice
    /// </summary>
    public string Street
    {
        get { return _adresa.Ulice; }
    }

    /// <summary>
    /// Cislo domu
    /// </summary>
    public int HouseNumber
    {
        get { return _adresa.CisloDomu; }
    }

    /// <summary>
    /// Cislo ulice
    /// </summary>
    public int RegistryNumber
    {
        get { return _adresa.CisloUlice; }
    }

    /// <summary>
    /// Mesto
    /// </summary>
    public string City
    {
        get { return _adresa.Mesto; }
    }

    /// <summary>
    /// Postovni smerovaci cislo
    /// </summary>
    public string ZipCode
    {
        get { return _adresa.SmerovaciCislo.ToString(); }
    }

    /// <summary>
    /// Zeme
    /// </summary>
    public string Country
    {
        get { return _adresa.Zeme; }
    }

    /// <summary>
    /// Pole produktu
    /// </summary>
    public string[] Products
    {
        get { return nazevProduktu.ToArray(); }
    }

    /// <summary>
    /// Pole kvantity produktu
    /// </summary>
    public int[] Quantities
    {
        get { return quantityOfProtucts.ToArray(); }
    }

    /// <summary>
    /// Pole cen produktu
    /// </summary>
    public double[] Prices
    {
        get { return prices.ToArray(); }
    }
}