namespace CSharpNotes.Types;
public class DeclaringLocalVariables
{
    [Fact]
    public void ExplicitlyTypedLocalVariable()
    {
        // Type identifier [= value]
        int a = 0;
        int b = 2;

        string dogName = "Rover";

        Assert.Equal("Rover", dogName);

        Assert.Equal(0, a);
        Assert.Equal(2, b);
    }

    [Fact]
    public void ImplicitlyTypedLocalVariablesWithVar()
    {
        //if you are going to initialize the variable C# already knows the type 
        var a = 0;
        var b = 1.0;
        var c = "Cat"; //string
        var d = 'A'; //char
        var e = true; //bool
        var salary = 80123.23M;

        var rover = new Dog();

    }

    [Fact]
    public void ImplicitlyTypedLocalVariablesWithNew()
    {
        // .NET 5
        Dog rover = new();
    }
}

public class Dog { }
