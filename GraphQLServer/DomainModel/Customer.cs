namespace GraphQLServer.DomainModel;

public class Customer
{
    public int Id { get; set; }

    public string Name { get; set; }
    
    public string? EMailAddress { get; set; }
}