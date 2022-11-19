//18. По двум заданным числам проверять является ли одно квадратом другого.
System.Console.WriteLine("Число 1");
int a=Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Число 2");
int b=Convert.ToInt32(Console.ReadLine());
if (a/b==b || b/a==a)
{
    System.Console.WriteLine("Является");
}     
else
{
    System.Console.WriteLine("Не является");
} 