namespace Shop
{
    // Abstract class representing a general product category.
    // Genel bir ürün kategorisini temsil eden soyut sınıf.
    abstract class Productcategory
    {
        // Abstract property to provide the list of products in the category.
        // Kategorideki ürünlerin listesini sağlamak için soyut özellik.
        protected abstract List<Productinfo> Products { get; }

        // Method to display products in the category and handle user input for adding items to the cart.
        // Kategorideki ürünleri göstermek ve kullanıcının sepete ürün eklemesi için girişi işlemek için metot.
        public void Displayproducts()
        {
            // Displaying the category name and a message.
            // Kategori adını ve bir mesajı gösterme.
            Console.WriteLine($"{Getcategoryname()} <>Category The Product<>");

            // Displaying each product in the category.
            // Kategorideki her ürünü gösterme.
            for (int i = 0; i < Products.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {Products[i].Productname} - {Products[i].Productinfos} - {Products[i].Productprice} ");
            }

            // Prompting the user to enter the product number to add a product or go back to the main menu.
            // Kullanıcıya bir ürün eklemek için ürün numarasını girmesi veya ana menüye dönmesi için uyarı yapma.
            Console.WriteLine("<>Enter the product number to add a product<>\n|(0)--> Back to main menu<---|");

            // Reading the user input for the product number.
            // Kullanıcının ürün numarası için girişini okuma.
            int Productnumber;
            if (int.TryParse(Console.ReadLine(), out Productnumber) && Productnumber >= 0 && Productnumber <= Products.Count)
            {
                // Checking if the user wants to go back to the main menu.
                // Kullanıcının ana menüye dönmek isteyip istemediğini kontrol etme.
                if (Productnumber == 0)
                    return;

                // Selecting the product based on the user input.
                // Kullanıcının girişi üzerine ürünü seçme.
                Productinfo selectproduct = Products[Productnumber - 1];

                // Asking the user if they want to add the selected product to the cart.
                // Kullanıcıya seçilen ürünü sepete eklemek isteyip istemediğini sorma.
                Console.WriteLine($"<><>{selectproduct.Productname}<><>The product has been selected, do you want to add it to the cart? <|E/H|> <><>");

                // Reading the user input for adding the product to the cart.
                // Kullanıcının ürünü sepete eklemek için girişini okuma.
                if (Console.ReadLine().ToUpper() == "E")
                {
                    // Creating an instance of Electronicshop to access the shopping cart.
                    // Alışveriş sepetine erişmek için Electronicshop sınıfından bir örnek oluşturma.
                    Electronicshop electronicshop = new Electronicshop();

                    // Adding the selected product to the shopping cart.
                    // Seçilen ürünü alışveriş sepetine eklemek.
                    Electronicshop.Shoppingcart.Add(selectproduct);

                    // Displaying a message that the product has been added to the cart.
                    // Ürünün sepete eklendiğini bildiren bir mesajı gösterme.
                    Console.WriteLine($"<<>>{selectproduct.Productname} Added To Shop Bag<<>>");
                }
                else
                {
                    // Displaying a message for an invalid input.
                    // Geçersiz bir giriş için bir mesajı gösterme.
                    Console.WriteLine("><><Not valid value. Please enter the valid value><><");
                }
            }
        }

        // Abstract method to provide the category name.
        // Kategori adını sağlamak için soyut metot.
        protected abstract string Getcategoryname();
    }
}
