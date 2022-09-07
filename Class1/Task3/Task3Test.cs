using NUnit.Framework;
using static NUnit.Framework.Assert;
using static Task3.Task3;

namespace Task3;

public class Tests
{
    [Test]
    public void FTest()
    {
        That(F(0.0), Is.EqualTo(1.0).Within(1e-5));
        That(F(-2.7), Is.EqualTo(0.0).Within(1e-5));
        That(F(-0.5), Is.EqualTo(0.0).Within(1e-5));
        That(F(0.5), Is.EqualTo(1.0).Within(1e-5));
        That(F(4.6), Is.EqualTo(1.0).Within(1e-5));
        That(F(7.9), Is.EqualTo(-1.0).Within(1e-5));
        That(F(11.0), Is.EqualTo(-1.0).Within(1e-5));
    }

    [Test]
    public void NumberOfDaysTest()
    {
        That(NumberOfDays(2021), Is.EqualTo(365));
        That(NumberOfDays(2022), Is.EqualTo(365));
        That(NumberOfDays(2028), Is.EqualTo(366));
        That(NumberOfDays(2100), Is.EqualTo(365));
        That(NumberOfDays(2400), Is.EqualTo(366));
    }

    [Test]
    public void Rotate2Test()
    {
        That(Rotate2('С', 1, -1), Is.EqualTo('С'));
        That(Rotate2('З', -1, -1), Is.EqualTo('В'));
        That(Rotate2('Ю', 2, 1), Is.EqualTo('З'));
        That(Rotate2('В', -1, 2), Is.EqualTo('С'));
    }

    [Test]
    public void AgeDescriptionTest()
    {
        That(AgeDescription(42), Is.EqualTo("сорок два года"));
        That(AgeDescription(23), Is.EqualTo("двадцать три года"));
        That(AgeDescription(31), Is.EqualTo("тридцать один год"));
        That(AgeDescription(54), Is.EqualTo("пятьдесят четыре года"));
        That(AgeDescription(65), Is.EqualTo("шестьдесят пять лет"));
        That(AgeDescription(26), Is.EqualTo("двадцать шесть лет"));
        That(AgeDescription(37), Is.EqualTo("тридцать семь лет"));
        That(AgeDescription(58), Is.EqualTo("пятьдесят восемь лет"));
        That(AgeDescription(49), Is.EqualTo("сорок девять лет"));
    }

    [Test]
    public void MainTest()
    {
        Main(Array.Empty<string>());
    }
}