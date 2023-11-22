using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApp.Models
{
    public class Collection
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
        public string Path { get; set; }

        //Nav Prop
        public List<Product>? Products { get; set; }
        public Collection()
        {
                
        }
    }
}
