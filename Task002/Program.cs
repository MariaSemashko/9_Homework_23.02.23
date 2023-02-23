/* Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
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

string WriteNubers(int m, int n)
{
    if (n == m) return ($"{m}");
    else 
    {
       return WriteNubers(m, n - 1) + " " + n.ToString();
    }
}

int GetSum(int m, int n)
{
    if (n == m) return n;
    else 
    {
       return n + GetSum(m, n - 1);
    }
}



int m = GetNumber("Введите первое натуральное число:");
int n = GetNumber("Введите второе натуральное число:");
if (n < m) 
{
    int temp = m;
    m = n;
    n = temp;
}

Console.WriteLine ($"Сумма натуральных элементов в промежутке от {m} до {n} равна {GetSum(m, n)}");