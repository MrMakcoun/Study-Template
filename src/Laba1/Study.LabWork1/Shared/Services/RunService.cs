using Study.LabWork1.Features.Task1;
using Study.LabWork1.Shared.Abstractions;

namespace Study.LabWork1.Shared.Services;

/// <summary>
/// Реализация заданий Л/Р
/// </summary>
public class RunService : IRunService
{
    /// <summary>
    /// Задание 1
    /// </summary>
    public void RunTask1()
    {
        Console.Write("Введите числитель: ");
        int a = Convert.ToInt32(Console.ReadLine());

        Console.Write("Введите знаменатель: ");
        int b = Convert.ToInt32(Console.ReadLine());

        var number = new RationalNumber(a, b);
        Console.WriteLine($"Число: {number}");
    }

    /// <summary>
    /// Задание 2
    /// </summary>
    public void RunTask2() => throw new NotImplementedException();

    /// <summary>
    /// Задание 3
    /// </summary>
    public void RunTask3() => throw new NotImplementedException();
}
