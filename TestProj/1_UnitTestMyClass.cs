using UnitTestDemo;

namespace TestProj;

[TestFixture]
public class Tests
{
    private MyClass _myClass;

    [SetUp] //SetUp 所有被測試[Test]的類別都會呼叫一次SetUp （表示）此物件狀態都會重新new出來
    public void Setup()
    {
        _myClass = new MyClass();
    }

    [Test] // 代表需測試的標籤
    // 命名模式可用此範例 [UnitOfWork]_[Scenario]_[ExpectedBehavior]
    public void Func2Bool_endStringMatch_Returnstrue()
    {
        // 寫死的方式
        var actual = _myClass.Func2EndWith(".txt");
        Assert.That(actual);
    }

    [Test]
    [TestCase("MyFileName.txt", true)]
    [TestCase("MyFileName.tut", false)]
    // [TestCase]可設定多筆
    public void Func2Bool_endStringMatch_Returnstrue2(string textEndName, bool expected)
    {
        // 利用[TestCase]設定expected達到可以測試true與false兩種結果

        var actual = _myClass.Func2EndWith(textEndName);

        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Func3Execption_endStringMatch_CatchError()
    {
        var ex = Assert.Catch<Exception>(() => _myClass.Func3EndWithExecptionDemo(null));
        // StringAssert.Contains("Value cannot be null. (Parameter 's')",ex.Message);
        var f = typeof(ArgumentNullException).ToString();
        var f2 = ex.GetType().ToString();
        StringAssert.Contains(typeof(ArgumentNullException).ToString(),ex.GetType().ToString());
    }
}
