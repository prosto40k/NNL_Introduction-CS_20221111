//30. Написать программу вычисления произведения чисел от 1 до N

double sum=1;
int i =2;
int i1=1;
double sqr;
System.Console.WriteLine("Введите N");
int N=Convert.ToInt32(Console.ReadLine());
while (i1!=N) 
{
   sum=sum*i;
    i++;
    i1++;
System.Console.WriteLine(sum);
}
sqr=sum;
System.Console.WriteLine($"Произведение чисел от 1 до {N} = {sum}");
