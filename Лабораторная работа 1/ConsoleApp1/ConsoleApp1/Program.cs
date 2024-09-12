using System;//подключение пространства имен System
using ComplexNumbersLibrary;

class Program
{
    static void Main(string[] args)//является точкой входа в программу
    {
        ComplexNumber z1 = new ComplexNumber(8, 9); // создание комплексного числа 2 + 3i
        ComplexNumber z2 = new ComplexNumber(-2, 3); // создание комплексного числа -1 + 2i

        Console.WriteLine("z1 = " + z1); // вывод на экран комплексного числа z1
        Console.WriteLine("z2 = " + z2); // вывод на экран комплексного числа z2

        ComplexNumber sum = z1.Add(z2); // сложение комплексных чисел z1 и z2
        ComplexNumber difference = z1.Subtract(z2); // вычитание комплексного числа z2 из z1
        ComplexNumber product = z1.Multiply(z2); // умножение комплексных чисел z1 и z2
        Console.WriteLine("z1 + z2 = " + sum); // вывод на экран суммы комплексных чисел z1 и z2
        Console.WriteLine("z1 - z2 = " + difference); // вывод на экран разности комплексных чисел z1 и z2
        Console.WriteLine("z1 * z2 = " + product); // вывод на экран произведения комплексных чисел z1 и z2

        Console.ReadKey();
    }
}