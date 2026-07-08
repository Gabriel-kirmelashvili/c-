using System;
using _10;
using lec10.classes;

namespace _10.Tests;

public class EmployTests
{
    private static Employ MakeEmploy(string name, string surename, DateTime birth, Country country)
        => new Employ(name, surename, birth, country, Gender.male, Contacts.vigac);

    [Fact]
    public void Getage_ReturnsAge_WhenBirthdayAlreadyPassedThisYear()
    {
        // Birthday was one month ago (20 years back) -> full 20 years old.
        var birth = DateTime.Today.AddYears(-20).AddMonths(-1);
        var employ = MakeEmploy("a", "b", birth, Country.georgia);

        Assert.Equal(20, employ.getage());
    }

    [Fact]
    public void Getage_SubtractsOne_WhenBirthdayHasNotOccurredYetThisYear()
    {
        // Birthday is one month in the future (20 years back) -> still 19.
        var birth = DateTime.Today.AddYears(-20).AddMonths(1);
        var employ = MakeEmploy("a", "b", birth, Country.georgia);

        Assert.Equal(19, employ.getage());
    }

    [Fact]
    public void Getage_ReturnsZero_ForNewbornBornToday()
    {
        var employ = MakeEmploy("a", "b", DateTime.Today, Country.georgia);

        Assert.Equal(0, employ.getage());
    }

    [Fact]
    public void Getage_HandlesLeapDayBirthdate()
    {
        var employ = MakeEmploy("a", "b", new DateTime(2000, 2, 29), Country.georgia);

        int expected = DateTime.Now.Year - 2000;
        if (new DateTime(2000, 2, 29).Date > DateTime.Now.AddYears(-expected))
            expected--;

        Assert.Equal(expected, employ.getage());
    }

    [Fact]
    public void Printemploycont_PrintsOnlyEmployeesOfGivenCountry()
    {
        var employs = new[]
        {
            MakeEmploy("andria", "archvadze", new DateTime(1990, 1, 1), Country.georgia),
            MakeEmploy("jhon", "doe", new DateTime(1990, 1, 1), Country.usa),
            MakeEmploy("lika", "tartarasvili", new DateTime(1990, 1, 1), Country.georgia),
        };

        var output = CaptureConsole(() => Employ.Printemploycont(employs, Country.georgia));

        Assert.Contains("qveynis mixedvit " + Country.georgia, output);
        Assert.Contains("andria archvadze", output);
        Assert.Contains("lika tartarasvili", output);
        Assert.DoesNotContain("jhon doe", output);
    }

    [Fact]
    public void Printemploycont_PrintsNoEmployees_WhenNoneMatch()
    {
        var employs = new[]
        {
            MakeEmploy("andria", "archvadze", new DateTime(1990, 1, 1), Country.georgia),
        };

        var output = CaptureConsole(() => Employ.Printemploycont(employs, Country.japan));

        Assert.DoesNotContain("andria archvadze", output);
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
