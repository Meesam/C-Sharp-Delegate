using System;

public class Program
{
    public delegate void VoidDelegate();

    public delegate void VoidDelegateWithParameter(string msg);
    
    public delegate int CalculateDelegate(int a, int b);
    
    static void Main(string[] args)
    {
        VoidDelegate voidDelegate = Print1;
        DemoDelegate.ExecuteDelegate(voidDelegate);

        VoidDelegateWithParameter voidDelegateWithParameter = Print2;
        DemoDelegateWithParam.ExecuteDelegateWithParam(voidDelegateWithParameter);

        CalculateDelegate calculateDelegate = Add;
        DemoDelegateWithParamAndReturn.ExecuteDelegateWithParam(calculateDelegate);
        
        //Func delegate must return something, cannot be void
        
        // Inbuild delegate Func without param
        Func<string> func = GetMessage;
        Console.WriteLine(func());
        
        //Inbuild delegate Func with param
        Func<int, int, int> paramFunc = Add;
        Console.WriteLine(paramFunc(2,4));
        
        //Action delegate must not return anything,
        
        // Inbuild delegate Action
        Action<string> action = PrintMessage;
        action("Hello Action Delegate");
    }

    private static void Print1()
    {
        Console.WriteLine("Print1 method");
    }
    
    private static void Print2(string msg)
    {
        Console.WriteLine(msg);
    }

    private static int Add(int a, int b)
    {
        return a + b;
    }

    private static string GetMessage()
    {
        return "Message";
    }
    
    private static void PrintMessage(string msg)
    {
        Console.WriteLine(msg);
    }
}

class DemoDelegate
{
    public static void ExecuteDelegate(Program.VoidDelegate voidDelegate)
    {
        voidDelegate();
    }
}

class DemoDelegateWithParam
{
    public static void ExecuteDelegateWithParam(Program.VoidDelegateWithParameter voidDelegate)
    {
        voidDelegate("Delegate with Param");
    }
}

class DemoDelegateWithParamAndReturn
{
    public static void ExecuteDelegateWithParam(Program.CalculateDelegate calDelegate)
    {
        int result = calDelegate(5,3);
        Console.WriteLine(result);
    }
}