<a name='assembly'></a>
# Study.LabWork2

## Contents

- [AsynchronousServerRequestApp](#T-Study-LabWork2-Feature-Task2-AsynchronousServerRequestApp 'Study.LabWork2.Feature.Task2.AsynchronousServerRequestApp')
  - [ExecuteRequestsAsync\`\`1()](#M-Study-LabWork2-Feature-Task2-AsynchronousServerRequestApp-ExecuteRequestsAsync``1-Study-LabWork2-Abstractions-Feature-Task2-DtoModels-ServerConfigDto[]- 'Study.LabWork2.Feature.Task2.AsynchronousServerRequestApp.ExecuteRequestsAsync``1(Study.LabWork2.Abstractions.Feature.Task2.DtoModels.ServerConfigDto[])')
- [MonitorService](#T-Study-LabWork2-Feature-Task1-SubTask1-MonitorService 'Study.LabWork2.Feature.Task1.SubTask1.MonitorService')
  - [CheckPrimesInRange(start,end,threadId)](#M-Study-LabWork2-Feature-Task1-SubTask1-MonitorService-CheckPrimesInRange-System-Int32,System-Int32,System-Int32- 'Study.LabWork2.Feature.Task1.SubTask1.MonitorService.CheckPrimesInRange(System.Int32,System.Int32,System.Int32)')
  - [CountPrimes(start,end,ThreadCount)](#M-Study-LabWork2-Feature-Task1-SubTask1-MonitorService-CountPrimes-System-Int32,System-Int32,System-Int32- 'Study.LabWork2.Feature.Task1.SubTask1.MonitorService.CountPrimes(System.Int32,System.Int32,System.Int32)')
  - [GetVersionName()](#M-Study-LabWork2-Feature-Task1-SubTask1-MonitorService-GetVersionName 'Study.LabWork2.Feature.Task1.SubTask1.MonitorService.GetVersionName')
  - [IsPrime(number)](#M-Study-LabWork2-Feature-Task1-SubTask1-MonitorService-IsPrime-System-Int32- 'Study.LabWork2.Feature.Task1.SubTask1.MonitorService.IsPrime(System.Int32)')
- [MutexService](#T-Study-LabWork2-Feature-Task1-SubTask1-MutexService 'Study.LabWork2.Feature.Task1.SubTask1.MutexService')
  - [CheckPrimesInRange(start,end,threadId)](#M-Study-LabWork2-Feature-Task1-SubTask1-MutexService-CheckPrimesInRange-System-Int32,System-Int32,System-Int32- 'Study.LabWork2.Feature.Task1.SubTask1.MutexService.CheckPrimesInRange(System.Int32,System.Int32,System.Int32)')
  - [CountPrimes(start,end,ThreadCount)](#M-Study-LabWork2-Feature-Task1-SubTask1-MutexService-CountPrimes-System-Int32,System-Int32,System-Int32- 'Study.LabWork2.Feature.Task1.SubTask1.MutexService.CountPrimes(System.Int32,System.Int32,System.Int32)')
  - [GetVersionName()](#M-Study-LabWork2-Feature-Task1-SubTask1-MutexService-GetVersionName 'Study.LabWork2.Feature.Task1.SubTask1.MutexService.GetVersionName')
  - [IsPrime(number)](#M-Study-LabWork2-Feature-Task1-SubTask1-MutexService-IsPrime-System-Int32- 'Study.LabWork2.Feature.Task1.SubTask1.MutexService.IsPrime(System.Int32)')
- [NumberSetProcessor](#T-Study-LabWork2-Feature-Task1-SubTask2-NumberSetProcessor 'Study.LabWork2.Feature.Task1.SubTask2.NumberSetProcessor')
- [Program](#T-Study-LabWork2-Program 'Study.LabWork2.Program')
  - [Main()](#M-Study-LabWork2-Program-Main 'Study.LabWork2.Program.Main')
- [SemaphoreService](#T-Study-LabWork2-Feature-Task1-SubTask1-SemaphoreService 'Study.LabWork2.Feature.Task1.SubTask1.SemaphoreService')
  - [CheckPrimesInRange(start,end,threadId)](#M-Study-LabWork2-Feature-Task1-SubTask1-SemaphoreService-CheckPrimesInRange-System-Int32,System-Int32,System-Int32- 'Study.LabWork2.Feature.Task1.SubTask1.SemaphoreService.CheckPrimesInRange(System.Int32,System.Int32,System.Int32)')
  - [CountPrimes(start,end,ThreadCount)](#M-Study-LabWork2-Feature-Task1-SubTask1-SemaphoreService-CountPrimes-System-Int32,System-Int32,System-Int32- 'Study.LabWork2.Feature.Task1.SubTask1.SemaphoreService.CountPrimes(System.Int32,System.Int32,System.Int32)')
  - [GetVersionName()](#M-Study-LabWork2-Feature-Task1-SubTask1-SemaphoreService-GetVersionName 'Study.LabWork2.Feature.Task1.SubTask1.SemaphoreService.GetVersionName')
  - [IsPrime(number)](#M-Study-LabWork2-Feature-Task1-SubTask1-SemaphoreService-IsPrime-System-Int32- 'Study.LabWork2.Feature.Task1.SubTask1.SemaphoreService.IsPrime(System.Int32)')
- [SynchronousServerRequestApp](#T-Study-LabWork2-Feature-Task2-SynchronousServerRequestApp 'Study.LabWork2.Feature.Task2.SynchronousServerRequestApp')

<a name='T-Study-LabWork2-Feature-Task2-AsynchronousServerRequestApp'></a>
## AsynchronousServerRequestApp `type`

##### Namespace

Study.LabWork2.Feature.Task2

##### Summary

Асинхронная версия приложения (с использованием async/await)

<a name='M-Study-LabWork2-Feature-Task2-AsynchronousServerRequestApp-ExecuteRequestsAsync``1-Study-LabWork2-Abstractions-Feature-Task2-DtoModels-ServerConfigDto[]-'></a>
### ExecuteRequestsAsync\`\`1() `method`

##### Summary

Асинхронное выполнение запросов

##### Parameters

This method has no parameters.

<a name='T-Study-LabWork2-Feature-Task1-SubTask1-MonitorService'></a>
## MonitorService `type`

##### Namespace

Study.LabWork2.Feature.Task1.SubTask1

##### Summary

Реализация подсчёта простых чисел с использованием Monitor (lock)

<a name='M-Study-LabWork2-Feature-Task1-SubTask1-MonitorService-CheckPrimesInRange-System-Int32,System-Int32,System-Int32-'></a>
### CheckPrimesInRange(start,end,threadId) `method`

##### Summary

Проверяет числа в указанном поддиапазоне на простоту и увеличивает общий счётчик

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| start | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Начало поддиапазона |
| end | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Конец поддиапазона |
| threadId | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Условный номер потока для вывода в консоль |

<a name='M-Study-LabWork2-Feature-Task1-SubTask1-MonitorService-CountPrimes-System-Int32,System-Int32,System-Int32-'></a>
### CountPrimes(start,end,ThreadCount) `method`

##### Summary

Запускает многопоточный подсчёт простых чисел в заданном диапазоне

##### Returns

Объект с общим количеством простых чисел, временем выполнения,
количеством потоков, типом синхронизации и списком найденных чисел

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| start | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Начало диапазона |
| end | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Конец диапазона |
| ThreadCount | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Количество потоков |

<a name='M-Study-LabWork2-Feature-Task1-SubTask1-MonitorService-GetVersionName'></a>
### GetVersionName() `method`

##### Summary

Возвращает название версии алгоритма синхронизации

##### Returns

Строка "Monitor (lock)"

##### Parameters

This method has no parameters.

<a name='M-Study-LabWork2-Feature-Task1-SubTask1-MonitorService-IsPrime-System-Int32-'></a>
### IsPrime(number) `method`

##### Summary

Проверяет, является ли число простым

##### Returns

true, если число простое, иначе false

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| number | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Проверяемое число |

<a name='T-Study-LabWork2-Feature-Task1-SubTask1-MutexService'></a>
## MutexService `type`

##### Namespace

Study.LabWork2.Feature.Task1.SubTask1

##### Summary

Реализация подсчёта простых чисел с использованием Mutex

<a name='M-Study-LabWork2-Feature-Task1-SubTask1-MutexService-CheckPrimesInRange-System-Int32,System-Int32,System-Int32-'></a>
### CheckPrimesInRange(start,end,threadId) `method`

##### Summary

Проверяет числа в указанном поддиапазоне на простоту и увеличивает общий счётчик

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| start | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Начало поддиапазона |
| end | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Конец поддиапазона |
| threadId | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Условный номер потока для вывода в консоль |

<a name='M-Study-LabWork2-Feature-Task1-SubTask1-MutexService-CountPrimes-System-Int32,System-Int32,System-Int32-'></a>
### CountPrimes(start,end,ThreadCount) `method`

##### Summary

Запускает многопоточный подсчёт простых чисел в заданном диапазоне

##### Returns

Объект с общим количеством простых чисел, временем выполнения,
количеством потоков, типом синхронизации и списком найденных чисел

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| start | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Начало диапазона |
| end | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Конец диапазона |
| ThreadCount | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Количество потоков |

<a name='M-Study-LabWork2-Feature-Task1-SubTask1-MutexService-GetVersionName'></a>
### GetVersionName() `method`

##### Summary

Возвращает название версии алгоритма синхронизации

##### Returns

Строка "Mutex"

##### Parameters

This method has no parameters.

<a name='M-Study-LabWork2-Feature-Task1-SubTask1-MutexService-IsPrime-System-Int32-'></a>
### IsPrime(number) `method`

##### Summary

Проверяет, является ли число простым

##### Returns

true, если число простое, иначе false

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| number | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Проверяемое число |

<a name='T-Study-LabWork2-Feature-Task1-SubTask2-NumberSetProcessor'></a>
## NumberSetProcessor `type`

##### Namespace

Study.LabWork2.Feature.Task1.SubTask2

##### Summary

Определяет реализацию для процессора наборов чисел

<a name='T-Study-LabWork2-Program'></a>
## Program `type`

##### Namespace

Study.LabWork2

<a name='M-Study-LabWork2-Program-Main'></a>
### Main() `method`

##### Summary

Запускает три версии подсчета простых чисел (с использованием Monitor, Mutex и Semaphore) и выводит результаты в консоль

##### Parameters

This method has no parameters.

<a name='T-Study-LabWork2-Feature-Task1-SubTask1-SemaphoreService'></a>
## SemaphoreService `type`

##### Namespace

Study.LabWork2.Feature.Task1.SubTask1

##### Summary

Реализация подсчёта простых чисел с использованием Semaphore

<a name='M-Study-LabWork2-Feature-Task1-SubTask1-SemaphoreService-CheckPrimesInRange-System-Int32,System-Int32,System-Int32-'></a>
### CheckPrimesInRange(start,end,threadId) `method`

##### Summary

Проверяет числа в указанном поддиапазоне на простоту и увеличивает общий счётчик

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| start | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Начало поддиапазона |
| end | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Конец поддиапазона |
| threadId | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Условный номер потока для вывода в консоль |

<a name='M-Study-LabWork2-Feature-Task1-SubTask1-SemaphoreService-CountPrimes-System-Int32,System-Int32,System-Int32-'></a>
### CountPrimes(start,end,ThreadCount) `method`

##### Summary

Запускает многопоточный подсчёт простых чисел в заданном диапазоне

##### Returns

Объект с общим количеством простых чисел, временем выполнения,
количеством потоков, типом синхронизации и списком найденных чисел

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| start | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Начало диапазона |
| end | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Конец диапазона |
| ThreadCount | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Количество потоков |

<a name='M-Study-LabWork2-Feature-Task1-SubTask1-SemaphoreService-GetVersionName'></a>
### GetVersionName() `method`

##### Summary

Возвращает название версии алгоритма синхронизации

##### Returns

Строка "Semaphore"

##### Parameters

This method has no parameters.

<a name='M-Study-LabWork2-Feature-Task1-SubTask1-SemaphoreService-IsPrime-System-Int32-'></a>
### IsPrime(number) `method`

##### Summary

Проверяет, является ли число простым

##### Returns

true, если число простое, иначе false

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| number | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Проверяемое число |

<a name='T-Study-LabWork2-Feature-Task2-SynchronousServerRequestApp'></a>
## SynchronousServerRequestApp `type`

##### Namespace

Study.LabWork2.Feature.Task2

##### Summary

Синхронная версия приложения (без использования async/await)
