//Массив из случайных чисел
/*
void RandomIntArray(out int[] a, int size=10,int min=0,int max=100)
{
    System.Console.WriteLine("Вводим размер массива");
    size=Convert.ToInt32(Console.ReadLine());
    System.Console.WriteLine("Вводим мин значение массива");
    min=Convert.ToInt32(Console.ReadLine());
    System.Console.WriteLine("Вводим макс значение массива");
    max=Convert.ToInt32(Console.ReadLine());
    a=new int[size];
    Random random=new Random();
    for(int i=0;i<size;i++)
        a[i]=random.Next(min,max);    
}
*/


int[] RandomIntArray(int size=10,int min=0,int max=100)
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


/*Для out int
int[] m;
RandomIntArray(out m,max:110,size:20);
Print(m);
*/