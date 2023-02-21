namespace UnitTestDemo;


// 此範例為 假設須測試資料為與外界相依 ex:讀取本機內的檔案
// 若實際用檔案做測試可能會有效能，檔案不存在等狀況，
// 利用InterFace解決，做出fake data。
public class LogAnalyzer
{
    private IExtensionManager _manager;

    public LogAnalyzer(IExtensionManager manager)
    {
        _manager = manager;
    }

    public bool IsValidLogFileName(string fileName)
    {
        return _manager.IsValid(fileName);
    }
}

public interface IExtensionManager
{
    bool IsValid(string fileName);
}