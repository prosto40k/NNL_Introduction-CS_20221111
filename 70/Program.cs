//70. Показать натуральные числа от 1 до N, N задано

void Numb (int n=4)
{
    if (n == 0 || n<0) return;
    Numb (n - 1);
    Console.WriteLine(n);
}

Numb();