using UnitTestDemo;

try
{
    var myclass =  new MyClass();
    string x = null;
    myclass.Func2EndWithExecptionDemo(x);
}

catch(DirectoryNotFoundException ex) 
{ 
    //more code 
    throw;
} 
catch(FileNotFoundException ex) 
{ 
    //more code 
    throw;
} 
catch(IOException ex) 
{ 
    //more code 
    throw;
} 
catch(ArgumentNullException ex) 
{ 
    //more code 

    throw;
} 
catch(Exception ex) 
{ 
    //more code 
    throw;
} 
