//35. Написать программу замены элементов массива на противоположные.

int[] RandomIntArray(int size=8,int min=1,int max=5)
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

void Print2(int[] a)
{
    for(int i=0;i<a.Length;i++)                                 
        System.Console.Write($"{-a[i],5}"); 
    }
                                            
int[] m=RandomIntArray();
Print(m);
System.Console.WriteLine();  // "\n" с новой строки
Print2(m);
