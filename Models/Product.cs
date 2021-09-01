namespace ASPExample.Models
{
    public class Product
    {
        public int Id { get; set; }

        public string Description { get; set; }

        public int IdCategory { get; set; }

        public Category Category { get; set; }
    }
}