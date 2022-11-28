//36. Определить, присутствует ли в заданном массиве, некоторое число


int[] RandomIntArray(int size=10,int min=10,int max=25)
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

int LinearSearch(int[] a,int find,int startIndex=0)
{
    int i=startIndex;
    while(i<a.Length && a[i]!=find) i++;
    if (i==a.Length)
        return -1;
    else
        return i;
}
int[] a=RandomIntArray();
int find=20;
Print(a);
System.Console.WriteLine();
int i=LinearSearch(a,find);
if (i==-1)
    System.Console.WriteLine($"Element {find} not found");
else
    System.Console.WriteLine($"Element {find} found at {i}");
