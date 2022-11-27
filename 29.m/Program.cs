
//29. Подсчитать сумму цифр в числе. Сделать подпрограмму.
int ChekNumb (int N)
{
    N=Math.Abs(N); // Math.Abs - число по модулю
    int i=0;
    int numb=0;
    while (N>1)
{   
    numb=N%10+numb;
    N=N/10;
    i++;   
}
return numb;
}
System.Console.WriteLine("Ввести число");
int N=Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine(ChekNumb(N));



