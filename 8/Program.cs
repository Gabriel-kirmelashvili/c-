using System;

namespace _8

{
    internal class Program
    {
        static void Main(string[] args)
        {
            Restaurant product = new Restaurant();

            Console.WriteLine("id");
            string idInput = Console.ReadLine();
            Console.WriteLine("name");
            string nameInput = Console.ReadLine();
            Console.WriteLine("price");
            string priceInput = Console.ReadLine();
            Console.WriteLine("image");
            string imageInput = Console.ReadLine();
            Console.WriteLine("nuts");
            string nutsInput = Console.ReadLine();
            Console.WriteLine("vegetarian");
            string vegetarianInput = Console.ReadLine();
            Console.WriteLine("spicines");
            string spicinessInput = Console.ReadLine();
            Console.WriteLine("category");
            string categoryInput = Console.ReadLine();

            int.TryParse(idInput, out int parsedId);
            int.TryParse(priceInput, out int parsedPrice);
            bool.TryParse(nutsInput, out bool parsedNuts);
            bool.TryParse(vegetarianInput, out bool parsedVegetarian);
            int.TryParse(spicinessInput, out int parsedSpiciness);

            product.Id = parsedId;
            product.Name = nameInput;
            product.Price = parsedPrice;
            product.Image = imageInput;
            product.Nuts = parsedNuts;
            product.Vegetarian = parsedVegetarian;
            product.Spiciness = parsedSpiciness;
            product.Category = categoryInput;


            product.DisplayInfo();


            product.ApplyDiscount(15);
        }

        public class Restaurant
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public int Price { get; set; }
            public bool Nuts { get; set; }
            public string Image { get; set; }
            public bool Vegetarian { get; set; }
            public int Spiciness { get; set; }
            public string Category { get; set; }

            public void DisplayInfo()
            {
                Console.WriteLine("--- Product Card ---");
                Console.WriteLine($"ID: {Id}");
                Console.WriteLine($"Name: {Name}");
                Console.WriteLine($"Price: {Price} GEL");
                Console.WriteLine($"Category: {Category}");
                Console.WriteLine($"Vegetarian: {(Vegetarian ? "Yes" : "No")}");
                Console.WriteLine($"Contains Nuts: {(Nuts ? "Yes" : "No")}");
                Console.WriteLine($"Spiciness Level: {Spiciness}/5");
                Console.WriteLine("--------------------");
            }


            public void ApplyDiscount(int percentage)
            {
                Price = Price - (Price * percentage / 100);
            }
        }
    }
}