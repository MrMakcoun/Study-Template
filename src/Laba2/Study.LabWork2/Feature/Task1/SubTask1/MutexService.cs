using Study.LabWork2.Abstractions.Feature.Task1.SubTask1;
using Study.LabWork2.Abstractions.Feature.Task1.SubTask1.DtoModels;
using System.Diagnostics;

namespace Study.LabWork2.Feature.Task1.SubTask1
{
    /// <summary>
    /// Реализация подсчёта простых чисел с использованием Mutex
    /// </summary>
    public sealed class MutexService : IPrimeCounter
    {
        private readonly Mutex _mutex = new Mutex();
        private int _PrimeCount;
        private readonly List<int> _FoundPrimes = new();

        /// <summary>
        /// Запускает многопоточный подсчёт простых чисел в заданном диапазоне
        /// </summary>
        /// <param name="start">Начало диапазона</param>
        /// <param name="end">Конец диапазона</param>
        /// <param name="ThreadCount">Количество потоков</param>
        /// <returns>Объект с общим количеством простых чисел, временем выполнения,
        /// количеством потоков, типом синхронизации и списком найденных чисел</returns>
        public PrimeCountResultDto CountPrimes(int start, int end, int ThreadCount)
        {
            _PrimeCount = 0;
            _FoundPrimes.Clear();
            var stopwatch = Stopwatch.StartNew();

            int TotalNumbers = end - start + 1;
            int NumbersPerThread = TotalNumbers / ThreadCount;
            var threads = new List<Thread>();

            for (int i = 0; i < ThreadCount; i++)
            {
                int ThreadStart = start + i * NumbersPerThread;
                int ThreadEnd;
                if (i == ThreadCount - 1)
                    ThreadEnd = end;
                else
                    ThreadEnd = ThreadStart + NumbersPerThread - 1;

                var thread = new Thread(() => CheckPrimesInRange(ThreadStart, ThreadEnd, i + 1));
                threads.Add(thread);
                thread.Start();
            }

            foreach (var thread in threads)
                thread.Join();

            stopwatch.Stop();

            return new PrimeCountResultDto
            {
                PrimeCount = _PrimeCount,
                ExecutionTime = stopwatch.Elapsed,
                ThreadCount = ThreadCount,
                SynchronizationType = GetVersionName(),
                FoundPrimes = new List<int>(_FoundPrimes) // копия, чтобы защитить исходный список
            };
        }

        /// <summary>
        /// Проверяет числа в указанном поддиапазоне на простоту и увеличивает общий счётчик
        /// </summary>
        /// <param name="start">Начало поддиапазона</param>
        /// <param name="end">Конец поддиапазона</param>
        /// <param name="threadId">Условный номер потока для вывода в консоль</param>
        private void CheckPrimesInRange(int start, int end, int threadId)
        {
            for (int number = start; number <= end; number++)
            {
                if (IsPrime(number))
                {
                    _mutex.WaitOne();
                    try
                    {
                        _PrimeCount++;
                        _FoundPrimes.Add(number);
                    }
                    finally
                    {
                        _mutex.ReleaseMutex();
                    }
                }

                if (number % 100 == 0)
                {
                    Console.WriteLine($"[Mutex] Поток {threadId}: обрабатываемое число {number}");
                }
            }
            Console.WriteLine($"[Mutex] Поток {threadId} завершил работу.");
        }

        /// <summary>
        /// Проверяет, является ли число простым
        /// </summary>
        /// <param name="number">Проверяемое число</param>
        /// <returns>true, если число простое, иначе false</returns>
        private static bool IsPrime(int number)
        {
            if (number <= 1) return false;
            if (number == 2) return true;
            if (number % 2 == 0) return false;

            int boundary = (int)Math.Floor(Math.Sqrt(number));
            for (int i = 3; i <= boundary; i += 2)
            {
                if (number % i == 0) return false;
            }
            return true;
        }

        /// <summary>
        /// Возвращает название версии алгоритма синхронизации
        /// </summary>
        /// <returns>Строка "Mutex"</returns>
        public string GetVersionName() => "Mutex";
    }
}
