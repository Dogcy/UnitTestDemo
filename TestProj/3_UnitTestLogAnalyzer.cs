﻿using Microsoft.VisualStudio.TestPlatform.Common.Utilities;
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

    /// <summary>
    /// 假物件模擬異常
    /// </summary>
    [Test]
    public void IsValidFileName_ExtManagerThrowsException_RetrunsFalse()
    {
        FakeExtensionManager2 myFakeManager = new FakeExtensionManager2();
        myFakeManager.WillThrow = new Exception("this is fake");
        LogAnalyzer log = new LogAnalyzer(myFakeManager);
        bool result = log.IsValidLogFileName("anything.anyextension");
        Assert.False(result);

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

/// <summary>
/// 假物件模擬異常 假資料
/// </summary>
internal class FakeExtensionManager2 : IExtensionManager
{
    public bool WillBeVaild = false;
    public Exception WillThrow = null;
    public bool IsValid(string fileName)
    {
        if(WillThrow !=null)
        {
            // 為了讓此案例通過 需在測試方法中增加Try-Catch  (這邊未加入所以在此區將跳出)
            throw WillThrow;
        }
        return WillBeVaild;
    }
}