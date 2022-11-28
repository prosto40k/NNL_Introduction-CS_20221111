//32. Задать массив из 8 целых элементов и вывести их на экран

int[] RandomIntArray(int size=8,int min=0,int max=25)
{
    int[] a=new int[size];
    Random random=new Random();
    for(int i=0;i<size;i++)
    a[i]=random.Next(min,max);
    return a;
}

void Print(int[] a)
{
    for(int i=0;i<a.Length;i++)
        System.Console.Write($"{a[i],5}");
}
int[] m=RandomIntArray();
Print(m);