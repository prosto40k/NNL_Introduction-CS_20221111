﻿//56. Написать программу копирования массива
 int[] RandomIntArray(int size=10,int min=0,int max=100)
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
 
 void Main(int[] a)
    {
 
        int[] copy = new int[a.Length];
        a.CopyTo(copy, 0);
 
        Console.WriteLine(String.Join(" " , copy));
    }

int[] a=RandomIntArray();
Print(a);
System.Console.WriteLine();
Main(a);
