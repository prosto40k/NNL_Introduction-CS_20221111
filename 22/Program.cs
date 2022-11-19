// 22. Программа проверяет пятизначное число на палиндромом.
System.Console.WriteLine("Введите пятизначное число");
int a=Convert.ToInt32(Console.ReadLine());
if((a%100) == (a/1000))
{
    System.Console.WriteLine("Является палиндромом");
}
else
{
    System.Console.WriteLine("Не является палиндромом");
}
