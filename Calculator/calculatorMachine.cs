using System;
namespace Calculator
{
    public class calculatorMachine
    {
        private double firstNumber;
        private double secondNumber;
        private double result;
        private char operation;

        public calculatorMachine(double first, double second, char opp)
        {
            firstNumber = first;
            secondNumber = second;
            operation = opp;
            Switching();
        }

        private void Switching()
            {
                switch (operation)
                {
                    case '+':
                        result = firstNumber + secondNumber;
                        Console.WriteLine("The sum of {0} and {1} is {2}", firstNumber, secondNumber, result);
                    startOver();
                        break;
                    case '-':
                        result = firstNumber - secondNumber;
                        Console.WriteLine("The difference between {0} and {1} is {2}", firstNumber, secondNumber, result);
                    startOver();
                    break;
                    case '*':
                        result = firstNumber * secondNumber;
                        Console.WriteLine("The product of {0} and {1} is {2}", firstNumber, secondNumber, result);
                    startOver();
                    break;
                    case '/':
                        result = firstNumber / secondNumber;
                        Console.WriteLine("The division of {0} and {1} is {2}", firstNumber, secondNumber, result);
                    startOver();
                    break;

                    default:
                        Console.WriteLine("Invalid operation. Please enter valid operation.");
                    End();
                        break;
                }
            }

        private void startOver()
        {
            Console.WriteLine("Would you like to calculate some more? If \'yes\' press and enter (Y)." + "\nOtherwise press any key to exit.");
            string YesorNo = Console.ReadLine();
            bool mybool = (YesorNo == "y" || YesorNo == "Y");
            if (mybool == true)
            {
                repeat();
            }
            else
            {
                End();
            }
             
        }

        private void repeat()
        {
            firstNumber = result;

            Console.WriteLine("Input Second Number.");
            secondNumber = double.Parse(Console.ReadLine());

            Console.WriteLine("Choose an operation: (+ , - , * , /)");
            operation = char.Parse(Console.ReadLine());
            Switching();
        }

        private void End()
        {
            Console.WriteLine("Final result is {0}", result);
            Console.WriteLine("Press any key to Exit.");
            Console.ReadLine();
        }

        } 
    }