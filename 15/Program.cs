// С клавиатуры вводится целое число. Вывести третью цифру числа или сообщить, что её нет (Вывести: NO)
System.Console.Write("Ввод числа:");
int a=Convert.ToInt32(Console.ReadLine());
int i=0;
while (i!=a)
{
  i++;
}

if(i>9999)
{
  System.Console.WriteLine(a/100%10);
}
  else
  {
    if(i>999)
    {
        System.Console.WriteLine(a/10%10);
    }
    else
    {
if(a>99)
{
    System.Console.WriteLine(a%10);
}
else
{
    System.Console.WriteLine("no");
}
    }
  }

