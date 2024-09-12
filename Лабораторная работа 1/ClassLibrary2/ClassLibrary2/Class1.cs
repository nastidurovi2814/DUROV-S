using System;

namespace ComplexNumbersLibrary
{
    public class ComplexNumberException : Exception
    {
        // Конструктор класса, принимающий строку сообщения об ошибке и передающий ее в базовый конструктор класса Exception
        public ComplexNumberException(string message) : base(message)
        {
        }
    }
}

// Объявление класса ComplexNumber, который представляет комплексное число
namespace ComplexNumbersLibrary
{
    public class ComplexNumber
    {
        // Закрытые поля класса, представляющие действительную и мнимую части комплексного числа
        private double real;
        private double imaginary;

        // Конструктор класса, принимающий значения действительной и мнимой частей комплексного числа и инициализирующий соответствующие поля
        public ComplexNumber(double real, double imaginary)
        {
            this.real = real;
            this.imaginary = imaginary;
        }

        // Метод Add, который складывает текущее комплексное число с переданным в параметре other и возвращает новый объект ComplexNumber с результатом сложения
        public ComplexNumber Add(ComplexNumber other)
        {
            double resultReal = real + other.real;
            double resultImaginary = imaginary + other.imaginary;
            return new ComplexNumber(resultReal, resultImaginary);
        }

        // Метод Subtract, который вычитает из текущего комплексного числа переданное в параметре other и возвращает новый объект ComplexNumber
      //  с результатом вычитания
        public ComplexNumber Subtract(ComplexNumber other)
        {
            double resultReal = real - other.real;
            double resultImaginary = imaginary - other.imaginary;
            return new ComplexNumber(resultReal, resultImaginary);
        }

        // Метод Multiply, который умножает текущее комплексное число на переданное в параметре other и возвращает новый объект ComplexNumber с результатом умножения
        public ComplexNumber Multiply(ComplexNumber other)
        {
            double resultReal = (real * other.real) - (imaginary * other.imaginary);
            double resultImaginary = (imaginary * other.real) + (real * other.imaginary);
            return new ComplexNumber(resultReal, resultImaginary);
        }

        // Метод Divide, который делит текущее комплексное число на переданное в параметре other и возвращает новый объект ComplexNumber с результатом деления
        public ComplexNumber Divide(ComplexNumber other)
        {
            // Если переданный объект other представляет нулевое комплексное число, выбрасывается пользовательское исключение типа ComplexNumberException
            if (other.real == 0 && other.imaginary == 0)
                throw new ComplexNumberException("НЕВОЗМОЖНО РАЗДЕЛИТЬ НА НОЛЬ.");

            double divisor = Math.Pow(other.real, 2) + Math.Pow(other.imaginary, 2);
            double resultReal = ((real * other.real) + (imaginary * other.imaginary)) / divisor;
            double resultImaginary = ((imaginary * other.real) - (real * other.imaginary)) / divisor;
            return new ComplexNumber(resultReal, resultImaginary);
        }

        // Переопределение метода ToString для правильного вывода комплексного числа в форматированном виде
        public override string ToString()
        {
            if (imaginary < 0)
                return $"{real} - {-imaginary}i";
            else
                return $"{real} + {imaginary}i";
        }
    }
}

