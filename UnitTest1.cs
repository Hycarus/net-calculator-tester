namespace net_calculator_tester;

public class Tests
{
    private Calculator calculator;

    [SetUp]
    public void Setup()
    {
        calculator = new Calculator();
    }

    [Test]
    public void TestAdd()
    {
        float result = calculator.Add(5, 5);
        Assert.AreEqual(10, result);
    }

    [Test]
    public void TestSubtract()
    {
        float result = calculator.Subtract(5, 3);
        Assert.AreEqual(2, result);
    }

    [Test]
    public void TestDivide()
    {
        float result = calculator.Divide(6, 2);
        Assert.AreEqual(3, result);
    }

    [Test]
    public void TestMultiply()
    {
        float result = calculator.Multiply(2, 4);
        Assert.AreEqual(8, result);
    }

    [Test]
    public void TestDividedByZero()
    {
        Assert.Throws<DivideByZeroException>(() => calculator.Divide(5, 0));
    }
}
