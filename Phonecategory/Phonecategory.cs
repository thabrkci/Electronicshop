namespace Shop
{
    // Concrete class representing the Phone category.
    // Telefon kategorisini temsil eden somut sınıf.
    class Phonecategory : Productcategory
    {
        // Implementing the abstract property to provide the list of phone products.
        // Soyut özelliği uygulayarak telefon ürünlerinin listesini sağlama.
        protected override List<Productinfo> Products => new List<Productinfo>
        {
            new Productinfo("REDMI","11SE 128 GB",4500m),
            new Productinfo("SAMSUNG","S-23 256",5000m),
            new Productinfo("APPLE","13 PRO MAX 256GB",7500m),
            new Productinfo("TECHNO","TECHNOSTAR 128GB",4500m)
        };

        // Implementing the abstract method to provide the category name.
        // Soyut metodu uygulayarak kategori adını sağlama.
        protected override string GetcategoryByname() => "PHONE";
    }
}

