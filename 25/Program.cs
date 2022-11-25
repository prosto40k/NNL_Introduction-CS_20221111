//25. Вывести на экран кубы чисел от 1 до N
int sqr;
int i=1;
System.Console.WriteLine("Введите N");
int N=Convert.ToInt32(Console.ReadLine());
while (i!=N+1)
{
   sqr=i*i*i;
   i++;
   System.Console.WriteLine(sqr);
}

