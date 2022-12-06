//70. Показать натуральные числа от 1 до N, N задано

int Num(int n=5,int i)
        {
           if (n == i)
                return i;
            else 
                return Num(i+1);
        }

System.Console.WriteLine(Num());