namespace JednoduchyPriklad;

public class Adresa
{
    public string Ulice { get; }
    public int CisloDomu { get; }
    public int CisloUlice { get; }
    public string Mesto { get; }
    public int SmerovaciCislo { get; }

    public string Zeme
    {
        get
        {
            return Zeme;
        }
       private set
        {
            Zeme = "Česká republika";
        }
    }

    public Adresa(string ulice, int cisloDomu, int cisloUlice, string mesto, int smerovaciCislo)
    {
        Ulice = ulice;
        CisloDomu = cisloDomu;
        CisloUlice = cisloUlice;
        Mesto = mesto;
        SmerovaciCislo = smerovaciCislo;
    }

    public override string ToString()
    {
        return Ulice + " " + CisloDomu + " " + CisloUlice + " " + Mesto + " " + SmerovaciCislo;
    }
}