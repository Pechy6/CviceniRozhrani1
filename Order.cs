namespace JednoduchyPriklad;

public abstract class Order: IOrder
{
    public int Number { get; }
    public string FirstName { get; }
    public string LastName { get; }
    public string Street { get; }
    public int HouseNumber { get; }
    public int RegistryNumber { get; }
    public string City { get; }
    public string ZipCode { get; }
    public string Country { get; }
    public string[] Products { get; }
    public int[] Quantities { get; }
    public double[] Prices { get; }
    
    Product Product { get; }
    Customer Customer { get; }

    public Order()
    {
        
    }
}