// 2. Написать программу вычисления произведения чисел от 1 до N

double Factorial(int number)
{
    double result = 1;

    if (number == 0)
    {
        return result;
    }
    for (int i = 2; i <= number; i++)
    {
        result = result * i;
    }

    return result;
}

Console.WriteLine("Введите положительное число для вычисления его факториала");
int number = int.Parse(Console.ReadLine()!);

if (number < 0)
{
    Console.WriteLine("Введено отрицательное число!");
}

else
{
    Console.WriteLine($"Факториал числа {number} равен {Factorial(number)}");
}


