//37. Задать массив, заполнить случайными положительными трёхзначными числами.
//Показать количество нечетных\четных чисел
int[] RandomIntArray(int size=13,int min=2,int max=4)
{
    int[] a=new int[size];
    Random random=new Random();
    for(int i=0;i<size;i++)
    a[i]=random.Next(min,max+1);
    return a;
}

   void Print(int[] a)
{

    for(int i=0;i<a.Length;i++)

        System.Console.Write($"{a[i],5}");
}

void Print2(int[] a)
{
    int i=0;
    while (a[i]%2==0)
    {
        System.Console.WriteLine();
        System.Console.WriteLine("Чет");
        System.Console.WriteLine();
        System.Console.Write($"{a[i]}");
        i++;
        System.Console.WriteLine();
        System.Console.WriteLine(i);
    }

} 
 


int[] m=RandomIntArray();
Print(m);
Print2(m);



