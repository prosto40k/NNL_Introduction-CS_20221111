//35. Написать программу замены элементов массива на противоположные

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
        System.Console.Write($",10{-a[i],5}");// \n-новая строка(каждая цифра массива с новой строки)
}                                          // Если добавить cw "имя "i" не существует в текущем контексте."

int[] m=RandomIntArray();
Print(m);
Print2(m);
