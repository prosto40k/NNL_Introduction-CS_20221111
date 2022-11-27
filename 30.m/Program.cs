//30. Написать программу вычисления произведения чисел от 1 до N
double Sum(int N)
{
double sum=1;
int i =2;
int i1=1;
while (i1!=N) 
{
   sum=sum*i;
    i++;
    i1++;
}
return sum;
}
System.Console.WriteLine("Введите N");
int N=Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine(Sum(N));
