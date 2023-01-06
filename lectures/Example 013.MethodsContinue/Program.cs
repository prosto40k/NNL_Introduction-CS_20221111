//Метод от меньшего к большему в массиве

int[] arr={1,2,1,3,7,5};

void Print(int[] col)
{
    int count=col.Length;
    int position=0;
    while (position<count)
    {
        System.Console.Write($"[{position}]");//вывод индекса элемента массива
        System.Console.Write($"[{col[position]}]\n");
        position++;
    }
}

void SelectionSort(int[] array)
{
    
    for (int i = 0; i < array.Length-1; i++)
    {
        int minPosition=i;
        for (int j = i+1; j < array.Length; j++)
        {
            if (array[j]<array[minPosition]) minPosition=j;
        }
        int temporary=array[i];
        array[i]=array[minPosition];
        array[minPosition]=temporary;
    }
    
}

Print(arr);
SelectionSort(arr);
System.Console.WriteLine();
Print(arr);