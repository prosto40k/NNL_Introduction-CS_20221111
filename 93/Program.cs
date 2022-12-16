//93. Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

int[,] Create2DArray(int n=3, int m=3,int min=2, int max=6)
{
    int[,] a=new int[n,m];
    Random random=new Random();
    for(int i=0;i<n;i++)
         for(int j=0;j<m;j++)
                a[i,j]=random.Next(min,max+1);
    return a;
}

int[,] Create2DArray1(int n=3,int m=3,int min=2, int max=6)
{
    int[,] b=new int[n,m];
    Random random=new Random();
    for(int i=0;i<n;i++)
         for(int j=0;j<m;j++)
                b[i,j]=random.Next(min,max+1);
    return b;
}

int[,] ArrayWith(int[,] a,int[,] b)
{
   int[,] c = new int[a.GetLength(0), a.GetLength(1)];

    for(int i=0;i<a.GetLength(0);i++)
        {
            for(int j=0;j<a.GetLength(1);j++)
            {
                    c[i,j]=a[i,j]*b[i,j];
            }    
        }   
        return c;
}        

void Print2DArray(int[,] a)
{
    for(int i=0;i<a.GetLength(0);i++)
        {
     for(int j=0;j<a.GetLength(1);j++)
        System.Console.Write($"{a[i,j],4}");
           System.Console.WriteLine();
        }
}

int[,] a=Create2DArray();
int[,] b=Create2DArray1();
//  int [,] c=a*b;
//  System.Console.WriteLine(c);
Print2DArray(a);
System.Console.WriteLine();
Print2DArray(b);
System.Console.WriteLine();
int[,] c=ArrayWith(a,b);
Print2DArray(c);
// System.Console.WriteLine(c);