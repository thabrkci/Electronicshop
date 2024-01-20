namespace Shop
{
    // Concrete class representing the Games category.
    // Oyunlar kategorisini temsil eden somut sınıf.
    class Gamecategory : Productcategory
    {
        // Implementing the abstract property to provide the list of game products.
        // Soyut özelliği uygulayarak oyun ürünlerinin listesini sağlama.
        protected override List<Productinfo> Products => new List<Productinfo>
        {
            new Productinfo("RDR2","FOR PS4",500m),
            new Productinfo("THE WITCHER 3","FOR PS4-PS4 SLIM",700m),
            new Productinfo("GTA 5","ALL GAME CONSOLE",1000m),
            new Productinfo("AGE OF EMPIRES","ALL IN THE XBOX",500m)
        };

        // Implementing the abstract method to provide the category name.
        // Soyut metodu uygulayarak kategori adını sağlama.
        protected override string Getcategoryname() => "GAMES";
    }
}