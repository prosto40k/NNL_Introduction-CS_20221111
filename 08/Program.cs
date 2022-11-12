// Вывести на экран числа от -N до N
System.Console.WriteLine("От");
double a=Convert.ToDouble(Console.ReadLine());
System.Console.WriteLine("До");
double b=Convert.ToDouble(Console.ReadLine());
double i=a;
while(i!=b+1)
{
    System.Console.Write($"{i} ");
    i=i+1;
}

