using System;

namespace Calculator.Specs
{
    public class Calculator
    {
        public static int FirstNumber { get; set; }
        public static int SecondNumber { get; set; }

        public static int Add()
        {
            return FirstNumber + SecondNumber;
        }

        public static int Subtract()
        {
            return FirstNumber - SecondNumber;
        }

        public static int Multiply()
        {
            return FirstNumber * SecondNumber;
        }

        public static int Divide()
        {
            return FirstNumber / SecondNumber;
        }
    }
}
