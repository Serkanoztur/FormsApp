namespace FormsApp.Models
{
    public class Repository
    {
        private static readonly List<Product> _products = new();
        private static readonly List<Category> _categories = new();

        static Repository()
       {
        
       }
 
         public static List<Product> products
        {
            get
            {
                return _products;
            }

        }  public static List<Category> catogories
        {
            get
            {
                return _categories;
            }
        
        }
       
    }
}
