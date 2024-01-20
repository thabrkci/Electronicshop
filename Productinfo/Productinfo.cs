namespace Shop
{
    // Class representing product information, including name, information, and price.
    // Ürün bilgilerini, adı, bilgisi ve fiyatı içeren sınıf.
    class Productinfo
    {
        // Public property to get or set the product name.
        // Ürün adını almak veya ayarlamak için genel özellik.
        public string? Productname { get; set; }

        // Public property to get or set additional information about the product.
        // Ürün hakkında ek bilgi almak veya ayarlamak için genel özellik.
        public string? Productinfos { get; set; }

        // Public property to get or set the product price.
        // Ürün fiyatını almak veya ayarlamak için genel özellik.
        public decimal Productprice { get; set; }

        // Constructor method to initialize product information.
        // Ürün bilgilerini başlatmak için kurucu metot.
        public Productinfo(string productname, string productinfos, decimal productprice)
        {
            Productname = productname;
            Productinfos = productinfos;
            Productprice = productprice;
        }
    }
}
