//26. Найти сумму чисел от 1 до А
double Sum(int N)
{
    double sum=0;
    double x = 1;
    int i =1;
    while (i!=N) 
{
    i++;
    x = x + 0.5;
}
System.Console.WriteLine(i);
System.Console.WriteLine(x);
sum = x * i;
return sum;
}
System.Console.WriteLine("Введите N");
int N=Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine(Sum(N));

