//40. Задан массив a из N элементов. Заполнить массив случайными числами от 1 до 10. 
//Создайте массив, который является произведением пар чисел в одномерном массиве a.
// Парой считаем первый и последний элемент, второй и предпоследний и т.д.
//
int[] RandomIntArray(int size=4,int min=2,int max=5)
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
Print(a);
System.Console.WriteLine();
System.Console.WriteLine($"Кол-во совпадений: {SearchByRange(a)}");
