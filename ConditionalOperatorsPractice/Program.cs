using System;
using System.ComponentModel;

namespace ConditionalOperatorsPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task1
            Console.WriteLine("Задание 1. Подсчёт площади прямоугольника");

            Console.WriteLine("Введите длину одной стороны");
            var a = DigitInput<decimal>(Console.ReadLine());

            Console.WriteLine("Введите длину другой стороны");
            var b = DigitInput<decimal>(Console.ReadLine());

            Console.WriteLine("Площадь прямоугольника "+ a * b);

            //Task2
            Console.WriteLine("Задание 2. Подсчёт площади прямоугольного треугольника");

            Console.WriteLine("Введите длину одного катета");
            a = DigitInput<decimal>(Console.ReadLine());

            Console.WriteLine("Введите длину другого катета");
            b = DigitInput<decimal>(Console.ReadLine());

            Console.WriteLine("Площадь прямоугольного треугольника " + a * b / 2);

            //Task3
            Console.WriteLine("Задание 3. Калькулятор");

            Console.WriteLine("Введите первое число");
            a = DigitInput<decimal>(Console.ReadLine());

            Console.WriteLine("Введите второе число");
            b = DigitInput<decimal>(Console.ReadLine());

            Console.WriteLine("Введите действие (+ - * / %)");
            var mathOperation = Console.ReadLine();

            switch (mathOperation)
            {
                case "+":
                    Console.WriteLine("Ответ " + (a + b));
                    break;
                case "-":
                    Console.WriteLine("Ответ " + (a - b));
                    break;
                case "*":
                    Console.WriteLine("Ответ " + (a * b));
                    break;
                case "/":
                    Console.WriteLine("Ответ " + (a / b));
                    break;
                case "%":
                    Console.WriteLine("Ответ " + (a % b));
                    break;
                default:
                    Console.WriteLine("Неизвестное математическое действие");
                    break;
            }

            //Task4
            Console.WriteLine("Задание 4. Программа для проверки совершеннолетия");

            Console.WriteLine("Введите возраст (число полных лет)");
            var age = DigitInput<int>(Console.ReadLine());

            Console.WriteLine(age<18?"Несовершеннолетний":"Совершеннолетний");
        }

        public static T DigitInput<T>(string input)
        {
            input = input.Replace(',', '.');
            var converter = TypeDescriptor.GetConverter(typeof(T));
            if (converter.IsValid(input))
            {
                input = input.Replace('.', ',');
                return (T) converter.ConvertFrom(input);
            }
            else
            {
                Console.WriteLine("Неверный ввод. Попробуйте ещё раз");
                return DigitInput<T>(Console.ReadLine());
            }
        }


    }
}
