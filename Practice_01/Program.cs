using System;

namespace Practice_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                if (args.Length == 3)
                {
                    int result = 0;
                    int number1 = int.Parse(args[0]);
                    string operation = args[1];
                    int number2 = int.Parse(args[2]);
                    switch (operation)
                    {
                        case "+":
                            result = number1 + number2;
                            break;
                        case "-":
                            result = number1 - number2;
                            break;
                        case "/":
                            result = number1 / number2;
                            break;
                        case "*":
                            result = number1 * number2;
                            break;
                        default:
                            Console.WriteLine("Введите корректный знак (+-/*)");
                            return;
                    }
                    Console.WriteLine("Результат выполнения операции (" + operation + ") = " + result);
                }
                else
                    Console.WriteLine("Для использования программы введите: число знак(+-/*) число");
            }
            catch (FormatException ex)
            {
                Console.WriteLine($"Введите корректно число.\n{ex.Message}");
            }
        }
    }
}
