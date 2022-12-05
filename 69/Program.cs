//69. Написать программу, упорядочивания по убыванию элементы каждой строки двумерной массива.
int[,] Create2DArray(int n=4,int m=4,int min=1, int max=5)
{
    int[,] a=new int[n,m];
    Random random=new Random();
    for(int i=0;i<n;i++)
    {
        for(int j=0;j<m;j++)
        {
            a[i,j]=random.Next(min,max+1);
        }
                
    }
         
    return a;
}

void Swap(ref int a,ref int b)
{
    int t=a;
    a=b;
    b=t;
}

void BubbleSort(int[,] a,out int count)
{
    count=0;
    int flag=0;
    for(int i=0;i<a.GetLength(0);i++)
    {
        flag=0;
        for(int j=0;j<a.GetLength(1)-1-i;j++)
        {
            if (a[i,j]>a[i,j+1])
            {
              Swap(ref a[i,j],ref a[i,j+1]);
              flag=1;
            }
            count++;
        }
        if (flag==0) return;
    }
}
    
void Print2DArray(int[,] a)
{
    for(int i=0;i<a.GetLength(0);i++)
        {
     for(int j=0;j<a.GetLength(1);j++)
     {
        System.Console.Write($"{a[i,j],4}");
        
     }
     System.Console.WriteLine();

        }
}

int[,] a=Create2DArray();
Print2DArray(a);

int count=0;
BubbleSort(a,out count);
System.Console.WriteLine();
Print2DArray(a);
System.Console.WriteLine();
System.Console.WriteLine(count);



