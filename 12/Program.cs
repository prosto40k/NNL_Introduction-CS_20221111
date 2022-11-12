// С клавиатуры вводится целое число из  диапазона  [10, 99]. Показать наибольшую цифру числа
System.Console.WriteLine("Введите число");
int a=Convert.ToInt32(Console.ReadLine());

if((a/10%10)>(a%10))
{
    System.Console.WriteLine($"Первое {a/10%10} число");
}
else
{
    System.Console.WriteLine($"Второе число {a%10} больше");
}