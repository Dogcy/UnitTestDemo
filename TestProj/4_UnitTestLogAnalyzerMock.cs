namespace TestProj;

// 手科物件 mock 測試
public class UnitTestLogAnalyzerMock
{
    [Test]
    public void Analyze_TooShortFileName_CallsWebService()
    {
        var mockService = new FakeWebService();
        var log = new LogAnalyzer(mockService);
        string tooShortFileName = "a.test";
        log.Analze(tooShortFileName);
       var check = mockService.LastError;
       Console.WriteLine(mockService.LastError);
    }
    public class FakeWebService : IWebServiceP
    {
        public string LastError;

        public void LogError(string message)
        {
            LastError = message;
        }
    }
}

public interface IWebServiceP
{
    void LogError(string message);
}

public class LogAnalyzer
{
    private IWebServiceP service;

    public LogAnalyzer(IWebServiceP service)
    {
        this.service = service;
    }

    public void Analze(string fileName)
    {
        if (fileName.Length < 8)
        {
            service.LogError("Filename too short :" + fileName);
        }
    }
}