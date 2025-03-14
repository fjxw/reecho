using Domain.Enums;

namespace Domain.Entities;

public class Vynil
{
    public Guid Id { get; set; } 
    public string Title { get; set; } = string.Empty;
    public Genre Genre { get; set; } = Genre.None;
    public decimal Price { get; set; } = 0;
    public int Quantity { get; set; } = 0;
}