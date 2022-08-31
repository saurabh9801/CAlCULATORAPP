using CalculatorWebApp.Models;
using static System.Net.Mime.MediaTypeNames;

namespace CalculatorApp.Pages
{
    public partial class ADD
    {     
        
        Calculator calculator = new Calculator();

        string num1;
        string num2;
        string finalresult;
        void AddNumbers()
        {
            finalresult = (Convert.ToDouble(num1) + Convert.ToDouble(num2)).ToString();

            calculator.FirstNumber = Convert.ToInt32(num1);
            calculator.SecondNumber = Convert.ToInt32(num2);
            calculator.Operator = "+";
            calculator.Result = Convert.ToInt32(finalresult);

            CalculatorController calculatorController= new CalculatorController();
            calculatorController.Create(calculator);


        }
        void SubtractNumbers()
        {
            finalresult = (Convert.ToDouble(num1) - Convert.ToDouble(num2)).ToString();
            calculator.FirstNumber = Convert.ToInt32(num1);
            calculator.SecondNumber = Convert.ToInt32(num2);
            calculator.Operator = "-";
            calculator.Result = Convert.ToInt32(finalresult);

            CalculatorController calculatorController = new CalculatorController();
            calculatorController.Create(calculator);

        }
        void MultiplyNumbers()
        {
            finalresult = (Convert.ToDouble(num1) * Convert.ToDouble(num2)).ToString();
            calculator.FirstNumber = Convert.ToInt32(num1);
            calculator.SecondNumber = Convert.ToInt32(num2);
            calculator.Operator = "*";
            calculator.Result = Convert.ToInt32(finalresult);

            CalculatorController calculatorController = new CalculatorController();
            calculatorController.Create(calculator);
        }
        void DivideNumbers()
        {
            if (Convert.ToDouble(num2) != 0)
            {
                finalresult = (Convert.ToDouble(num1) / Convert.ToDouble(num2)).ToString();
                calculator.FirstNumber = Convert.ToInt32(num1);
                calculator.SecondNumber = Convert.ToInt32(num2);
                calculator.Operator = "/";
                calculator.Result = Convert.ToInt32(finalresult);

                CalculatorController calculatorController = new CalculatorController();
                calculatorController.Create(calculator);
            }
            else
            {
                finalresult = "Cannot Divide by Zero";
            }
        }    

    }
}

