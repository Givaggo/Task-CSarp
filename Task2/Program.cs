Console.Write("Введите значение № 1: ");
int num_1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение № 2: ");
int num_2 = Convert.ToInt32(Console.ReadLine());


if (num_1 > num_2)
{
    Console.WriteLine($"{num_1} больше {num_2}");
}
else
{
    Console.WriteLine($"{num_2} больше {num_1}");
}
if (num_1 == num_2)
{
    Console.WriteLine("Значения равны");
}
