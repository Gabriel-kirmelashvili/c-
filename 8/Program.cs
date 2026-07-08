using System;
using Shared;

namespace _8

{
    internal class Program
    {
        static void Main(string[] args)
        {
            Restaurant product = new Restaurant();

            product.Id = ConsoleInput.ReadInt("id");
            product.Name = ConsoleInput.ReadString("name");
            product.Price = ConsoleInput.ReadInt("price");
            product.Image = ConsoleInput.ReadString("image");
            product.Nuts = ConsoleInput.ReadBool("nuts");
            product.Vegetarian = ConsoleInput.ReadBool("vegetarian");
            product.Spiciness = ConsoleInput.ReadInt("spicines");
            product.Category = ConsoleInput.ReadString("category");


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