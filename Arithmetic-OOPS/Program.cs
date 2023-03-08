using Arithmetic_OOPS;

public class Program
{
    public static void Main()
    {
        Arithmetic arithmetic1 = new Arithmetic();            //classname.objectname = new object
        arithmetic1.Addition(10, 20);                         //objectname.methodname 


        Arithmetic arithmetic2 = new Arithmetic();
        arithmetic2.A = 20;
        arithmetic2.B = 10;
        Arithmetic arithmetic3 = new Arithmetic();
        arithmetic3.Subtraction(arithmetic2);

                                
        arithmetic1.Multiplication(10, 20, out int result);
        Console.WriteLine($"Multiplication of 10 and 20 is= {result}");

        int result1=10;                                   //we have to declare int as result1 beacause result is already in use above.
        arithmetic1.Division(20, 10, ref result1);    
    }
}
