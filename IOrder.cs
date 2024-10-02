namespace JednoduchyPriklad;

public interface IOrder
{
    int Number { get; }

    /// <summary>
    /// Gets the customer's first name associated with the order.
    /// </summary>
    string FirstName { get; }

    /// <summary>
    /// Gets the customer's last name associated with the order.
    /// </summary>
    string LastName { get; }

    /// <summary>
    /// Gets the street name associated with the order.
    /// </summary>
    string Street { get; }

    /// <summary>
    /// Gets the house number associated with the order.
    /// </summary>
    int HouseNumber { get; }

    /// <summary>
    /// Gets the registry number associated with the order.
    /// </summary>
    int RegistryNumber { get; }

    /// <summary>
    /// Gets the name of the city associated with the order.
    /// </summary>
    string City { get; }

    /// <summary>
    /// Gets the zip code associated with the order's delivery address.
    /// </summary>
    int Zip { get; }

    /// <summary>
    /// Gets the name of the country associated with the order.
    /// </summary>
    string Country { get; }

    /// <summary>
    /// Gets the list of product names included in the order.
    /// </summary>
    string[] Products { get; }

    /// <summary>
    /// Gets the quantities of each product in the order.
    /// </summary>
    int[] Quantities { get; }

    /// <summary>
    /// Gets the prices of the products associated with the order.
    /// </summary>
    double[] Prices { get; }
}