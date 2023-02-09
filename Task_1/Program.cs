//1. Подсчитать сумму цифр в числе

Console.Clear();
Console.WriteLine("Введите число для подсчета суммы его цифр:");

int number = int.Parse(Console.ReadLine()!);

int sum = 0;
int tempnumber = number;

while(true)
{
    sum = sum + tempnumber % 10;
    tempnumber = tempnumber / 10;

    if(tempnumber == 0)
    {
        break;
    }
    
}

Console.WriteLine($"Сумма цифр числа {number} равна {sum}");