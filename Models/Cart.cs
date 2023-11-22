namespace WebApp.Models
{
    public class Cart
    {
        public int Id { get; set; }
        public string ApplictaionUserId { get; set; }

        //Nav Prop Left
        public ApplicationUser User { get; set; }

        //Nav Prop Right
        public List<Product>? Products { get; set; }

        public Cart()
        {
                
        }
    }
}
