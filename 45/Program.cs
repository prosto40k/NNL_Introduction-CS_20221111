//37. Задать массив, заполнить случайными положительными трёхзначными числами.
//Показать количество нечетных\четных чисел
int[] RandomIntArray(int size=5,int min=100,int max=999)
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

int Na2(int[] a)
{
    int n2=0;
    foreach(int el in a)
        if (el%2==0) n2++;
    return n2;
}

int Na3(int[] a)
{
    int n3=0;
    foreach(int el in a)
        if (el%2!=0) n3++;
    return n3;
}

int[] a=RandomIntArray();
Print(a);
System.Console.WriteLine();
System.Console.WriteLine($"  Чет {Na2(a)}");
System.Console.WriteLine($"Нечет {Na3(a)}");




