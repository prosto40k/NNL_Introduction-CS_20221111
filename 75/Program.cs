﻿//75. Написать программу вычисления функции Аккермана 

int A (int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    } 
    
    if (m != 0 && n == 0) 
    {
        return A(m - 1, 1);
    }
    
    if (m > 0 && n > 0) 
    {
        return A(m - 1, Ack(m, n - 1));
    }
return A(m, n);
}

Console.WriteLine($"{A(3,3)}");