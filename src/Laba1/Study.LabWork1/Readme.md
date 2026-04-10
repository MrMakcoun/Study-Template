<a name='assembly'></a>
# Study.LabWork1

## Contents

- [IRunService](#T-Study-LabWork1-Shared-Abstractions-IRunService 'Study.LabWork1.Shared.Abstractions.IRunService')
  - [RunTask1()](#M-Study-LabWork1-Shared-Abstractions-IRunService-RunTask1 'Study.LabWork1.Shared.Abstractions.IRunService.RunTask1')
  - [RunTask2()](#M-Study-LabWork1-Shared-Abstractions-IRunService-RunTask2 'Study.LabWork1.Shared.Abstractions.IRunService.RunTask2')
  - [RunTask3()](#M-Study-LabWork1-Shared-Abstractions-IRunService-RunTask3 'Study.LabWork1.Shared.Abstractions.IRunService.RunTask3')
- [Program](#T-Study-LabWork1-Program 'Study.LabWork1.Program')
  - [RUN_TASK_NUMBER](#F-Study-LabWork1-Program-RUN_TASK_NUMBER 'Study.LabWork1.Program.RUN_TASK_NUMBER')
  - [Main()](#M-Study-LabWork1-Program-Main 'Study.LabWork1.Program.Main')
- [RationalNumber](#T-Study-LabWork1-Features-Task1-RationalNumber 'Study.LabWork1.Features.Task1.RationalNumber')
  - [#ctor(numerator,denominator)](#M-Study-LabWork1-Features-Task1-RationalNumber-#ctor-System-Int32,System-Int32- 'Study.LabWork1.Features.Task1.RationalNumber.#ctor(System.Int32,System.Int32)')
  - [denominator](#P-Study-LabWork1-Features-Task1-RationalNumber-denominator 'Study.LabWork1.Features.Task1.RationalNumber.denominator')
  - [numerator](#P-Study-LabWork1-Features-Task1-RationalNumber-numerator 'Study.LabWork1.Features.Task1.RationalNumber.numerator')
  - [GCD(numerator,denominator)](#M-Study-LabWork1-Features-Task1-RationalNumber-GCD-System-Int32,System-Int32- 'Study.LabWork1.Features.Task1.RationalNumber.GCD(System.Int32,System.Int32)')
  - [ToString()](#M-Study-LabWork1-Features-Task1-RationalNumber-ToString 'Study.LabWork1.Features.Task1.RationalNumber.ToString')
  - [op_Addition()](#M-Study-LabWork1-Features-Task1-RationalNumber-op_Addition-Study-LabWork1-Features-Task1-RationalNumber,Study-LabWork1-Features-Task1-RationalNumber- 'Study.LabWork1.Features.Task1.RationalNumber.op_Addition(Study.LabWork1.Features.Task1.RationalNumber,Study.LabWork1.Features.Task1.RationalNumber)')
  - [op_Division()](#M-Study-LabWork1-Features-Task1-RationalNumber-op_Division-Study-LabWork1-Features-Task1-RationalNumber,Study-LabWork1-Features-Task1-RationalNumber- 'Study.LabWork1.Features.Task1.RationalNumber.op_Division(Study.LabWork1.Features.Task1.RationalNumber,Study.LabWork1.Features.Task1.RationalNumber)')
  - [op_Equality()](#M-Study-LabWork1-Features-Task1-RationalNumber-op_Equality-Study-LabWork1-Features-Task1-RationalNumber,Study-LabWork1-Features-Task1-RationalNumber- 'Study.LabWork1.Features.Task1.RationalNumber.op_Equality(Study.LabWork1.Features.Task1.RationalNumber,Study.LabWork1.Features.Task1.RationalNumber)')
  - [op_GreaterThan()](#M-Study-LabWork1-Features-Task1-RationalNumber-op_GreaterThan-Study-LabWork1-Features-Task1-RationalNumber,Study-LabWork1-Features-Task1-RationalNumber- 'Study.LabWork1.Features.Task1.RationalNumber.op_GreaterThan(Study.LabWork1.Features.Task1.RationalNumber,Study.LabWork1.Features.Task1.RationalNumber)')
  - [op_GreaterThanOrEqual()](#M-Study-LabWork1-Features-Task1-RationalNumber-op_GreaterThanOrEqual-Study-LabWork1-Features-Task1-RationalNumber,Study-LabWork1-Features-Task1-RationalNumber- 'Study.LabWork1.Features.Task1.RationalNumber.op_GreaterThanOrEqual(Study.LabWork1.Features.Task1.RationalNumber,Study.LabWork1.Features.Task1.RationalNumber)')
  - [op_Inequality()](#M-Study-LabWork1-Features-Task1-RationalNumber-op_Inequality-Study-LabWork1-Features-Task1-RationalNumber,Study-LabWork1-Features-Task1-RationalNumber- 'Study.LabWork1.Features.Task1.RationalNumber.op_Inequality(Study.LabWork1.Features.Task1.RationalNumber,Study.LabWork1.Features.Task1.RationalNumber)')
  - [op_LessThan()](#M-Study-LabWork1-Features-Task1-RationalNumber-op_LessThan-Study-LabWork1-Features-Task1-RationalNumber,Study-LabWork1-Features-Task1-RationalNumber- 'Study.LabWork1.Features.Task1.RationalNumber.op_LessThan(Study.LabWork1.Features.Task1.RationalNumber,Study.LabWork1.Features.Task1.RationalNumber)')
  - [op_LessThanOrEqual()](#M-Study-LabWork1-Features-Task1-RationalNumber-op_LessThanOrEqual-Study-LabWork1-Features-Task1-RationalNumber,Study-LabWork1-Features-Task1-RationalNumber- 'Study.LabWork1.Features.Task1.RationalNumber.op_LessThanOrEqual(Study.LabWork1.Features.Task1.RationalNumber,Study.LabWork1.Features.Task1.RationalNumber)')
  - [op_Multiply()](#M-Study-LabWork1-Features-Task1-RationalNumber-op_Multiply-Study-LabWork1-Features-Task1-RationalNumber,Study-LabWork1-Features-Task1-RationalNumber- 'Study.LabWork1.Features.Task1.RationalNumber.op_Multiply(Study.LabWork1.Features.Task1.RationalNumber,Study.LabWork1.Features.Task1.RationalNumber)')
  - [op_Subtraction()](#M-Study-LabWork1-Features-Task1-RationalNumber-op_Subtraction-Study-LabWork1-Features-Task1-RationalNumber,Study-LabWork1-Features-Task1-RationalNumber- 'Study.LabWork1.Features.Task1.RationalNumber.op_Subtraction(Study.LabWork1.Features.Task1.RationalNumber,Study.LabWork1.Features.Task1.RationalNumber)')
  - [op_UnaryNegation()](#M-Study-LabWork1-Features-Task1-RationalNumber-op_UnaryNegation-Study-LabWork1-Features-Task1-RationalNumber- 'Study.LabWork1.Features.Task1.RationalNumber.op_UnaryNegation(Study.LabWork1.Features.Task1.RationalNumber)')
- [RunService](#T-Study-LabWork1-Shared-Services-RunService 'Study.LabWork1.Shared.Services.RunService')
  - [RunTask1()](#M-Study-LabWork1-Shared-Services-RunService-RunTask1 'Study.LabWork1.Shared.Services.RunService.RunTask1')
  - [RunTask2()](#M-Study-LabWork1-Shared-Services-RunService-RunTask2 'Study.LabWork1.Shared.Services.RunService.RunTask2')
  - [RunTask3()](#M-Study-LabWork1-Shared-Services-RunService-RunTask3 'Study.LabWork1.Shared.Services.RunService.RunTask3')

<a name='T-Study-LabWork1-Shared-Abstractions-IRunService'></a>
## IRunService `type`

##### Namespace

Study.LabWork1.Shared.Abstractions

##### Summary

Интерфейс для реализации заданий Л/Р

<a name='M-Study-LabWork1-Shared-Abstractions-IRunService-RunTask1'></a>
### RunTask1() `method`

##### Summary

Запуск выполнения задания 1

##### Parameters

This method has no parameters.

<a name='M-Study-LabWork1-Shared-Abstractions-IRunService-RunTask2'></a>
### RunTask2() `method`

##### Summary

Запуск выполнения задания 2

##### Parameters

This method has no parameters.

<a name='M-Study-LabWork1-Shared-Abstractions-IRunService-RunTask3'></a>
### RunTask3() `method`

##### Summary

Запуск выполнения задания 3

##### Parameters

This method has no parameters.

<a name='T-Study-LabWork1-Program'></a>
## Program `type`

##### Namespace

Study.LabWork1

##### Summary

Начальная точка входа

<a name='F-Study-LabWork1-Program-RUN_TASK_NUMBER'></a>
### RUN_TASK_NUMBER `constants`

##### Summary

Номер выполняемой задачи

<a name='M-Study-LabWork1-Program-Main'></a>
### Main() `method`

##### Summary

Старт программы

##### Parameters

This method has no parameters.

<a name='T-Study-LabWork1-Features-Task1-RationalNumber'></a>
## RationalNumber `type`

##### Namespace

Study.LabWork1.Features.Task1

##### Summary

Класс, представляющий рациональное число

<a name='M-Study-LabWork1-Features-Task1-RationalNumber-#ctor-System-Int32,System-Int32-'></a>
### #ctor(numerator,denominator) `constructor`

##### Summary

Конструктор класса Rational

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| numerator | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Числитель |
| denominator | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Знаменатель |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') | Выбрасывается, если знаменатель равен 0 |

<a name='P-Study-LabWork1-Features-Task1-RationalNumber-denominator'></a>
### denominator `property`

##### Summary

Знаменатель дроби (только для чтения)

<a name='P-Study-LabWork1-Features-Task1-RationalNumber-numerator'></a>
### numerator `property`

##### Summary

Числитель дроби (только для чтения)

<a name='M-Study-LabWork1-Features-Task1-RationalNumber-GCD-System-Int32,System-Int32-'></a>
### GCD(numerator,denominator) `method`

##### Summary

Нахождение наибольшего общего делителя

##### Returns

Наибольший общий делитель

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| numerator | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Числитель |
| denominator | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Знаменатель |

<a name='M-Study-LabWork1-Features-Task1-RationalNumber-ToString'></a>
### ToString() `method`

##### Summary

Перегрузка метода ToString()

##### Returns

Строковое представление дроби

##### Parameters

This method has no parameters.

<a name='M-Study-LabWork1-Features-Task1-RationalNumber-op_Addition-Study-LabWork1-Features-Task1-RationalNumber,Study-LabWork1-Features-Task1-RationalNumber-'></a>
### op_Addition() `method`

##### Summary

Сложение двух дробей

##### Parameters

This method has no parameters.

<a name='M-Study-LabWork1-Features-Task1-RationalNumber-op_Division-Study-LabWork1-Features-Task1-RationalNumber,Study-LabWork1-Features-Task1-RationalNumber-'></a>
### op_Division() `method`

##### Summary

Деление двух дробей

##### Parameters

This method has no parameters.

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') | Выбрасывается, если появляется деление на 0 |

<a name='M-Study-LabWork1-Features-Task1-RationalNumber-op_Equality-Study-LabWork1-Features-Task1-RationalNumber,Study-LabWork1-Features-Task1-RationalNumber-'></a>
### op_Equality() `method`

##### Summary

Равенство двух дробей

##### Parameters

This method has no parameters.

<a name='M-Study-LabWork1-Features-Task1-RationalNumber-op_GreaterThan-Study-LabWork1-Features-Task1-RationalNumber,Study-LabWork1-Features-Task1-RationalNumber-'></a>
### op_GreaterThan() `method`

##### Summary

Знак больше для сравнения двух дробей

##### Parameters

This method has no parameters.

<a name='M-Study-LabWork1-Features-Task1-RationalNumber-op_GreaterThanOrEqual-Study-LabWork1-Features-Task1-RationalNumber,Study-LabWork1-Features-Task1-RationalNumber-'></a>
### op_GreaterThanOrEqual() `method`

##### Summary

Знак больше или равно для сравнения двух дробей

##### Parameters

This method has no parameters.

<a name='M-Study-LabWork1-Features-Task1-RationalNumber-op_Inequality-Study-LabWork1-Features-Task1-RationalNumber,Study-LabWork1-Features-Task1-RationalNumber-'></a>
### op_Inequality() `method`

##### Summary

Неравенство двух дробей

##### Parameters

This method has no parameters.

<a name='M-Study-LabWork1-Features-Task1-RationalNumber-op_LessThan-Study-LabWork1-Features-Task1-RationalNumber,Study-LabWork1-Features-Task1-RationalNumber-'></a>
### op_LessThan() `method`

##### Summary

Знак меньше для сравнения двух дробей

##### Parameters

This method has no parameters.

<a name='M-Study-LabWork1-Features-Task1-RationalNumber-op_LessThanOrEqual-Study-LabWork1-Features-Task1-RationalNumber,Study-LabWork1-Features-Task1-RationalNumber-'></a>
### op_LessThanOrEqual() `method`

##### Summary

Знак меньше или равно для сравнения двух дробей

##### Parameters

This method has no parameters.

<a name='M-Study-LabWork1-Features-Task1-RationalNumber-op_Multiply-Study-LabWork1-Features-Task1-RationalNumber,Study-LabWork1-Features-Task1-RationalNumber-'></a>
### op_Multiply() `method`

##### Summary

Умножение двух дробей

##### Parameters

This method has no parameters.

<a name='M-Study-LabWork1-Features-Task1-RationalNumber-op_Subtraction-Study-LabWork1-Features-Task1-RationalNumber,Study-LabWork1-Features-Task1-RationalNumber-'></a>
### op_Subtraction() `method`

##### Summary

Вычитание двух дробей

##### Parameters

This method has no parameters.

<a name='M-Study-LabWork1-Features-Task1-RationalNumber-op_UnaryNegation-Study-LabWork1-Features-Task1-RationalNumber-'></a>
### op_UnaryNegation() `method`

##### Summary

Унарный минус

##### Parameters

This method has no parameters.

<a name='T-Study-LabWork1-Shared-Services-RunService'></a>
## RunService `type`

##### Namespace

Study.LabWork1.Shared.Services

##### Summary

Реализация заданий Л/Р

<a name='M-Study-LabWork1-Shared-Services-RunService-RunTask1'></a>
### RunTask1() `method`

##### Summary

Задание 1

##### Parameters

This method has no parameters.

<a name='M-Study-LabWork1-Shared-Services-RunService-RunTask2'></a>
### RunTask2() `method`

##### Summary

Задание 2

##### Parameters

This method has no parameters.

<a name='M-Study-LabWork1-Shared-Services-RunService-RunTask3'></a>
### RunTask3() `method`

##### Summary

Задание 3

##### Parameters

This method has no parameters.
