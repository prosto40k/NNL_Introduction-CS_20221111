// С клавиатуры вводятся два числа a и b. Выяснить, кратно ли число a числу b, если нет, вывести остаток от деления a на b.
System.Console.Write("Ввод а:");
double a=Convert.ToInt32(Console.ReadLine());
System.Console.Write("Ввод b:");
double b=Convert.ToInt32(Console. ReadLine());
if (a%b==0)
{
    System.Console.WriteLine($"Кратно");
}
else
{
    
    System.Console.WriteLine($"{(a/b)%1}");
}