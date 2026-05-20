<a name='assembly'></a>
# Study.LabWork2.UnitTests

## Contents

- [MonitorServiceTests](#T-Study-LabWork2-UnitTests-Feature-Task1-SubTask1-MonitorServiceTests 'Study.LabWork2.UnitTests.Feature.Task1.SubTask1.MonitorServiceTests')
  - [CountPrimes_FullRange_1To10000_IsCorrect()](#M-Study-LabWork2-UnitTests-Feature-Task1-SubTask1-MonitorServiceTests-CountPrimes_FullRange_1To10000_IsCorrect 'Study.LabWork2.UnitTests.Feature.Task1.SubTask1.MonitorServiceTests.CountPrimes_FullRange_1To10000_IsCorrect')
  - [CountPrimes_MultipleRuns_ReturnSameResult()](#M-Study-LabWork2-UnitTests-Feature-Task1-SubTask1-MonitorServiceTests-CountPrimes_MultipleRuns_ReturnSameResult 'Study.LabWork2.UnitTests.Feature.Task1.SubTask1.MonitorServiceTests.CountPrimes_MultipleRuns_ReturnSameResult')
  - [CountPrimes_NoCrashes_OnSmallRange()](#M-Study-LabWork2-UnitTests-Feature-Task1-SubTask1-MonitorServiceTests-CountPrimes_NoCrashes_OnSmallRange 'Study.LabWork2.UnitTests.Feature.Task1.SubTask1.MonitorServiceTests.CountPrimes_NoCrashes_OnSmallRange')
  - [CountPrimes_SmallRange_ReturnsCorrectCount()](#M-Study-LabWork2-UnitTests-Feature-Task1-SubTask1-MonitorServiceTests-CountPrimes_SmallRange_ReturnsCorrectCount 'Study.LabWork2.UnitTests.Feature.Task1.SubTask1.MonitorServiceTests.CountPrimes_SmallRange_ReturnsCorrectCount')
  - [Setup()](#M-Study-LabWork2-UnitTests-Feature-Task1-SubTask1-MonitorServiceTests-Setup 'Study.LabWork2.UnitTests.Feature.Task1.SubTask1.MonitorServiceTests.Setup')
- [MutexServiceTests](#T-Study-LabWork2-UnitTests-Feature-Task1-SubTask1-MutexServiceTests 'Study.LabWork2.UnitTests.Feature.Task1.SubTask1.MutexServiceTests')
  - [CountPrimes_FullRange_1To10000_IsCorrect()](#M-Study-LabWork2-UnitTests-Feature-Task1-SubTask1-MutexServiceTests-CountPrimes_FullRange_1To10000_IsCorrect 'Study.LabWork2.UnitTests.Feature.Task1.SubTask1.MutexServiceTests.CountPrimes_FullRange_1To10000_IsCorrect')
  - [CountPrimes_MultipleRuns_ReturnSameResult()](#M-Study-LabWork2-UnitTests-Feature-Task1-SubTask1-MutexServiceTests-CountPrimes_MultipleRuns_ReturnSameResult 'Study.LabWork2.UnitTests.Feature.Task1.SubTask1.MutexServiceTests.CountPrimes_MultipleRuns_ReturnSameResult')
  - [CountPrimes_NoCrashes_OnSmallRange()](#M-Study-LabWork2-UnitTests-Feature-Task1-SubTask1-MutexServiceTests-CountPrimes_NoCrashes_OnSmallRange 'Study.LabWork2.UnitTests.Feature.Task1.SubTask1.MutexServiceTests.CountPrimes_NoCrashes_OnSmallRange')
  - [CountPrimes_SmallRange_ReturnsCorrectCount()](#M-Study-LabWork2-UnitTests-Feature-Task1-SubTask1-MutexServiceTests-CountPrimes_SmallRange_ReturnsCorrectCount 'Study.LabWork2.UnitTests.Feature.Task1.SubTask1.MutexServiceTests.CountPrimes_SmallRange_ReturnsCorrectCount')
  - [Setup()](#M-Study-LabWork2-UnitTests-Feature-Task1-SubTask1-MutexServiceTests-Setup 'Study.LabWork2.UnitTests.Feature.Task1.SubTask1.MutexServiceTests.Setup')
- [SemaphoreServiceTests](#T-Study-LabWork2-UnitTests-Feature-Task1-SubTask1-SemaphoreServiceTests 'Study.LabWork2.UnitTests.Feature.Task1.SubTask1.SemaphoreServiceTests')
  - [CountPrimes_FullRange_1To10000_IsCorrect()](#M-Study-LabWork2-UnitTests-Feature-Task1-SubTask1-SemaphoreServiceTests-CountPrimes_FullRange_1To10000_IsCorrect 'Study.LabWork2.UnitTests.Feature.Task1.SubTask1.SemaphoreServiceTests.CountPrimes_FullRange_1To10000_IsCorrect')
  - [CountPrimes_MultipleRuns_ReturnSameResult()](#M-Study-LabWork2-UnitTests-Feature-Task1-SubTask1-SemaphoreServiceTests-CountPrimes_MultipleRuns_ReturnSameResult 'Study.LabWork2.UnitTests.Feature.Task1.SubTask1.SemaphoreServiceTests.CountPrimes_MultipleRuns_ReturnSameResult')
  - [CountPrimes_NoCrashes_OnSmallRange()](#M-Study-LabWork2-UnitTests-Feature-Task1-SubTask1-SemaphoreServiceTests-CountPrimes_NoCrashes_OnSmallRange 'Study.LabWork2.UnitTests.Feature.Task1.SubTask1.SemaphoreServiceTests.CountPrimes_NoCrashes_OnSmallRange')
  - [CountPrimes_SmallRange_ReturnsCorrectCount()](#M-Study-LabWork2-UnitTests-Feature-Task1-SubTask1-SemaphoreServiceTests-CountPrimes_SmallRange_ReturnsCorrectCount 'Study.LabWork2.UnitTests.Feature.Task1.SubTask1.SemaphoreServiceTests.CountPrimes_SmallRange_ReturnsCorrectCount')
  - [Setup()](#M-Study-LabWork2-UnitTests-Feature-Task1-SubTask1-SemaphoreServiceTests-Setup 'Study.LabWork2.UnitTests.Feature.Task1.SubTask1.SemaphoreServiceTests.Setup')

<a name='T-Study-LabWork2-UnitTests-Feature-Task1-SubTask1-MonitorServiceTests'></a>
## MonitorServiceTests `type`

##### Namespace

Study.LabWork2.UnitTests.Feature.Task1.SubTask1

##### Summary

Тесты для программы подсчёта простых чисел с использованием Monitor (lock)

<a name='M-Study-LabWork2-UnitTests-Feature-Task1-SubTask1-MonitorServiceTests-CountPrimes_FullRange_1To10000_IsCorrect'></a>
### CountPrimes_FullRange_1To10000_IsCorrect() `method`

##### Summary

Проверка на диапазоне задачи – контрольный результат 1229

##### Parameters

This method has no parameters.

<a name='M-Study-LabWork2-UnitTests-Feature-Task1-SubTask1-MonitorServiceTests-CountPrimes_MultipleRuns_ReturnSameResult'></a>
### CountPrimes_MultipleRuns_ReturnSameResult() `method`

##### Summary

Многопоточность не должна влиять на итог – повторные запуски дают одинаковое количество

##### Parameters

This method has no parameters.

<a name='M-Study-LabWork2-UnitTests-Feature-Task1-SubTask1-MonitorServiceTests-CountPrimes_NoCrashes_OnSmallRange'></a>
### CountPrimes_NoCrashes_OnSmallRange() `method`

##### Summary

Тест на отсутствие исключений на минимальном диапазоне

##### Parameters

This method has no parameters.

<a name='M-Study-LabWork2-UnitTests-Feature-Task1-SubTask1-MonitorServiceTests-CountPrimes_SmallRange_ReturnsCorrectCount'></a>
### CountPrimes_SmallRange_ReturnsCorrectCount() `method`

##### Summary

Проверяем базовую корректность на маленьком диапазоне – ожидается 25 простых чисел

##### Parameters

This method has no parameters.

<a name='M-Study-LabWork2-UnitTests-Feature-Task1-SubTask1-MonitorServiceTests-Setup'></a>
### Setup() `method`

##### Summary

Создаём конкретную реализацию Monitor (lock)

##### Parameters

This method has no parameters.

<a name='T-Study-LabWork2-UnitTests-Feature-Task1-SubTask1-MutexServiceTests'></a>
## MutexServiceTests `type`

##### Namespace

Study.LabWork2.UnitTests.Feature.Task1.SubTask1

##### Summary

Тесты для программы подсчёта простых чисел с использованием Mutex

<a name='M-Study-LabWork2-UnitTests-Feature-Task1-SubTask1-MutexServiceTests-CountPrimes_FullRange_1To10000_IsCorrect'></a>
### CountPrimes_FullRange_1To10000_IsCorrect() `method`

##### Summary

Проверка на диапазоне задачи – контрольный результат 1229

##### Parameters

This method has no parameters.

<a name='M-Study-LabWork2-UnitTests-Feature-Task1-SubTask1-MutexServiceTests-CountPrimes_MultipleRuns_ReturnSameResult'></a>
### CountPrimes_MultipleRuns_ReturnSameResult() `method`

##### Summary

Многопоточность не должна влиять на итог – повторные запуски дают одинаковое количество

##### Parameters

This method has no parameters.

<a name='M-Study-LabWork2-UnitTests-Feature-Task1-SubTask1-MutexServiceTests-CountPrimes_NoCrashes_OnSmallRange'></a>
### CountPrimes_NoCrashes_OnSmallRange() `method`

##### Summary

Тест на отсутствие исключений на минимальном диапазоне

##### Parameters

This method has no parameters.

<a name='M-Study-LabWork2-UnitTests-Feature-Task1-SubTask1-MutexServiceTests-CountPrimes_SmallRange_ReturnsCorrectCount'></a>
### CountPrimes_SmallRange_ReturnsCorrectCount() `method`

##### Summary

Проверяем базовую корректность на маленьком диапазоне – ожидается 25 простых чисел

##### Parameters

This method has no parameters.

<a name='M-Study-LabWork2-UnitTests-Feature-Task1-SubTask1-MutexServiceTests-Setup'></a>
### Setup() `method`

##### Summary

Создаём конкретную реализацию Mutex

##### Parameters

This method has no parameters.

<a name='T-Study-LabWork2-UnitTests-Feature-Task1-SubTask1-SemaphoreServiceTests'></a>
## SemaphoreServiceTests `type`

##### Namespace

Study.LabWork2.UnitTests.Feature.Task1.SubTask1

##### Summary

Тесты для программы подсчёта простых чисел с использованием Semaphore

<a name='M-Study-LabWork2-UnitTests-Feature-Task1-SubTask1-SemaphoreServiceTests-CountPrimes_FullRange_1To10000_IsCorrect'></a>
### CountPrimes_FullRange_1To10000_IsCorrect() `method`

##### Summary

Проверка на диапазоне задачи – контрольный результат 1229

##### Parameters

This method has no parameters.

<a name='M-Study-LabWork2-UnitTests-Feature-Task1-SubTask1-SemaphoreServiceTests-CountPrimes_MultipleRuns_ReturnSameResult'></a>
### CountPrimes_MultipleRuns_ReturnSameResult() `method`

##### Summary

Многопоточность не должна влиять на итог – повторные запуски дают одинаковое количество

##### Parameters

This method has no parameters.

<a name='M-Study-LabWork2-UnitTests-Feature-Task1-SubTask1-SemaphoreServiceTests-CountPrimes_NoCrashes_OnSmallRange'></a>
### CountPrimes_NoCrashes_OnSmallRange() `method`

##### Summary

Тест на отсутствие исключений на минимальном диапазоне

##### Parameters

This method has no parameters.

<a name='M-Study-LabWork2-UnitTests-Feature-Task1-SubTask1-SemaphoreServiceTests-CountPrimes_SmallRange_ReturnsCorrectCount'></a>
### CountPrimes_SmallRange_ReturnsCorrectCount() `method`

##### Summary

Проверяем базовую корректность на маленьком диапазоне – ожидается 25 простых чисел

##### Parameters

This method has no parameters.

<a name='M-Study-LabWork2-UnitTests-Feature-Task1-SubTask1-SemaphoreServiceTests-Setup'></a>
### Setup() `method`

##### Summary

Создаём конкретную реализацию Semaphore

##### Parameters

This method has no parameters.
