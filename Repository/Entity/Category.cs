using TetPee.Repository.Abtraction;

namespace Repository.Entity;

public class Category: BaseEntity<Guid>, IAuditableEntity
{
    
    public required string Name { get; set; }
    
    public Guid? ParentId { get; set; } 
    public Category? Parent { get; set; }
    
    public ICollection<Category> Children { get; set; } = new List<Category>();
    public ICollection<ProductCategory> ProductCategories { get; set; } = new List<ProductCategory>();
    
    public DateTimeOffset CreatedAt { get; set; }
    public DateTimeOffset? UpdatedAt { get; set; }
}