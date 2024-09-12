using System; // Подключение пространства имен System
using ComplexNumbersLibrary; // Подключение пользовательской библиотеки для работы с комплексными числами

namespace ComplexNumbersApp // Объявление пространства имен для приложения
{
    class Program // Объявление класса Program
    {
        static void Main() // Объявление метода Main в качестве точки входа в приложение
        {
            ComplexNumber num1 = new ComplexNumber(0, 0); // Создание объекта ComplexNumber с начальными значениями 0+0i и присвоение его переменной num1
            ComplexNumber num2 = new ComplexNumber(0, 0); // Создание объекта ComplexNumber с начальными значениями 0+0i и присвоение его переменной num2

            // Сложение            
            ComplexNumber sum = num1.Add(num2); // Вызов метода Add у объекта num1 с параметром num2 и присвоение результата переменной sum
            Console.WriteLine($"{num1} + {num2} = {sum}"); // Вывод на консоль значения num1, num2 и sum в форматированном виде

            // Вычитание            
            ComplexNumber difference = num1.Subtract(num2); // Вызов метода Subtract у объекта num1 с параметром num2 и присвоение результата переменной difference
            Console.WriteLine($"{num1} - {num2} = {difference}"); // Вывод на консоль значения num1, num2 и difference в форматированном виде

            // Умножение            
            ComplexNumber product = num1.Multiply(num2); // Вызов метода Multiply у объекта num1 с параметром num2 и присвоение результата переменной product
            Console.WriteLine($"{num1} * {num2} = {product}"); // Вывод на консоль значения num1, num2 и product в форматированном виде

            // Деление            
            try // Начало блока try-catch для обработки исключений
            {
                ComplexNumber quotient = num1.Divide(num2); // Вызов метода Divide у объекта num1 с параметром num2 и присвоение результата переменной quotient
                Console.WriteLine($"{num1} / {num2} = {quotient}"); // Вывод на консоль значения num1, num2 и quotient в форматированном виде
            }
            catch (ComplexNumberException ex) // Обработка исключения типа ComplexNumberException
            {
                Console.WriteLine(ex.Message); // Вывод сообщения об ошибке на консоль
            }

            Console.ReadKey(); // Ожидание нажатия любой клавиши пользователем для завершения работы программы       
        }
    }
}