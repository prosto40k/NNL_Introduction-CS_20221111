//32. Задать массив из 8 целых элементов и вывести их на экран

void RandomIntArray(out int[] a, int size=8,int min=0,int max=100)
{
    /*
    System.Console.WriteLine("Вводим размер массива");
    size=Convert.ToInt32(Console.ReadLine());
    System.Console.WriteLine("Вводим мин значение массива");
    min=Convert.ToInt32(Console.ReadLine());
    System.Console.WriteLine("Вводим макс значение массива");
    max=Convert.ToInt32(Console.ReadLine());
    */
    a=new int[size];
    Random random=new Random();
    for(int i=0;i<size;i++)
        a[i]=random.Next(min,max);    
}

void Print(int[] a)
{
    for(int i=0;i<a.Length;i++)
        System.Console.Write($"{a[i],5}");
}

int[] m;
RandomIntArray(out m,max:110,size:20);
Print(m);