using NUnit.Framework;
using static NUnit.Framework.Assert;
using static Task2.Task2;

namespace Task2;

public class Tests
{
    [Test]
    public void Min3Test1()
    {
        That(Min3(2, 0, 3), Is.EqualTo(0));
    }

    [Test]
    public void Min3Test2()
    {
        That(Min3(19, 32, 19), Is.EqualTo(19));
    }

    [Test]
    public void Min3Test3()
    {
        That(Min3(-5, 7, -9), Is.EqualTo(-9));
    }

    [Test]
    public void Max3Test1()
    {
        That(Max3(5, 7, 6), Is.EqualTo(7));
    }

    [Test]
    public void Max3Test2()
    {
        That(Max3(0, -5, 5), Is.EqualTo(5));
    }

    [Test]
    public void Max3Test3()
    {
        That(Max3(-2, -2, -2), Is.EqualTo(-2));
    }

    [Test]
    public void Deg2RadTest1()
    {
        That(Deg2Rad(180.0), Is.EqualTo(Math.PI).Within(1e-5));
        That(Deg2Rad(2 * 360 + 180.0), Is.EqualTo(5 * Math.PI).Within(1e-5));
    }

    [Test]
    public void Rad2DegTest1()
    {
        That(Rad2Deg(Math.PI), Is.EqualTo(180.0).Within(1e-5));
        That(Rad2Deg(5 * Math.PI), Is.EqualTo(5 * 180.0).Within(1e-5));
    }

    [Test]
    public void MoreRadDegTests()
    {
        That(Deg2Rad(30.0), Is.EqualTo(Math.PI/6).Within(1e-5));
        That(Deg2Rad(45.0), Is.EqualTo(Math.PI/4).Within(1e-5));
        That(Deg2Rad(60.0), Is.EqualTo(Math.PI/3).Within(1e-5));
        That(Deg2Rad(90.0), Is.EqualTo(Math.PI/2).Within(1e-5));
        That(Deg2Rad(120.0), Is.EqualTo(2*Math.PI/3).Within(1e-5));

        That(Rad2Deg(Math.PI/6), Is.EqualTo(30.0).Within(1e-5));
        That(Rad2Deg(Math.PI/4), Is.EqualTo(45.0).Within(1e-5));
        That(Rad2Deg(Math.PI/3), Is.EqualTo(60.0).Within(1e-5));
        That(Rad2Deg(Math.PI/2), Is.EqualTo(90.0).Within(1e-5));
        That(Rad2Deg(2*Math.PI/3), Is.EqualTo(120.0).Within(1e-5));
    }
}