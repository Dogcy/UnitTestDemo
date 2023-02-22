using Microsoft.VisualStudio.TestPlatform.Common.Utilities;
using UnitTestDemo;

namespace TestProj;

[TestFixture]
public class UnitTestLogAnalyzer
{
    // 實作內容已變成FakeFunc
    private LogAnalyzer _logAnalyzer_fake;
    
    [SetUp]
    public void SetUp()
    {
        var myFakeManager = new FakeExtensionManager();
        myFakeManager.WillBeVaild = true;
        // 因LogAnlayzer是利用建構子 + interface 可讓製作出來的FakeClass傳入進去
        _logAnalyzer_fake =  new LogAnalyzer(myFakeManager);
    }

    [Test]
    public void IsValidFileName_NameSupportedExtension_ReturnsTrue()
    {
        bool result =  _logAnalyzer_fake.IsValidLogFileName("short.ext");
        Assert.True(result);
    }
}

// 抽離 IExtensionManager 並製作一個fakeClass可以製作UnitTest
internal class FakeExtensionManager : IExtensionManager
{
    public bool WillBeVaild = false;
    public bool IsValid(string fileName)
    {
        return WillBeVaild;
    }
}