namespace isoftApp.Models
{
    public class InvoiceData
    {
        public long? Id { get; set; }
        public string? Email { get; set; }
        public DateTime Created_At { get; set; }
        public int? Number { get; set; }
        public string? Currency { get; set; }
        public string? Financial_Status { get; set; }
        public string? Total_Price { get; set; }
        public string? Total_Discounts { get; set; }
        public string? Total_Tax { get; set; }
        public string? Total_Line_Items_Price { get; set; }
        public List<LineItem>? Line_Items { get; set; }
        public BillingAddress? Billing_Address { get; set; }
        public ShippingAddress? Shipping_Address { get; set; }
        public Customer? Customer { get; set; }
    }
}
