// С клавиатуры вводится целое число. Вывести третью цифру числа или сообщить, что её нет (Вывести: NO)
System.Console.Write("Ввод числа:");
int a=Convert.ToInt32(Console.ReadLine());
int i=99,i1=999,i2=9999;

if(a>i2)
{
  System.Console.WriteLine(a/100%10);
}
  else
  {
    if(a>i1)
    {
        System.Console.WriteLine(a/10%10);
    }
    else
    {
if(a>i)
{
    System.Console.WriteLine(a%10);
}
else
{
    System.Console.WriteLine("no");
}
    }
  }

