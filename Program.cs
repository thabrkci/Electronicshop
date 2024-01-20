namespace Shop
{
    class Electronicshop
    {
        // Public static property to hold the shopping cart items.
        // Alışveriş sepetindeki ürünleri tutan genel ve statik bir özellik.
        public static List<Productinfo> Shoppingcart = new List<Productinfo>();

        // The main entry point of the application.
        // Uygulamanın ana giriş noktası.
        public static void Main(string[] args)
        {
            while (true)
            {
                // Displaying the main menu to the user.
                // Kullanıcıya ana menüyü gösterme.
                Console.WriteLine("<><>>>>Welcome To Electronic Shop<<<<><>");
                Console.WriteLine("----------------------------------------");
                Console.WriteLine("********************\n[<>Select One From The Menu<>]\n[1]<>TV\n[2]<>Game Console\n[3]<>Phone\n[4]<>Games\n[5]<>Shop Bag\n[6]<>Exit\n********************");
                string? Choosemenu = Console.ReadLine();

                // Checking if the user input is a numeric value.
                // Kullanıcının girdisi sayısal bir değer mi diye kontrol etme.
                if (Isnumeric(Choosemenu))
                {
                    switch (Choosemenu)
                    {
                        case "1":
                            // Displaying products in the TV category.
                            // TV kategorisindeki ürünleri gösterme.
                            new TVCategory().Displayproducts();
                            break;
                        case "2":
                            // Displaying products in the Game Console category.
                            // Oyun Konsolu kategorisindeki ürünleri gösterme.
                            new Gameconsolecategory().Displayproducts();
                            break;
                        case "3":
                            // Displaying products in the Phone category.
                            // Telefon kategorisindeki ürünleri gösterme.
                            new Phonecategory().Displayproducts();
                            break;
                        case "4":
                            // Displaying products in the Game category.
                            // Oyun kategorisindeki ürünleri gösterme.
                            new Gamecategory().Displayproducts();
                            break;
                        case "5":
                            // Displaying the shopping cart.
                            // Alışveriş sepetini gösterme.
                            Displayshoppingcart();
                            break;
                        case "6":
                            // Exiting the application.
                            // Uygulamadan çıkma.
                            Console.WriteLine("<>--See You Later Technology Lover--<>");
                            return;
                        default:
                            // Handling invalid user input.
                            // Geçersiz kullanıcı girişini işleme alma.
                            Console.WriteLine("--->Invalid choose.Please Try Again");
                            break;
                    }

                }
                else
                {
                    // Prompting the user to enter a valid value.
                    // Kullanıcıya geçerli bir değer girmesi konusunda uyarı yapma.
                    Console.WriteLine("<><>Please enter the valid value<><>");
                }
            }
        }

        // Displaying the items in the shopping cart along with the total value.
        // Alışveriş sepetindeki ürünleri ve toplam değeri gösterme.
        static void Displayshoppingcart()
        {
            Console.WriteLine("<---->Welcome to Shop Bag<---->");

            // Checking if the shopping cart is empty.
            // Alışveriş sepetinin boş olup olmadığını kontrol etme.
            if (Shoppingcart.Count == 0)
            {
                Console.WriteLine($"The Shop Bag Is Null");
            }
            else
            {
                // Displaying each item in the shopping cart.
                // Alışveriş sepetindeki her ürünü gösterme.
                for (int i = 0; i < Shoppingcart.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {Shoppingcart[i].Productname} - {Shoppingcart[i].Productinfos} Price<> {Shoppingcart[i].Productprice} TL");
                }

                // Displaying the total value of items in the shopping cart.
                // Alışveriş sepetindeki ürünlerin toplam değerini gösterme.
                Console.WriteLine($"Total Value: {Calculatetotal()} TL");
            }
        }

        // Method for aggregating prices of products in the shopping cart.
        // Alışveriş sepetindeki ürünlerin fiyatlarını toplama metodunu tanımlama.
        static decimal Calculatetotal()
        {
            return Shoppingcart.Sum(product => product.Productprice);
        }

        // Method to check if the value received from the user is a number.
        // Kullanıcıdan alınan değerin sayı olup olmadığını kontrol etme metodunu tanımlama.
        static bool Isnumeric(string value)
        {
            return double.TryParse(value, out _);
        }
    }
}
