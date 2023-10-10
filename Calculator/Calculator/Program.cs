using System;

class Calculator
{
    static void Main(string[] args)
    {
        Console.WriteLine("Calculator");

        Console.WriteLine("Введите первое число");
        double firstNum = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Введите второе число");
        double secondNum = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Введите операцию из списка: '+', '-', '/', '*' ");
        char oper = Convert.ToChar(Console.ReadLine());

        double res = 0;

        switch (oper)
        {
            case '+': 
                res = firstNum + secondNum; break;
            case '-':
                res = firstNum - secondNum; break;
            case '/':
                res = firstNum / secondNum; break;
            case '*':
                res = firstNum * secondNum; break;
        }

        Console.WriteLine("Результат операции: " +  res);
    }
}