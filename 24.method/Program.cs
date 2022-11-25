//24. Вывести на экран таблицу квадратов чисел от 1 до N

int While (int sqr)
{   
    int N;
    int i=1;
    while (i!=N+1)
{
   sqr=i*i;
   i++;
   return sqr;
}
}
int sqr;
System.Console.WriteLine("Введите N");
int N=Convert.ToInt32(Console.ReadLine(While(N)));
System.Console.WriteLine(While(sqr));
/*
1) Уберите int i из 3-й строчки, у вас по условиям задачи это типа константа, она объявляется на 
5 строке внутри метода!
2) return нужно вынести на 12-ю строчку (за пределы цикла While), иначе как и написано: "не все пути к коду......."!
3) sqr объявлена только внутри метода. нужно объявить ее повторно вне метода
дополнительно: проверьте аргументы, передаваемые в метод на строке 17
*/

/*
int sqr;
int i=1;
System.Console.WriteLine("Введите N");
int N=Convert.ToInt32(Console.ReadLine());
while (i!=N+1)
{
   sqr=i*i;
   i++;
   System.Console.WriteLine(sqr);
}
*/
