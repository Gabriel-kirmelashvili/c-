using System;

namespace _8
{
    internal class Product
    {
        public int Id;
        public string Name;
        public double Price;
        public bool Nuts;
        public string Image;
        public bool Vegeterian;
        public int Spiciness;
        public string Category;

        public void ShowInfo()
        {
            Console.WriteLine(Id);
            Console.WriteLine(Name);
            Console.WriteLine(Price);
            Console.WriteLine(Nuts);
            Console.WriteLine(Image);
            Console.WriteLine(Vegeterian);
            Console.WriteLine(Spiciness);
            Console.WriteLine(Category);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Product p = new Product();

            p.Id = 1;
            p.Name = "Pizza";
            p.Price = 20;
            p.Nuts = false;
            p.Image = "pizza.jpg";
            p.Vegeterian = true;
            p.Spiciness = 3;
            p.Category = "Food";

            p.ShowInfo();
        }
    }
}