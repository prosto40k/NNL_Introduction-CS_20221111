//16. Дано число. Проверить кратно ли оно 7 и 23
System.Console.WriteLine("Введите число");
int a=Convert.ToInt32(Console.ReadLine());
if (a%7==0 && a%23==0 )
{
    System.Console.WriteLine("Кратно");
}
else
{
    System.Console.WriteLine("Не кратно");
}