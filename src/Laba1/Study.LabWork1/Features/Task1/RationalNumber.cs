using System;
using System.Collections.Generic;
using System.Text;

namespace Study.LabWork1.Features.Task1
{
    /// <summary>
    /// Класс, представляющий рациональное число
    /// </summary>
    public class RationalNumber
    {
        /// <summary>
        /// Числитель дроби (только для чтения)
        /// </summary>
        public int numerator { get; }
        /// <summary>
        /// Знаменатель дроби (только для чтения)
        /// </summary>
        public int denominator { get; }
        /// <summary>
        /// Конструктор класса Rational
        /// </summary>
        /// <param name="numerator">Числитель</param>
        /// <param name="denominator">Знаменатель</param>
        /// <exception cref="ArgumentException">Выбрасывается, если знаменатель равен 0</exception>
        public RationalNumber(int numerator, int denominator)
        {
            if (denominator == 0)
                throw new ArgumentException("Знаменатель не может быть равен нулю");

            if (denominator < 0)
            {
                numerator = -numerator;
                denominator = -denominator;
            }

            int gcd = GCD(Math.Abs(numerator), Math.Abs(denominator));
            this.numerator = numerator /= gcd;
            this.denominator = denominator /= gcd;
        }

        /// <summary>
        /// Нахождение наибольшего общего делителя
        /// </summary>
        /// <param name="numerator">Числитель</param>
        /// <param name="denominator">Знаменатель</param>
        /// <returns>Наибольший общий делитель</returns>
        public int GCD(int numerator, int denominator)
        {
            while (denominator != 0)
            {
                int temp = denominator;
                denominator = numerator % denominator;
                numerator = temp;
            }
            return numerator;
        }

        /// <summary>
        /// Перегрузка метода ToString()
        /// </summary>
        /// <returns>Строковое представление дроби</returns>
        public override string ToString()
        {
            if (denominator == 1)
                return numerator.ToString();

            return $"{numerator}/{denominator}";
        }

        /// <summary>
        /// Сложение двух дробей
        /// </summary>
        public static RationalNumber operator +(RationalNumber a, RationalNumber b)
        {
            int numerator = a.numerator * b.denominator + b.numerator * a.denominator;
            int denominator = a.denominator * b.denominator;
            return new RationalNumber(numerator, denominator);
        }

        /// <summary>
        /// Вычитание двух дробей
        /// </summary>
        public static RationalNumber operator -(RationalNumber a, RationalNumber b)
        {
            int numerator = a.numerator * b.denominator - b.numerator * a.denominator;
            int denominator = a.denominator * b.denominator;
            return new RationalNumber(numerator, denominator);
        }

        /// <summary>
        /// Умножение двух дробей
        /// </summary>
        public static RationalNumber operator *(RationalNumber a, RationalNumber b)
        {
            int numerator = a.numerator * b.numerator;
            int denominator = a.denominator * b.denominator;
            return new RationalNumber(numerator, denominator);
        }

        /// <summary>
        /// Деление двух дробей
        /// </summary>
        /// <exception cref="ArgumentException">Выбрасывается, если появляется деление на 0</exception>
        public static RationalNumber operator /(RationalNumber a, RationalNumber b)
        {
            if (b.numerator == 0)
                throw new ArgumentException("Деление на ноль невозможно");
            int numerator = a.numerator * b.denominator;
            int denominator = a.denominator * b.numerator;
            return new RationalNumber(numerator, denominator);
        }

        /// <summary>
        /// Унарный минус
        /// </summary>
        public static RationalNumber operator -(RationalNumber a)
        {
            return new RationalNumber(-a.numerator, a.denominator);
        }

        /// <summary>
        /// Равенство двух дробей
        /// </summary>
        public static bool operator ==(RationalNumber a, RationalNumber b)
        {
            return a.numerator == b.numerator && a.denominator == b.denominator;
        }

        /// <summary>
        /// Неравенство двух дробей
        /// </summary>
        public static bool operator !=(RationalNumber a, RationalNumber b)
        {
            return !(a == b);
        }

        /// <summary>
        /// Знак больше для сравнения двух дробей
        /// </summary>
        public static bool operator >(RationalNumber a, RationalNumber b)
        {
            return a.numerator * b.denominator > b.numerator * a.denominator;
        }

        /// <summary>
        /// Знак меньше для сравнения двух дробей
        /// </summary>
        public static bool operator <(RationalNumber a, RationalNumber b)
        {
            return a.numerator * b.denominator < b.numerator * a.denominator;
        }

        /// <summary>
        /// Знак больше или равно для сравнения двух дробей
        /// </summary>
        public static bool operator >=(RationalNumber a, RationalNumber b)
        {
            return a > b || a == b;
        }

        /// <summary>
        /// Знак меньше или равно для сравнения двух дробей
        /// </summary>
        public static bool operator <=(RationalNumber a, RationalNumber b)
        {
            return a < b || a == b;
        }
    }
}
