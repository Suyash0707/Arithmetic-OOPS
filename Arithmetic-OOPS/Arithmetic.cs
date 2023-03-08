using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arithmetic_OOPS
{
    internal class Arithmetic
    {

        // Simple Pameter
        public void Addition(int num1, int num2)   // Paremeters or Arguments
        {
            int result = num1 + num2;

            // Console.WriteLine("Addition of" + num1 + "and" + num2 + "is=" + result );    //before concatenation

            Console.WriteLine($"Addition of {num1} and {num2} is= {result}");   //Concatenation // String Interpulation
        }

 
        // Complex Parameter
        public int A { get; set; }                // We have to create properties for complex parameters
        public int B { get; set; }
        public void Subtraction (Arithmetic arth)    
        {
            int result = arth.A - arth.B;
            Console.WriteLine($"Substraction of {arth.A} and {arth.B} is= {result}");

        }

        //Output Parameter
        public void Multiplication(int num1, int num2, out int result)   // write out before int result
        {
             result = num1 * num2;
            
        }

        //Input-Output Parameter
        public void Division(int num1, int num2, ref int result)   // write ref before int result for input-output parameter...input is default for num1 and num2
        {
             result = num1 / num2;

            Console.WriteLine($"Division of {num1} and {num2} is= {result}");
        }

    }
}
