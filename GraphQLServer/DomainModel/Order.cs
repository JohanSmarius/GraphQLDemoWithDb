namespace GraphQLServer.DomainModel;

public class Order
{
    public int Id { get; set; }

    public ICollection<Orderline> OrderLines { get; set; } = new List<Orderline>(); 

    public Customer Customer { get; set; }
    public int CustomerId { get; set; }

    public DateTime OrderTime { get; set; }

    public OrderStatus OrderStatus { get; set; }
}