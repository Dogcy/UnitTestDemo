
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
    [Test]
    public void Sum_ByDefault_Returns0()
    {
        int lastSum = _memCalculator.Sum();
        Assert.AreEqual(0, lastSum);
    }
}