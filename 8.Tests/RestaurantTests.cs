using System;
using System.IO;
using Restaurant = _8.Program.Restaurant;

namespace _8.Tests;

public class RestaurantTests
{
    [Theory]
    [InlineData(100, 15, 85)]
    [InlineData(200, 50, 100)]
    [InlineData(100, 0, 100)]
    [InlineData(100, 100, 0)]
    [InlineData(10, 15, 9)] // integer division: 10*15/100 == 1
    public void ApplyDiscount_ReducesPriceByPercentage(int price, int percentage, int expected)
    {
        var product = new Restaurant { Price = price };

        product.ApplyDiscount(percentage);

        Assert.Equal(expected, product.Price);
    }

    [Fact]
    public void DisplayInfo_IncludesAllProductFields()
    {
        var product = new Restaurant
        {
            Id = 7,
            Name = "Khachapuri",
            Price = 25,
            Category = "Main",
            Vegetarian = true,
            Nuts = false,
            Spiciness = 3,
        };

        var output = CaptureConsole(product.DisplayInfo);

        Assert.Contains("ID: 7", output);
        Assert.Contains("Name: Khachapuri", output);
        Assert.Contains("Price: 25 GEL", output);
        Assert.Contains("Category: Main", output);
        Assert.Contains("Vegetarian: Yes", output);
        Assert.Contains("Contains Nuts: No", output);
        Assert.Contains("Spiciness Level: 3/5", output);
    }

    [Fact]
    public void DisplayInfo_FormatsBooleanFieldsAsNo_WhenFalse()
    {
        var product = new Restaurant { Name = "Salad", Vegetarian = false, Nuts = true };

        var output = CaptureConsole(product.DisplayInfo);

        Assert.Contains("Vegetarian: No", output);
        Assert.Contains("Contains Nuts: Yes", output);
    }

    private static string CaptureConsole(Action action)
    {
        var original = Console.Out;
        using var writer = new StringWriter();
        Console.SetOut(writer);
        try
        {
            action();
        }
        finally
        {
            Console.SetOut(original);
        }
        return writer.ToString();
    }
}
