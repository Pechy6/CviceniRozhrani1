namespace JednoduchyPriklad;

public class Adress
{
    private string country = "Česká republika";
    private string Street { get; set; }
    private int ZipCode { get; set; }
    private int ZipCode2 { get; set; }
    private int HouseNumber { get; set; }
    private string City { get; set; }

    public Adress(string street, int zipCode, int zipCode2, string city, int houseNumber)
    {
        Street = street;
        ZipCode = zipCode;
        ZipCode2 = zipCode2;
        City = city;
        HouseNumber = houseNumber;
    }

    public override string ToString()
    {
        return string.Format("Adress: {0} {1}/{2}\n{3} {4}\n{5}", Street, ZipCode, ZipCode2, City, HouseNumber, country);
    }
}