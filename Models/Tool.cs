using System.ComponentModel.DataAnnotations;

namespace hardware_store.Models
{
  public class Tool
  {
    [Required]
    public string Name { get; set; }

    [Required]
    [Range(1, 1000000)]
    public int Id { get; set; }

    [Required]
    public decimal Price { get; set; }
    public Tool(string name, int id, decimal price)
    {
      Name = name;
      Id = id;
      Price = price;
    }
  }

}