namespace Shop
{
    // Concrete class representing the Game Console category.
    // Oyun Konsolu kategorisini temsil eden somut sınıf.
    class Gameconsolecategory : Productcategory
    {
        // Implementing the abstract property to provide the list of game console products.
        // Soyut özelliği uygulayarak oyun konsolu ürünlerinin listesini sağlama.
        protected override List<Productinfo> Products => new List<Productinfo>
        {
            new Productinfo("SONY","PS4 500GB",5500m),
            new Productinfo("XBOX","500 GB",5000m),
            new Productinfo("SONY","SLIM 1 TB",7500m),
            new Productinfo("XBOX","ONE 1 TB",7000m)
        };

        // Implementing the abstract method to provide the category name.
        // Soyut metodu uygulayarak kategori adını sağlama.
        protected override string GetcategoryByName() => "GAME CONSOLE";
    }
}
