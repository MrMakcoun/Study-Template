using Study.LabWork2.Abstractions.Feature.Task1.SubTask1;
using Study.LabWork2.Feature.Task1.SubTask1;

namespace Study.LabWork2;

public static class Program
{
    /// <summary>
    /// Запускает три версии подсчета простых чисел (с использованием Monitor, Mutex и Semaphore) и выводит результаты в консоль
    /// </summary>
    public static void Main()
    {
        IPrimeCounter monitorCounter = new MonitorService();
        IPrimeCounter mutexCounter = new MutexService();
        IPrimeCounter semaphoreCounter = new SemaphoreService();

        var resultMonitor = monitorCounter.CountPrimes(1, 10000, 4);
        Console.WriteLine();
        var resultMutex = mutexCounter.CountPrimes(1, 10000, 4);
        Console.WriteLine();
        var resultSemaphore = semaphoreCounter.CountPrimes(1, 10000, 4);
        Console.WriteLine();

        Console.WriteLine(resultMonitor.ToString() + "\n");
        Console.WriteLine(resultMutex.ToString() + "\n");
        Console.WriteLine(resultSemaphore.ToString() + "\n");
    }
}
