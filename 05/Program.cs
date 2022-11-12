//С клавиатуры вводятся три числа. Найти максимальное из трех чисел
System.Console.WriteLine("Введите число a:");
double a=Convert.ToDouble(Console.ReadLine());
System.Console.WriteLine("Введите число b:");
double b=Convert.ToDouble(Console.ReadLine());
System.Console.WriteLine("Введите число c:");
double c=Convert.ToDouble(Console.ReadLine());
if(a>b)
{
    System.Console.WriteLine($"Число а={a}больше");
}
else
{
    if(b>c)
{
    System.Console.WriteLine($"Число b={b}больше");
}
else
{
    if(a>c)
{
    System.Console.WriteLine($"Число а={a}больше");
}
else
{
    System.Console.WriteLine($"Число c={c}больше");
}

}
}

