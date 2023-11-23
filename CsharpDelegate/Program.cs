using System;

public class Program
{
    public delegate void VoidDelegate();

    public delegate void VoidDelegateWithParameter(string msg);
    
    static void Main(string[] args)
    {
        VoidDelegate voidDelegate = Print1;
        DemoDelegate.ExecuteDelegate(voidDelegate);
        VoidDelegateWithParameter voidDelegateWithParameter = Print2;
        DemoDelegateWithParam.ExecuteDelegateWithParam(voidDelegateWithParameter);
    }

    private static void Print1()
    {
        Console.WriteLine("Print1 method");
    }
    
    private static void Print2(string msg)
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