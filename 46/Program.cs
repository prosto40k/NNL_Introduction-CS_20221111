//38. В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]

int[] RandomIntArray(int size=123,int min=1,int max=100)
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

int SearchByRange(int[] a)
{
    int count=0;
    foreach(int el in a)
        if (el>=10 && el<=99) count++;
    return count;
}


int[] a=RandomIntArray();
Print(a);
System.Console.WriteLine();
System.Console.WriteLine($"Кол-во совпадений: {SearchByRange(a)}");

