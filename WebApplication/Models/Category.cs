using System.ComponentModel.DataAnnotations;

namespace EvaraWebbApp.Models
{
    public class Category
    {
        public int Id { get; set; }
        [Required, MaxLength(20)]
        public string Name { get; set; } = null!;
        public ICollection<Product>? Products { get; set; }

    }
}
