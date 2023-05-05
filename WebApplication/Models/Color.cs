namespace EvaraWebbApp.Models
{
    public class Color
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public ICollection<ColorProduct> ColorProducts { get; set; }
    }
            

       
}
