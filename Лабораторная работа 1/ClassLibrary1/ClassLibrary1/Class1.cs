//Библиотечный модуль
using System;//подключение пространства имен System
using System.Collections.Generic;//подключение пространства имен System.Collections.Generic
using System.Linq;//подключение пространства имен System.Linq
using System.Text;//подключение пространства имен System.Text
using System.Threading.Tasks; //подключение пространства имен System.Threading.Tasks

namespace ComplexNumbersLibrary//объявление пространства имен
{
    public class ComplexNumber//объявление класса ComplexNumber
    {
        // Поля класса
        private double realPart; //поле действительной части комплексного числа
        private double imaginaryPart;//поле мнимой части комплексного числа

        public ComplexNumber(double realPart, double imaginaryPart)//конструктор с параметрами, задающий действительную 
            //и мнимую части комплексного числа
        {
            this.realPart = realPart;
            this.imaginaryPart = imaginaryPart;
        }

        public ComplexNumber()//конструктор, создающий комплексное число 0 + 0i
        {
            this.realPart = 0;
            this.imaginaryPart = 0;
        }

        public ComplexNumber Add(ComplexNumber other)//метод сложения двух комплексных чисел
        {
            double real = this.realPart + other.realPart;//вычисление действительной части суммы
            double imaginary = this.imaginaryPart + other.imaginaryPart;//вычисление мнимой части суммы
            return new ComplexNumber(real, imaginary); //создание нового объекта класса ComplexNumber с полученными 
            //значениями
        }

        public ComplexNumber Subtract(ComplexNumber other)//метод вычитания одного комплексного числа 
            //из другого
        {
            double real = this.realPart - other.realPart;//вычисление действительной части разности
            double imaginary = this.imaginaryPart - other.imaginaryPart; //вычисление мнимой части разности
            return new ComplexNumber(real, imaginary); //создание нового объекта класса ComplexNumber с 
            //полученными значениями
        }

        public ComplexNumber Multiply(ComplexNumber other)//метод умножения двух комплексных чисел
        {
            double real = this.realPart * other.realPart - this.imaginaryPart * other.imaginaryPart; //вычисление действительной части
            //произведения
            double imaginary = this.realPart * other.imaginaryPart + this.imaginaryPart * other.realPart;//вычисление мнимой части
            //произведения
            return new ComplexNumber(real, imaginary);//создание нового объекта класса ComplexNumber с полученными 
            //значениями
        }

        public override string ToString()// переопределённый  метод ToString(), возвращающий
                                         //строковое представление комплексного числа
        {
            if (this.imaginaryPart >= 0)//если мнимая часть неотрицательна
            {
                return this.realPart + " + " + this.imaginaryPart + "i";//возвращаем строку вида "действительная
                //часть + мнимая часть i"
            }
            else//если мнимая часть отрицательна
            {
                return this.realPart + " - " + (-this.imaginaryPart) + "i";//возвращаем строку вида "действительная 
                //часть - |мнимая часть| i"
            }
        }
    }
}
