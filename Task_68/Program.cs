/*
Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
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
bool ValidNum(int m, int n) => n > 0 && m > 0;

//Вычисления функции Аккермана с помощью рекурсии
int FunctionAckerman(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else
    {
        if ((m != 0) && (n == 0))
        {
            return FunctionAckerman(m - 1, 1);
        }
        else
        {
            return FunctionAckerman(m - 1, FunctionAckerman(m, n - 1));
        }
    }
}

int m = EnterMessage("Введите m : ");
int n = EnterMessage("Введите n : ");

if (ValidNum(m, n))
{
    Console.WriteLine($"M = {m} , N = {n} -> A(m,n) = {FunctionAckerman(m, n)} ");
}
else
{
    Console.WriteLine("Input error, please try again !");
}