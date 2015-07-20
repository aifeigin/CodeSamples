using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test5
{
    public class TrialCalculator
    {
        delegate bool TrialValidator(object input);
        public TrialCalculator()
        {          
        }

        public void Go()
        {
            while(true)
            {
                try
                {
                    object firstNumber = GetInputValue("Please, enter the first number or Q to quit");
                    if (firstNumber.ToString() == "Q") break;

                    object secondNumber = GetInputValue("Please, enter the second number");

                    object op = GetInputValue("Please, enter the operation (+,-,*,:)");

                    object result = doOperation(firstNumber, secondNumber, op);

                    Console.WriteLine(String.Format("{0}{1}{2}={3}", firstNumber, op, secondNumber, result));
                    Console.WriteLine("\n");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        object GetInputValue(string str, TrialValidator isValid=null)
        {
            Console.WriteLine(str);
            
            object input=Console.ReadLine();
            if (isValid!=null && !isValid(input))
                throw new Exception("Result is not valid");
            return input;
        }

        public Decimal? doOperation(object oDc1, object oDc2,object op)
        {
            Decimal dc1 = Convert.ToDecimal(oDc1);
            Decimal dc2 = Convert.ToDecimal(oDc2);

            Decimal? result = null; 
            switch (op.ToString())
            {
                case "+":
                    {
                        result = dc1 + dc2;
                        break;
                    }
                case "-":
                    {
                        result = dc1 - dc2;
                        break;
                    }
                case "*":
                    {
                        result = dc1 * dc2;
                        break;
                    }
                case ":":
                    {
                        result = dc1 / dc2;
                        break;
                    }
            }
            return result;
        }
    }
}
