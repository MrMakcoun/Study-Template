using Study.LabWork2.Abstractions.Feature.Task1.SubTask1;
using Study.LabWork2.Feature.Task1.SubTask1;

namespace Study.LabWork2.UnitTests.Feature.Task1.SubTask1
{
    /// <summary>
    /// Тесты для программы подсчёта простых чисел с использованием Monitor (lock)
    /// </summary>
    [TestFixture]
    public sealed class MonitorServiceTests
    {
        private IPrimeCounter _service;

        /// <summary>
        /// Создаём конкретную реализацию Monitor (lock)
        /// </summary>
        [SetUp]
        public void Setup()
        {
            _service = new MonitorService();
        }

        /// <summary>
        /// Проверяем базовую корректность на маленьком диапазоне – ожидается 25 простых чисел
        /// </summary>
        [Test]
        public void CountPrimes_SmallRange_ReturnsCorrectCount()
        {
            var result = _service.CountPrimes(1, 100, 4);
            Assert.That(result.PrimeCount, Is.EqualTo(25));
        }

        /// <summary>
        /// Проверка на диапазоне задачи – контрольный результат 1229
        /// </summary>
        [Test]
        public void CountPrimes_FullRange_1To10000_IsCorrect()
        {
            var result = _service.CountPrimes(1, 10000, 4);
            Assert.That(result.PrimeCount, Is.EqualTo(1229));
        }

        /// <summary>
        /// Многопоточность не должна влиять на итог – повторные запуски дают одинаковое количество
        /// </summary>
        [Test]
        public void CountPrimes_MultipleRuns_ReturnSameResult()
        {
            var r1 = _service.CountPrimes(1, 1000, 4);
            var r2 = _service.CountPrimes(1, 1000, 4);
            Assert.That(r1.PrimeCount, Is.EqualTo(r2.PrimeCount));
        }

        /// <summary>
        /// Тест на отсутствие исключений на минимальном диапазоне
        /// </summary>
        [Test]
        public void CountPrimes_NoCrashes_OnSmallRange()
        {
            Assert.DoesNotThrow(() =>
                _service.CountPrimes(1, 10, 2)
            );
        }
    }
}
