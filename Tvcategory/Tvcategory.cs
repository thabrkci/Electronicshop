namespace Shop
{
    // Concrete class representing the TV category.
    // TV kategorisini temsil eden somut sınıf.
    class TVCategory : Productcategory
    {
        // Implementing the abstract property to provide the list of TV products.
        // Soyut özelliği uygulayarak TV ürünlerinin listesini sağlama.
        protected override List<Productinfo> Products => new List<Productinfo>
        {
            new Productinfo("SAMSUNG","4K ULTRA HD",2000m),
            new Productinfo("PHILIPS","5K ULTRA HD",1500m),
            new Productinfo("LG","ULTRA SMART HD",3500m),
            new Productinfo("ONVO","4K HD",1300m)
        };

        // Implementing the abstract method to provide the category name.
        // Soyut metodu uygulayarak kategori adını sağlama.
        protected override string GetcategoryByname() => "TV";
    }
}