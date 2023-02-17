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

        try
        {
            var result = int.Parse(input);
            return result;

        }
        catch (Exception e)
        {
            
            throw;
        }
            
       
        
    }

    public Model Func4GetModel()
    {
        var x = new Model { Name = "david", Age = 5 };

        return x;
    }
}

public class Model
{
    public string? Name { get; set; }
    public int Age { get; set; }
}