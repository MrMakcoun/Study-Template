using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using Study.LabWork1.Features.Task1;

namespace Study.LabWork1.UnitTests.Features.Task1
{
    [TestFixture]
    internal class RationalNumberTests
    {
        /// <summary>
        /// Проверка выброса исключения при нулевом знаменателе
        /// </summary>
        [Test]
        public void ZeroDenominator_ThrowsException()
        {
            Assert.Throws<ArgumentException>(() => new RationalNumber(1, 0));
        }

        /// <summary>
        /// Проверка автоматического сокращения дроби
        /// </summary>
        [Test]
        public void Reduce_SimpleFraction()
        {
            var rational = new RationalNumber(5, 10);

            Assert.That(rational.numerator, Is.EqualTo(1));
            Assert.That(rational.denominator, Is.EqualTo(2));
        }

        /// <summary>
        /// Проверка сокращения дроби с большим НОД
        /// </summary>
        [Test]
        public void Reduce_LargeGCD()
        {
            var rational = new RationalNumber(15, 25);

            Assert.That(rational.numerator, Is.EqualTo(3));
            Assert.That(rational.denominator, Is.EqualTo(5));
        }

        /// <summary>
        /// Проверка вывода целого числа при знаменателе равном 1
        /// </summary>
        [Test]
        public void ToString_Integer()
        {
            var rational = new RationalNumber(8, 2);

            Assert.That(rational.ToString(), Is.EqualTo("4"));
        }

        /// <summary>
        /// Проверка вывода нуля
        /// </summary>
        [Test]
        public void ToString_Zero()
        {
            var rational = new RationalNumber(0, 5);

            Assert.That(rational.ToString(), Is.EqualTo("0"));
        }

        /// <summary>
        /// Проверка вывода обычной дроби
        /// </summary>
        [Test]
        public void ToString_Fraction()
        {
            var rational = new RationalNumber(2, 3);

            Assert.That(rational.ToString(), Is.EqualTo("2/3"));
        }

        /// <summary>
        /// Проверка переноса минуса из знаменателя в числитель
        /// </summary>
        [Test]
        public void Negative_MoveToNumerator()
        {
            var rational = new RationalNumber(5, -2);

            Assert.That(rational.numerator, Is.EqualTo(-5));
            Assert.That(rational.denominator, Is.EqualTo(2));
        }

        /// <summary>
        /// Проверка сокращения двух минусов
        /// </summary>
        [Test]
        public void Negative_DoubleNegative()
        {
            var rational = new RationalNumber(-5, -2);

            Assert.That(rational.numerator, Is.EqualTo(5));
            Assert.That(rational.denominator, Is.EqualTo(2));
        }

        /// <summary>
        /// Проверка вывода отрицательной дроби
        /// </summary>
        [Test]
        public void ToString_Negative()
        {
            var rational = new RationalNumber(-5, 2);

            Assert.That(rational.ToString(), Is.EqualTo("-5/2"));
        }

        /// <summary>
        /// Проверка операции сложения
        /// </summary>
        [Test]
        public void Addition_Works()
        {
            var a = new RationalNumber(1, 2);
            var b = new RationalNumber(1, 3);
            var result = a + b;

            Assert.That(result.numerator, Is.EqualTo(5));
            Assert.That(result.denominator, Is.EqualTo(6));
        }

        /// <summary>
        /// Проверка операции вычитания
        /// </summary>
        [Test]
        public void Subtraction_Works()
        {
            var a = new RationalNumber(2, 3);
            var b = new RationalNumber(1, 3);
            var result = a - b;

            Assert.That(result.numerator, Is.EqualTo(1));
            Assert.That(result.denominator, Is.EqualTo(3));
        }

        /// <summary>
        /// Проверка операции умножения
        /// </summary>
        [Test]
        public void Multiplication_Works()
        {
            var a = new RationalNumber(2, 3);
            var b = new RationalNumber(3, 4);
            var result = a * b;

            Assert.That(result.numerator, Is.EqualTo(1));
            Assert.That(result.denominator, Is.EqualTo(2));
        }

        /// <summary>
        /// Проверка операции деления
        /// </summary>
        [Test]
        public void Division_Works()
        {
            var a = new RationalNumber(1, 2);
            var b = new RationalNumber(1, 3);
            var result = a / b;

            Assert.That(result.numerator, Is.EqualTo(3));
            Assert.That(result.denominator, Is.EqualTo(2));
        }

        /// <summary>
        /// Проверка исключения при делении на ноль
        /// </summary>
        [Test]
        public void Division_ByZero()
        {
            var a = new RationalNumber(1, 2);
            var b = new RationalNumber(0, 1);

            Assert.That(() => a / b, Throws.TypeOf<ArgumentException>());
        }

        /// <summary>
        /// Проверка операторов равенства и неравенства
        /// </summary>
        [Test]
        public void Equality_Works()
        {
            var a = new RationalNumber(1, 2);
            var b = new RationalNumber(2, 4);

            Assert.That(a == b, Is.True);
            Assert.That(a != b, Is.False);
        }

        /// <summary>
        /// Проверка операторов сравнения
        /// </summary>
        [Test]
        public void Comparison_Works()
        {
            var smaller = new RationalNumber(1, 3);
            var bigger = new RationalNumber(1, 2);

            Assert.That(smaller < bigger, Is.True);
            Assert.That(bigger > smaller, Is.True);
            Assert.That(smaller <= bigger, Is.True);
            Assert.That(bigger >= smaller, Is.True);
        }

        /// <summary>
        /// Проверка корректной работы с отрицательными числами в операциях
        /// </summary>
        [Test]
        public void Operations_WithNegatives()
        {
            var a = new RationalNumber(-1, 2);
            var b = new RationalNumber(1, 3);
            var result = a + b;

            Assert.That(result.numerator, Is.EqualTo(-1));
            Assert.That(result.denominator, Is.EqualTo(6));
            Assert.That(result.ToString(), Is.EqualTo("-1/6"));
        }
    }
}
