namespace UnitTestDemo;

public class MyClass
{
    public void Func1Void()
    {
        Console.WriteLine("message : Func1Void");
    }

    public bool Func2EndWith(string input)
    {
        bool result = input.EndsWith(".txt");
        return  result;
    }

    public int Func3Int(int input)
    {
        return input;
    }

    public Model Func4GetModel()
    {
        var x = new Model() { Name = "david", Age = 5 };
        var str = x.Name;
        return new Model() { Name = "david", Age = 5 };
    }
}



public class Model
{
    public string? Name { get; set; }
    public int Age { get; set; }
}

