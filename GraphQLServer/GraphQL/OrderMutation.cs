using GraphQLServer.Database;
using GraphQLServer.DomainModel;
using GraphQLServer.GraphQL;
using Microsoft.EntityFrameworkCore;

namespace GraphQLServer.GraphQL;

public class OrderMutation
{
    private readonly OrderContext? _orderContext;

    public OrderMutation(IDbContextFactory<OrderContext> orderContextFactory)
    {
        _orderContext = orderContextFactory.CreateDbContext();
    }

    public async Task<CustomerPayload> AddCustomer(CustomerInput customerInput)
    {
        var customer = new Customer() {Name = customerInput.Name};

        await _orderContext.Customers.AddAsync(customer);
        await _orderContext.SaveChangesAsync();

        var payload = new CustomerPayload() {Error = "", Customer = customer};

        return payload;
    }
}