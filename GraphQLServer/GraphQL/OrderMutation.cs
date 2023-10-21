using GraphQLServer.Database;
using GraphQLServer.DomainModel;
using GraphQLServer.GraphQL;
using Microsoft.EntityFrameworkCore;

namespace GraphQLServer.GraphQL;

public class OrderMutation
{
    public async Task<CustomerPayload> AddCustomer(OrderContext orderContext, CustomerInput customerInput)
    {
        var customer = new Customer() {Name = customerInput.Name};

        await orderContext.Customers.AddAsync(customer);
        await orderContext.SaveChangesAsync();

        var payload = new CustomerPayload() {Error = "", Customer = customer};

        return payload;
    }
}