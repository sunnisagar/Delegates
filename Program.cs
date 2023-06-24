using static Program;
public class Program
{
    public delegate void voidDelegate();
    public delegate void voidDelegateWithParam(string msg);
    public delegate string voidDelegateWithParamOrReturn(string msg);

    public static void Main(string[] args)
    {
        //Delegate use case 1
        voidDelegate voidDelegateObj = ShowMessage;
        voidDelegateObj += ShowMessage2;
        MyDelegates.ExecuteDelegate(voidDelegateObj);

        //Delegate use case 2
        voidDelegateWithParam voidDelegateWithParamObj = ShowMessageWithParam;
        MyDelegates.ExecuteDelegateWithParam(voidDelegateWithParamObj, "This is voidDelegateWithParam Executed.");

        //Delegate use case 3
        voidDelegateWithParamOrReturn voidDelegateWithParamOrReturnObj = ShowMessageWithParamOrReturn;
        Console.WriteLine("Return:"+MyDelegates.ExecuteDelegateWithParamOrReturn(voidDelegateWithParamOrReturnObj, "This is voidDelegateWithParamOrReturn Executed."));
    }

    private static void ShowMessage()
    {
        Console.WriteLine("This is voidDelegate Executed.");
    }

    private static void ShowMessage2()
    {
        Console.WriteLine("This is voidDelegate Executed. 2");
    }

    private static void ShowMessageWithParam(string msg)
    {
        Console.WriteLine(msg);
    }

    private static string ShowMessageWithParamOrReturn(string msg)
    {
       return msg;
    }
}

public class MyDelegates
{
    public static void ExecuteDelegate(voidDelegate voidDelegate)
    {
        voidDelegate();
    }

    public static void ExecuteDelegateWithParam(voidDelegateWithParam voidDelegate, string msg)
    {
        voidDelegate(msg);
    }

    public static string ExecuteDelegateWithParamOrReturn(voidDelegateWithParamOrReturn voidDelegate, string msg)
    {
        return voidDelegate(msg);
    }
}