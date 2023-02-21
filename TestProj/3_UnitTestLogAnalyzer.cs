using Microsoft.VisualStudio.TestPlatform.Common.Utilities;
using UnitTestDemo;

namespace TestProj;

[TestFixture]
public class UnitTestLogAnalyzer
{
    private LogAnalyzer _logAnalyzer_fake;

    [SetUp]
    public void SetUp()
    {
        _logAnalyzer_fake =  new LogAnalyzer(new FakeExtensionManager());
    }

    [Test]
    public void IsValidFileName_NameSupportedExtension_ReturnsTrue()
    {
        _logAnalyzer_fake
    }
    
    

    
}
internal class FakeExtensionManager : IExtensionManager
{
    public bool WillBeVaild = false;
    public bool IsValid(string fileName)
    {
        return WillBeVaild;
    }
}