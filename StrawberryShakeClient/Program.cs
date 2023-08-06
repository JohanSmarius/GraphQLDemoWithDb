using Microsoft.Extensions.DependencyInjection;
using StrawberryShakeClient;
using StrawberryShake;

/*IServiceCollection serviceCollection = new ServiceCollection();
serviceCollection.AddOrderClient()
    .ConfigureHttpClient(client => client.BaseAddress = new Uri("https://localhost:7189/graphql/"));

var serviceProvider = serviceCollection.BuildServiceProvider();

var client = serviceProvider.GetRequiredService<IOrderClient>();

var result = await client.Orders.ExecuteAsync(CancellationToken.None);

if (!result.Errors.Any())
{
    foreach (var order in result!.Data!.Orders)
    {
        Console.WriteLine(order.Id);
        foreach (var orderLine in order.OrderLines)
        {
            Console.WriteLine(orderLine.Product.Name);
        }
    }
}
*/

// var customerInput = new CustomerInput() {Name = "New customer from generated client "};
// var resultAddCustomer = await client.AddCustomer.ExecuteAsync(customerInput, CancellationToken.None);
//
// if (!resultAddCustomer.Errors.Any())
// {
//     //Console.WriteLine(result!.Data!);
//     Console.WriteLine($"Added {resultAddCustomer!.Data!.AddCustomer!.Customer!.Id} {resultAddCustomer!.Data!.AddCustomer!.Customer!.Name}" );
// }
