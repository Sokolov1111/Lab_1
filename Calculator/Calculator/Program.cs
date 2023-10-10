using System;

class Calculator
{
    static void Main(string[] args)
    {
        Console.WriteLine("Calculator");

        Console.WriteLine("Введите первое число");
        string firstInput = Console.ReadLine();

        Console.WriteLine("Введите второе число");
        string secondInput = Console.ReadLine();

        Console.WriteLine("Введите операцию из списка: '+', '-', '/', '*' ");
        char oper = Convert.ToChar(Console.ReadLine());

        double res = 0;

        double firstNum, secondNum;

        if (!double.TryParse(firstInput, out firstNum) || !double.TryParse(secondInput, out secondNum))
        {
            Console.WriteLine("Введены неккоректные значения операндов");
            Environment.Exit(0);
        } else
        {
            switch (oper)
            {
                case '+':
                    res = firstNum + secondNum; break;
                case '-':
                    res = firstNum - secondNum; break;
                case '/':
                    if (secondNum == 0)
                    {
                        Console.WriteLine("Ошибка деления на 0 !!!");
                        Environment.Exit(0);
                        break;
                    }
                    else
                    {
                        res = firstNum / secondNum; break;
                    }
                case '*':
                    res = firstNum * secondNum; break;
            }
        }

        Console.WriteLine("Результат операции: " +  res);
    }
}