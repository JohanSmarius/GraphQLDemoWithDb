using GraphQLServer.DomainModel;

namespace GraphQLServer.GraphQL;

public class CustomerPayload
{
    public Customer Customer { get; set; }

    public string? Error { get; set; }
}