//29. Подсчитать сумму цифр в числе. Сделать подпрограмму.
System.Console.WriteLine("Введите число");
int N=Convert.ToInt32(Console.ReadLine());
int i = 0;
int numb=0;
while (N>1)
{
   numb=N%10+numb;
   N=N/10;
   i++; 
}
System.Console.WriteLine(numb);

