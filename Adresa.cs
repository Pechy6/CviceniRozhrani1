namespace JednoduchyPriklad;

public class Adresa
{
    /// <summary>
    /// Zeme
    /// </summary>
    private string zeme;

    /// <summary>
    /// Ulice
    /// </summary>
    public string Ulice { get; }

    /// <summary>
    /// Cislo domu
    /// </summary>
    public int CisloDomu { get; }

    /// <summary>
    /// Cislo ulice
    /// </summary>
    public int CisloUlice { get; }

    /// <summary>
    /// Mesto
    /// </summary>
    public string Mesto { get; }

    /// <summary>
    /// Postovni smerovaci cislo
    /// </summary>
    public int SmerovaciCislo { get; }

    /// <summary>
    /// Vlastnost zeme
    /// </summary>
    public string Zeme
    {
        get { return zeme; }
        private set { zeme = value; }
    }

    /// <summary>
    /// Instance Adresa
    /// </summary>
    /// <param name="ulice">Ulice</param>
    /// <param name="cisloDomu">Cislo domu</param>
    /// <param name="cisloUlice">Cislo ulice</param>
    /// <param name="mesto">Mesto</param>
    /// <param name="smerovaciCislo">Postovni smerovaci cislo</param>
    public Adresa(string ulice, int cisloDomu, int cisloUlice, string mesto, int smerovaciCislo)
    {
        Ulice = ulice;
        CisloDomu = cisloDomu;
        CisloUlice = cisloUlice;
        Mesto = mesto;
        SmerovaciCislo = smerovaciCislo;
        Zeme = "Česká republika";
    }

    public override string ToString()
    {
        return Ulice + " " + CisloDomu + " " + CisloUlice + " " + Mesto + " " + SmerovaciCislo;
    }
}