
using System.Linq;

char c='a'; // Символ 
c='\x0064';
c='\u0064';
char b='1';
System.Console.WriteLine((int)b);//Преобразовать char в int(десятичное)
System.Console.WriteLine(c.ToString()+b.ToString());//Преобразовать char в string
//Таблица кодировки символов
if (b>='0' && b<='9')/*Проверка символы по диапазону*/ System.Console.WriteLine("It's digit");
if (b>='A' && b<='Z') System.Console.WriteLine("It's big Latin");
if (b>='a' && b<='z' || b>='A' && b<='Z') System.Console.WriteLine("It's litle Latin");

if (Char/*Обращаемся к char*/.IsDigit/*спрашиваем char число?*/(b)) System.Console.WriteLine("It's digit");