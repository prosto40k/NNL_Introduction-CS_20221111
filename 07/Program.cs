//Выяснить является ли число чётным.
System.Console.WriteLine("Введите число:");
double a=Convert.ToDouble(Console.ReadLine());
if(a%2==0)
{
    System.Console.WriteLine($"число {a} является четным:");
}
else
{
    System.Console.WriteLine($"число {a} является не четным:");
}
