namespace UnitTestDemo;

public class MyClass
{
    public void Func1Void()
    {
        Console.WriteLine("message : Func1Void");
    }

    public bool Func2EndWith(string input)
    {
        var result = input.EndsWith(".txt");
        return result;
    }

    public int Func3EndWithExecptionDemo(string input)
    {
        var result = int.Parse(input);
        return result;
    }

    public Model Func4GetModel()
    {
        return new Model() { Name = "david", Age = 5 };
    }
}

public class Model
{
    public string? Name { get; set; }
    public int Age { get; set; }
}