/* 
Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/

Console.Clear();

//Ввод числа
int EnterMessage(string message)
{
    Console.Write(message);
    int number = int.Parse(Console.ReadLine());
    return number;
}

//Проверка числа
bool ValidNum(int num) => num > 0;

//Вывод чисел рекурсией
string ReturnNumber(int enterNum)
{
    if (enterNum >= 1)
    {
        return $"{enterNum} " + ReturnNumber(enterNum - 1);
    }
    else
    {
        return String.Empty;
    }
}

int num = EnterMessage("Введите число : ");

if (ValidNum(num))
{
    Console.WriteLine(ReturnNumber(num));
}
else
{
    Console.WriteLine("Input error, please try again !");
}
