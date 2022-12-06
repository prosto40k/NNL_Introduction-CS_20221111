//70. Показать натуральные числа от 1 до N, N задано

int Num(int n=4,int i=1)
        {
           if (n == i)
                return i;
            else 
                return Num(i+i)
        }

Num();