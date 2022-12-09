//71. Показать натуральные числа от N до 1, N задано

void Numb (int n=4)
{
    if (n == 0 || n<0) return;
    Console.WriteLine(n);
    Numb (n - 1); 
}

Numb();