using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using Assert = NUnit.Framework.Assert;
using StringAssert = NUnit.Framework.StringAssert;

namespace TextNewPara
{
    
        
    
    class Ya
    {

        //public static StringCollection CreatePupa()
        //{
        //    return new StringCollection() { "Hallo", "YaNeZnautoPist", "MPT", "Warframe", "MetroExodus" };
        //}
        public static void Main(string[] args)
        {
            //for (byte i = 0; i < 5; i++)
            //{
            //    Console.WriteLine(Ya.CreatePupa()[i]);
            //}
            //Console.ReadKey();
        }

    }

    //[TestFixture]
    //public class Test
    //{
    //    //Вторая практическая снизу

    //    //[Test]
    //    //public void TestConverterReturnsRightValue()
    //    //{
    //    //    UahConverter converter = new UahConverter(0.25, 10, 8);

    //    //    converter.OutputCurrency = Currency.EUR;
    //    //    converter.Value = 1000;

    //    //    Assert.AreEqual(100, converter.Value);
    //    //}

    //    //[Test]
    //    //[ExpectedException(typeof(ArgumentException))]
    //    //public void TestConverterGenereteArgumentException()
    //    //{
    //    //    UahConverter converter = new UahConverter(0.25, 10, 8);

    //    //    converter.OutputCurrency = Currency.USD;
    //    //    converter.Value = 1000;
    //    //}

    //    //[Test]
    //    //public void TestConverterGenareteCtorArgumentException()
    //    //{
    //    //    try
    //    //    {
    //    //        UahConverter converter = new UahConverter(0.25, 10, 8);

    //    //        converter.OutputCurrency = Currency.EUR;
    //    //        converter.Value = 1000;
    //    //    }
    //    //    catch (ArgumentException ex)
    //    //    {
    //    //        StringAssert.Contains(ex.Message, "Ctro");
    //    //        return;
    //    //    }
    //    //}

    //    //[Test]
    //    //public void TextConverterGenareteInputValueArgumentExeption()
    //    //{
    //    //    try
    //    //    {

    //    //        UahConverter converter = new UahConverter(0.25, 10, 8);

    //    //        converter.OutputCurrency = Currency.EUR;
    //    //        converter.Value = -1000;
    //    //    }
    //    //    catch (ArgumentException ex)
    //    //    {
    //    //        StringAssert.Contains(ex.Message, "Value");
    //    //        return;
    //    //    }

    //    //    Assert.Fail("No exeption was thrown");
    //    //}
    //    //public void Helper()
    //    //{
    //    //    Assert.That(Ya.CreatePupa(), Is.Not.TypeOf(typeof(int)));
    //    //}
    //    //[Test]
    //    //public void InInstanseOf()
    //    //{
    //    //    Assert.IsInstanceOf(typeof(object), Ya.CreatePupa());

    //    //}
    //    //[Test]
    //    //public void Empty()
    //    //{
    //    //    Assert.IsNotEmpty(Ya.CreatePupa());
    //    //}
    //    //[Test]
    //    //public void Contain()
    //    //{
    //    //    Assert.Contains("Hallo", Ya.CreatePupa());
    //    //}
    //}





    //[TestFixture]
    //class CalculatorTest
    //{
    //    [Test]
    //    public static void Testoperations()
    //    {
    //        Calculator c = new Calculator();

    //        Assert.AreEqual(8, c.Add(3, 5));
    //        Assert.AreEqual(4, c.Sub(6, 2));
    //        Assert.AreEqual(24, c.Mul(8, 3));
    //        Assert.AreEqual(2, c.Div(6, 3));

    //        Assert.AreNotEqual(9, c.Add(3, 5));
    //    }
    //}

    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Calculator c = new Calculator();

    //        Console.WriteLine("3 + 5 = {0}");
    //        Console.WriteLine("6 - 2 = {0}");
    //        Console.WriteLine("8 * 3 = {0}");
    //        Console.WriteLine("6 / 3 = {0}");

    //        Console.ReadKey();
    //    }
    //}

    //[TestFixture]
    //class MyClassTest
    //{
    //    [Test]
    //    public void AreSame()
    //    {
    //        string a = "hello";
    //        string b = "World!";

    //        a = b;
    //        Assert.AreSame(a, b);
    //    }
    //}

    //[TestFixture]
    //class ContainsTest
    //{
    //    [Test]
    //    public void Contains()
    //    {
    //        ArrayList array = new ArrayList();
    //        array.Add("Alex");
    //        array.Add("Serg");
    //        array.Add("Jhon");

    //        Assert.Contains("Alex", array);
    //    }
    //}

    //[TestFixture]

    //class ComparisonsTest
    //{
    //    private int a, b;
    //    [SetUp]

    //    public void Init()
    //    {
    //        a = 10;
    //        b = 20;
    //    }

    //    [Test]
    //    public void Greater()
    //    {
    //        Assert.Greater(a, b);
    //        Assert.GreaterOrEqual(a, b);
    //    }
    //    [Test]
    //    public void Less()
    //    {
    //        Assert.Less(a, b);
    //        Assert.LessOrEqual(a, b);
    //    }
    //}


    //[TestFixture]
    //class TypeAssertsTest
    //{
    //    [Test]
    //    public void InInstanseOf()
    //    {
    //        Assert.IsInstanceOf(typeof(object), "Hello");
    //        Assert.IsNotInstanceOf(typeof(string), 5);

    //    }
    //}
    //class Calculator
    //{
    //    int x, y;
    //    public Calculator()
    //    {

    //    }

    //    public Calculator(int x, int y)
    //    {
    //        this.x = x;
    //        this.y = y;
    //    }

    //    public int Add(int x, int y)
    //    {
    //        return x + y;
    //    }

    //    public int Sub(int x, int y)
    //    {
    //        return x - y;
    //    }

    //    public int Mul(int x, int y)
    //    {
    //        return x * y;
    //    }

    //    public int Div(int x, int y)
    //    {
    //        return x / y;
    //    }
    //}

    //[TestFixture]
    //class ConditionTest
    //{
    //    Calculator calc;
    //    [SetUp]
    //    public void Init()
    //    {
    //        calc = new Calculator();
    //    }

    //    [Test]

    //    public void IsTrue()
    //    {
    //        Assert.IsTrue(calc.Add(2, 2) == 4);
    //    }

    //    [Test]
    //    public void IsFalse()
    //    {
    //        Assert.IsFalse(calc.Mul(3, 6) == 20);
    //    }
    //    [Test]
    //    public void IsNan()
    //    {
    //        double d = double.NaN;

    //        Assert.IsNaN(d);

    //    }
    //    [Test]
    //    public void IsEmpty()
    //    {
    //        Assert.IsEmpty("");
    //        Assert.IsNotEmpty("Hello");

    //        Assert.IsEmpty(new ArrayList());
    //        Assert.IsNotEmpty(new List<string> { "one", "two" });

    //    }
    //}
}
