//27.  Возведите число А в натуральную степень B используя цикл
int Sqr(int a, int b)
{
    int i = 0;
    int sqr=0;
while (i<1) 
{
    sqr=(int)Math.Pow(a,b);
    i++;
}
return sqr;
}
System.Console.WriteLine("Введите число А");
int a=Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите число В");
int b=Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine(Sqr(a,b));





