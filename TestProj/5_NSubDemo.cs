using NSubstitute;
using NUnit.Framework.Internal;
using UnitTestDemo;

namespace TestProj;

public class NSubDemo
{
    /// <summary>
    /// 原始
    /// </summary>
    [Test]
    public void Analyze_TooShortFileName_CallLogger()
    {
        FakeLogger fakeLogger = new FakeLogger();
        LogAnalyzer3 logAnalyzer = new LogAnalyzer3(fakeLogger);
        logAnalyzer.MinNameLength = 6;
        logAnalyzer.Analyze("a. txt");
        StringAssert.Contains("too short", fakeLogger.LastError);
    }
    /// <summary>
    /// NSub-Demo    (Nsubstitute隔離框架)
    /// </summary>
    [Test]
    public void Analyze_TooShortFileName_CallLogger2()
    {
        Ilogger logger = Substitute.For<Ilogger>();
        LogAnalyzer3 logAnalyzer = new LogAnalyzer3(logger);
        logAnalyzer.MinNameLength = 6;
        logAnalyzer.Analyze("a. txt");
        // 可直接讓你跳過虛設常式或手刻物件 (免除FakeLogger)
        logger.Received().LogError("too short");
    }
}

public class FakeLogger : Ilogger
{
    public string LastError;

    public void LogError(string message)
    {
        LastError = message;
    }
}

public interface Ilogger
{
    void LogError(string message);
}

public class LogAnalyzer3
{
    public int MinNameLength  ;
    private Ilogger service;

    public LogAnalyzer3(Ilogger service)
    {
        this.service = service;
    }

    public void Analyze(string fileName)
    {
        if (fileName.Length <= this.MinNameLength)
        {
            service.LogError("too short");
        }
    }
}