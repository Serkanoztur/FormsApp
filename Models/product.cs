namespace FormsApp.Models
{
  public class Product
    {
     public int ProductId { get; set; }

        public string Name { get; set; } = string.Empty;

        public decimal Price { get; set; }

        public string image { get; set; } = string.Empty;

        public int CategoryId { get; set; } 

        public bool IsActive { get; set; }
        
    }









}
