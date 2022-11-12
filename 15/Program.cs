// С клавиатуры вводится целое число. Вывести третью цифру числа или сообщить, что её нет (Вывести: NO)
System.Console.Write("Ввод числа:");
int a=Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine(a/100%10);
