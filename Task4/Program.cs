Console.Write("Введите значение № 1: ");
int num_1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение № 2: ");
int num_2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение № 3: ");
int num_3 = Convert.ToInt32(Console.ReadLine());
        
int max = 0;
int min = 0;
 
    if (num_1 >= num_2 && num_1 >= num_3)
        max = num_1;
    else if (num_2 >= num_1 && num_2 >=num_3 )
        max = num_2;
    else if (num_3 >= num_1 && num_3 >= num_2)
        max = num_3;
 
    if (num_1<= num_2 && num_1 <= num_3)
        min = num_1;
    else if (num_2 <= num_1 && num_2 <= num_3)
        min = num_2;
    else if (num_3 <= num_1 && num_3 <= num_2)
        min = num_3;
 
Console.WriteLine("Максимальное число {0} " , max);
Console.ReadLine();