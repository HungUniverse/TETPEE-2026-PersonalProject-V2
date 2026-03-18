using TetPee.Repository.Abtraction;

namespace Repository.Entity;

public class OrderDetail: BaseEntity<Guid>, IAuditableEntity
{
    public Guid OrderId { get; set; }
    public Order Order { get; set; }
    
    public Guid ProductId { get; set; }
    public Product Product { get; set; }
    public int Quantity { get; set; }
    public double Price { get; set; }
    
    public DateTimeOffset CreatedAt { get; set; }
    public DateTimeOffset? UpdatedAt { get; set; }
}