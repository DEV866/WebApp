using System.ComponentModel.DataAnnotations;

namespace WebApp.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
        public string Path { get; set; }

        //Nav Prop Left
        public int CollectionId { get; set; }
        public string CollectionName { get; set; }
        public Collection? Collection { get; set; }
        public List<Cart>? Cart { get; set; }
        public Product()
        {

        }
    }
}
