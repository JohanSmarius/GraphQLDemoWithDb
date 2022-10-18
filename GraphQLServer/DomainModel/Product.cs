namespace GraphQLServer.DomainModel;

public class Product
{
    public int Id { get; set; }

    public string Name { get; set; }

    public string EANCode { get; set; }

    public decimal Price { get; set; }

    public decimal Weight { get; set; }
}