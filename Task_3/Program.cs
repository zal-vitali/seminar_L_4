// 3. Показать кубы чисел, заканчивающихся на четную цифру
// неясно, что делать. Выведем чётные кубы с 1 по N

Console.Clear();
Console.WriteLine("Получим последовательность чётных кубов чисел от 1 до N. Введите число N:");

int numbern = int.Parse(Console.ReadLine()!);

if (numbern == 1)
{
    Console.WriteLine("Чётных кубов нет");
}

else
{
    for (int i = 2; i <= numbern; i += 2)
    {
        int i3 = i * i * i;

        Console.Write(i3);

        if (i < (numbern - 1))
        {
            Console.Write(", ");
        }

        else
        {
            Console.WriteLine("");
        }
    }
}