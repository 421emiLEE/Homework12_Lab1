using static Delegate;
internal class Program

{
    private static void Main(string[] args)
    {

        //  Delegate :
        //Create 2 methods and assign the method to the delegate and use the method via the delegate.

        Delegate myDelegate = new Delegate();
        MyDelegate myDelegate1 =  myDelegate.printMessage;
        MyDelegate myDelegate2 =  myDelegate.printMessage2;
        myDelegate1.Invoke();
        myDelegate2.Invoke();



    }
}



public class Delegate
{
    public delegate void MyDelegate();

    public void printMessage()
    {
        Console.WriteLine("Printing method 1");
    }

    public void printMessage2()
    {
        Console.WriteLine("Printing method 2");
    }
}