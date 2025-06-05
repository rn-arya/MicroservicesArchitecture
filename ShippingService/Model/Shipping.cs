namespace ShippingService.Model
{
    public class Shipping
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public string Address { get; set; }
    }
}
