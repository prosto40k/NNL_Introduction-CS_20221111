//51. С клавиатуры вводится число N. Затем вводятся N чисел. Определить сколько чисел больше 0 введено с клавиатуры

int[] RandomIntArray(int size=5)
{
    System.Console.WriteLine("Введите N");
    size=Convert.ToInt32(Console. ReadLine());
    int[] a=new int[size];
    for(int i=0;i<size;i++)
    {   
        System.Console.WriteLine("Заполните массив");
        a[i]=int.Parse(Console. ReadLine());
    }
    return a;
}

   void Print(int[] a)
{

    for(int i=0;i<a.Length;i++)

        System.Console.Write($"{a[i],5}");
}

int SearchForMore(int[] a)
{
    int count=0;
    foreach(int el in a)
        if (el>0) count++;
    return count;
}


int[] a=RandomIntArray();
Print(a);
System.Console.WriteLine();
System.Console.WriteLine($"Кол-во чисел больше нуля: {SearchForMore(a)}");