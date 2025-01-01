public class ExampleClass
{
    public int MyProperty { get; set; }

    // Constructor to initialize the property
    public ExampleClass()
    {
        MyProperty = 0; // Initialize MyProperty in the constructor
    }

    public void MyMethod()
    {
        Console.WriteLine(MyProperty); 
    }
} 