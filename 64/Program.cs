//64. В двумерном массиве заменить элементы, у которых оба индекса чётные на их квадраты по значению.

int[,] Create2DArray(int n=3,int m=3,int min=0, int max=5)
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

int Change(int[,] a)
{
    for(int i=0;i<a.GetLength(0);i++)
    {
        for(int j=0;j<a.GetLength(1);j++)
        {
            if (a[i,j]%2==0)
            {
                a[i,j]=-a[i,j];
            }
            
        }
               
    }
    return 0;
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
Change(a);
Print2DArray(a);
