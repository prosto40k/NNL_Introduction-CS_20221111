//27.  Возведите число А в натуральную степень B используя цикл
System.Console.WriteLine("Введите число А");
int a=Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите число В");
int b=Convert.ToInt32(Console.ReadLine());
int i = 0;
int sqr;
while (i<1) 
{
    sqr=(int)Math.Pow(a,b);
    i++;
    System.Console.WriteLine($"Число {a} в натуральной степени {b} = {sqr}");
}



