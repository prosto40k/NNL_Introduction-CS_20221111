//void-тип данных(или метод) ко-ый ничего не возвращает
void FillArray(int[] collection)
{
    int length=collection.Length;
    int index=0;
    while (index<length)
    {
     collection[index]=new Random().Next(1,10);  
     index++;
    }
}
void PrintArray(int[] col)
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

int IndexOff(int[] col, int find)
{
    int count =col.Length;
    int index=0;
    int position=0;
    while (index<count)
    {
        if (col[index]==find)
        {
            position=index;
            break;//показывает первое совпадение,без(break) показывает последнее
        }
        index++;
    }
    return position;
}
int[] array = new int [10];
FillArray(array);
PrintArray(array);
System.Console.WriteLine();
int pos=IndexOff(array, 4);
System.Console.WriteLine(pos);