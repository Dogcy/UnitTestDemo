
using UnitTestDemo;

namespace TestProj;
[TestFixture]
public class UnitTestMemCalculator
{
    private MemCalculator _memCalculator;
    [SetUp]
    public void SetUp()
    {
        _memCalculator = new MemCalculator();
    }

    // 簡易的測試

    [Test]
    public void Sum_ByDefault_Returns0()
    {
        int lastSum = _memCalculator.Sum();
        Assert.That(lastSum, Is.EqualTo(0));
    }
    
    // 測試兩種FUNCTION內的質
    [Test]
    public void Sum_ByDefault_Returns0_test2()
    {
        int lastSum = _memCalculator.Sum();
        Assert.That(lastSum,Is.EqualTo(0));
    }

    [Test]
    public void Add_WhenCalled_ChangesSum()
    {
        _memCalculator.Add(1);
        int sum = _memCalculator.Sum();
        Assert.That(sum,Is.EqualTo(1));
    }
}