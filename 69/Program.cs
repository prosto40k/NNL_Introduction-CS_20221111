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

int BubbleSort2DArray(int [,] a)
{

for (int i=0; i<a.GetLength(0); i++)
{
    for (int j=0; j<a.GetLength(1); j++)
    {
        for (int k=0; k<a.GetLength(0); k++)
         {
            if (a[i,j] > a[i,k])
            {
                int t = a[i,j];
                a[i,j] = a[i,k];
                a[i,k] = t;
            }
         }
    }
}
    return 1;        
}


int[,] a=Create2DArray();
Print2DArray(a);
System.Console.WriteLine();
BubbleSort2DArray(a);
Print2DArray(a);




