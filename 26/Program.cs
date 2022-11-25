//26. Найти сумму чисел от 1 до А
double sum;
double x = 1;
int i =1;
System.Console.WriteLine("Введите N");
int N=Convert.ToInt32(Console.ReadLine());
while (i!=N) 
{
   i++;
   x = x + 0.5;
  
}

sum = x * i;
System.Console.WriteLine($"Сумма чисел от 1 до {N} = {sum}");

