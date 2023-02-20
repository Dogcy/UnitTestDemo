namespace UnitTestDemo;

public class MemCalculator
{
    // 簡易計算機功能
    private int sum = 0;

    public void Add(int number)
    {
        sum += number;
    }

    public int Sum()
    {
        int temp = sum;
        sum = 0;
        return temp;
    }
}