/* Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
*/

int GetNumber(string message)
{
    int result = 0;

    while(true)
    {
        Console.WriteLine(message);

        if(int.TryParse(Console.ReadLine(), out result)&& result > 0)
        {
            break;
        }
        else
        {
            Console.WriteLine("Ввели не корректное число. Повторите ввод");
        }
    }

    return result;
}

int Ackermann (int m, int n)
{
    if (m == 0) return n + 1;
    else if (m != 0 && n == 0) 
    {
        return Ackermann(m-1, 1);
    }
    else return Ackermann(m-1, (Ackermann(m,n-1)));
}

int m = GetNumber("Введите первое натуральное число:");
int n = GetNumber("Введите второе натуральное число:");

Console.WriteLine ($"A({m}, {n}) = {Ackermann(m, n)}");