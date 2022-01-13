using System;

namespace Basic
{
    abstract class Calculator
    {
        public abstract void Sum( double number1, double number2);
        public abstract void Subtract( double number1, double number2);
        public abstract void Multiply( double number1, double number2);
        public abstract void Divide( double number1, double number2);


    }

    class Rule : Calculator{
        public override void Sum( double number1, double number2 )
        {
            double result=number1+number2;
            System.Console.WriteLine("addition is :" + result);
        }

        public override void Subtract( double number1, double number2 )
        {
            double result=number1-number2;
            System.Console.WriteLine("subtraction is :" +result);
        }

        public override void Multiply( double number1, double number2 )
        {
            double result=number1*number2;
            System.Console.WriteLine("multiplication is :" +result);
        }

        public  override void Divide( double number1, double number2 )
        {
            double result=number1/number2;
            System.Console.WriteLine("division is :" +result);
        }
    
    }
    
}