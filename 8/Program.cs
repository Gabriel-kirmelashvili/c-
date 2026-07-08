using System;

namespace _8

{
    internal class Program
    {
        static void Main(string[] args)
        {
            Restaurant product = new Restaurant();

            product.Id = ReadInt("id");
            product.Name = ReadText("name");
            product.Price = ReadInt("price");
            product.Image = ReadText("image");
            product.Nuts = ReadBool("nuts");
            product.Vegetarian = ReadBool("vegetarian");
            product.Spiciness = ReadInt("spicines");
            product.Category = ReadText("category");


            product.DisplayInfo();


            product.ApplyDiscount(15);
        }

        static string ReadText(string prompt)
        {
            while (true)
            {
                Console.WriteLine(prompt);
                string? input = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(input))
                    return input;

                Console.WriteLine($"'{prompt}' cannot be empty. Please try again.");
            }
        }

        static int ReadInt(string prompt)
        {
            while (true)
            {
                Console.WriteLine(prompt);
                string? input = Console.ReadLine();
                if (int.TryParse(input, out int value))
                    return value;

                Console.WriteLine($"'{input}' is not a valid whole number for '{prompt}'. Please try again.");
            }
        }

        static bool ReadBool(string prompt)
        {
            while (true)
            {
                Console.WriteLine(prompt);
                string? input = Console.ReadLine();
                if (bool.TryParse(input, out bool value))
                    return value;

                Console.WriteLine($"'{input}' is not a valid true/false value for '{prompt}'. Please try again.");
            }
        }

        public class Restaurant
        {
            public int Id { get; set; }
            public string Name { get; set; } = string.Empty;
            public int Price { get; set; }
            public bool Nuts { get; set; }
            public string Image { get; set; } = string.Empty;
            public bool Vegetarian { get; set; }
            public int Spiciness { get; set; }
            public string Category { get; set; } = string.Empty;

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