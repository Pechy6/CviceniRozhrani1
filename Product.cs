namespace JednoduchyPriklad;

public class Product
{
    string ProductName { get; set; }

    public Product(string productName)
    {
        ProductName = productName;
    }

    public override string ToString()
    {
        return string.Format("ProductName: {0}", ProductName);
    }
}