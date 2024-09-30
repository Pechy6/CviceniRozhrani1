namespace JednoduchyPriklad;

public class Customer
{
    private int Id { get; set; }
    private string FirstName { get; set; }
    private string LastName { get; set; }

    public Customer(int id, string firstName, string lastName)
    {
        Id = id;
        FirstName = firstName;
        LastName = lastName;
    }

    public override string ToString()
    {
        return string.Format("{0} {1} {2}", Id, FirstName, LastName);
    }
}