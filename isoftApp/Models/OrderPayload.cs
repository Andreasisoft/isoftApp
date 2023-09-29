namespace isoftApp.Models
{
    public class OrderPayload
    {
        public long? Id { get; set; }
        public string? Email { get; set; }
        public DateTime? Closed_At { get; set; }
        public DateTime Created_At { get; set; }
        public DateTime Updated_At { get; set; }
        public int? Number { get; set; }
        public string? Note { get; set; }
        public string? Token { get; set; }
        public string? Gateway { get; set; }
        public bool? Test { get; set; }
        public string? Total_Price { get; set; }
        public string? Subtotal_Price { get; set; }
        public int? Total_Weight { get; set; }
        public string? Total_Tax { get; set; }
        public bool? Taxes_Included { get; set; }
        public string? Currency { get; set; }
        public string? Financial_Status { get; set; }
        public bool? Confirmed { get; set; }
        public string? Total_Discounts { get; set; }
        public string? Total_Line_Items_Price { get; set; }
        public string? Cart_Token { get; set; }
        public bool? Buyer_Accepts_Marketing { get; set; }
        public string? Name { get; set; }
        public string? Referring_Site { get; set; }
        public string? Landing_Site { get; set; }
        public DateTime? Cancelled_At { get; set; }
        public string? Cancel_Reason { get; set; }
        public string? Total_Price_Usd { get; set; }
        public string? Checkout_Token { get; set; }
        public object? Reference { get; set; }
        public object? User_Id { get; set; }
        public object? Location_Id { get; set; }
        public object? Source_Identifier { get; set; }
        public object? Source_Url { get; set; }
        public DateTime? Processed_At { get; set; }
        public object? Device_Id { get; set; }
        public string? Phone { get; set; }
        public string? Customer_Locale { get; set; }
        public int? App_Id { get; set; }
        public string? Browser_Ip { get; set; }
        public object? Landing_Site_Ref { get; set; }
        public int? Order_Number { get; set; }
        public List<object>? Discount_Codes { get; set; }
        public List<object>? Note_Attributes { get; set; }
        public List<string>? Payment_Gateway_Names { get; set; }
        public string? Processing_Method { get; set; }
        public long? Checkout_Id { get; set; }
        public string? Source_Name { get; set; }
        public object? Fulfillment_Status { get; set; }
        public List<object>? Tax_Lines { get; set; }
        public string? Tags { get; set; }
        public string? Contact_Email { get; set; }
        public string? Order_Status_Url { get; set; }
        public string? Presentment_Currency { get; set; }
        public TotalLineItemsPriceSet? Total_Line_Items_Price_Set { get; set; }
        public TotalDiscountsSet? Total_Discounts_Set { get; set; }
        public TotalShippingPriceSet? Total_Shipping_Price_Set { get; set; }
        public SubtotalPriceSet? Subtotal_Price_Set { get; set; }
        public TotalPriceSet? Total_Price_Set { get; set; }
        public TotalTaxSet? Total_Tax_Set { get; set; }
        public List<LineItem>? Line_Items { get; set; }
        public List<object>? Shipping_Lines { get; set; }
        public BillingAddress? Billing_Address { get; set; }
        public ShippingAddress? Shipping_Address { get; set; }
        public List<object>? Fulfillments { get; set; }
        public List<object>? Refunds { get; set; }
        public Customer? Customer { get; set; }
    }

    public class TotalLineItemsPriceSet
    {
        public ShopMoney? Shop_Money { get; set; }
        public PresentmentMoney? Presentment_Money { get; set; }
    }

    public class TotalDiscountsSet
    {
        public ShopMoney? Shop_Money { get; set; }
        public PresentmentMoney? Presentment_Money { get; set; }
    }

    public class TotalShippingPriceSet
    {
        public ShopMoney? Shop_Money { get; set; }
        public PresentmentMoney? Presentment_Money { get; set; }
    }

    public class SubtotalPriceSet
    {
        public ShopMoney? Shop_Money { get; set; }
        public PresentmentMoney? Presentment_Money { get; set; }
    }

    public class TotalPriceSet
    {
        public ShopMoney? Shop_Money { get; set; }
        public PresentmentMoney? Presentment_Money { get; set; }
    }

    public class TotalTaxSet
    {
        public ShopMoney? Shop_Money { get; set; }
        public PresentmentMoney? Presentment_Money { get; set; }
    }

    public class ShopMoney
    {
        public string? Amount { get; set; }
        public string? Currency_Code { get; set; }
    }

    public class PresentmentMoney
    {
        public string? Amount { get; set; }
        public string? Currency_Code { get; set; }
    }

    public class LineItem
    {
        public long? Id { get; set; }
        public long? Variant_Id { get; set; }
        public string? Title { get; set; }
        public int? Quantity { get; set; }
        public string? Price { get; set; }
        public string? Sku { get; set; }
        public object? Variant_Title { get; set; }
        public string? Vendor { get; set; }
        public string? Fulfillment_Service { get; set; }
        public long? Product_Id { get; set; }
        public bool? Requires_Shipping { get; set; }
        public bool? Taxable { get; set; }
        public bool? Gift_Card { get; set; }
        public string? Name { get; set; }
        public string? Variant_Inventory_Management { get; set; }
        public List<object>? Properties { get; set; }
        public bool? Product_Exists { get; set; }
        public int? Fulfillable_Quantity { get; set; }
        public int? Grams { get; set; }
        public string? Total_Discount { get; set; }
        public object? Fulfillment_Status { get; set; }
        public PriceSet? Price_Set { get; set; }
        public TotalDiscountSet? Total_Discount_Set { get; set; }
        public List<object>? Discount_Allocations { get; set; }
        public List<object>? Duties { get; set; }
        public string? Admin_Graphql_Api_Id { get; set; }
        public List<object>? Tax_Lines { get; set; }
    }

    public class PriceSet
    {
        public ShopMoney? Shop_Money { get; set; }
        public PresentmentMoney? Presentment_Money { get; set; }
    }

    public class TotalDiscountSet
    {
        public ShopMoney? Shop_Money { get; set; }
        public PresentmentMoney? Presentment_Money { get; set; }
    }

    public class BillingAddress
    {
        public string? First_Name { get; set; }
        public string? Address1 { get; set; }
        public string? Phone { get; set; }
        public string? City { get; set; }
        public string? Zip { get; set; }
        public string? Province { get; set; }
        public string? Country { get; set; }
        public string? Last_Name { get; set; }
        public object? Address2 { get; set; }
        public object? Company { get; set; }
        public object? Latitude { get; set; }
        public object? Longitude { get; set; }
        public string? Name { get; set; }
        public string? Country_Code { get; set; }
        public string? Province_Code { get; set; }
    }

    public class ShippingAddress
    {
        public string? First_Name { get; set; }
        public string? Address1 { get; set; }
        public string? Phone { get; set; }
        public string? City { get; set; }
        public string? Zip { get; set; }
        public string? Province { get; set; }
        public string? Country { get; set; }
        public string? Last_Name { get; set; }
        public object? Address2 { get; set; }
        public object? Company { get; set; }
        public object? Latitude { get; set; }
        public object? Longitude { get; set; }
        public string? Name { get; set; }
        public string? Country_Code { get; set; }
        public string? Province_Code { get; set; }
    }

    public class Customer
    {
        public long? Id { get; set; }
        public string? Email { get; set; }
        public bool? Accepts_Marketing { get; set; }
        public DateTime? Created_At { get; set; }
        public DateTime? Updated_At { get; set; }
        public string? First_Name { get; set; }
        public string? Last_Name { get; set; }
        public int? Orders_Count { get; set; }
        public string? State { get; set; }
        public string? Total_Spent { get; set; }
        public object? Last_Order_Id { get; set; }
        public object? Note { get; set; }
        public bool? Verified_Email { get; set; }
        public object? Multipass_Identifier { get; set; }
        public bool? Tax_Exempt { get; set; }
        public object? Phone { get; set; }
        public string? Tags { get; set; }
        public object? Last_Order_Name { get; set; }
        public string? Currency { get; set; }
        public string? Accepts_Marketing_Updated_At { get; set; }
        public object? Marketing_Opt_In_Level { get; set; }
        public List<object>? Tax_Exemptions { get; set; }
        public string? Admin_Graphql_Api_Id { get; set; }
        public DefaultAddress? Default_Address { get; set; }
    }

    public class DefaultAddress
    {
        public long? Id { get; set; }
        public long? Customer_Id { get; set; }
        public string? First_Name { get; set; }
        public string? Last_Name { get; set; }
        public object? Company { get; set; }
        public string? Address1 { get; set; }
        public object? Address2 { get; set; }
        public string? City { get; set; }
        public string? Province { get; set; }
        public string? Country { get; set; }
        public string? Zip { get; set; }
        public string? Phone { get; set; }
        public string? Name { get; set; }
        public string? Province_Code { get; set; }
        public string? Country_Code { get; set; }
    }



}
