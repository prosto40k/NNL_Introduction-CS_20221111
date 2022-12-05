//55. Написать программу масштабирования фигуры(Прямоугольный треугольник, B(0;0))


int[] NotRandomIntArray(int size=6,int xa=1,int ya=0,int xc=0,int yc=1)
{
    int[] a=new int[size];
    a[0]=xa;
    a[1]=ya;
    a[2]=0;
    a[3]=0;
    a[4]=xc;
    a[5]=yc;
    return a;
}

void Print(int[] a)
{
    System.Console.WriteLine("До масштабирования");
    System.Console.Write($"A({a[0]};{a[1]}) ");
    System.Console.Write($"\nB({a[2]};{a[3]}) ");
    System.Console.Write($"\nC({a[4]};{a[5]}) "); 
}

int Scale(int[] a)
{
    int i;
    int scale=2;
    for (i = 0; i < a.Length-1; i++)
    {
        s=a[i]*scale;
    // a[0]=a[0]*scale;
    // a[1]=a[1]*scale;
    // a[2]=a[2]*scale;
    // a[3]=a[3]*scale;
    // a[4]=a[4]*scale;
    // a[5]=a[5]*scale;
    }
   
    return s;
}

void PrintWithScale(int[] a)
{
    int s=2;
    System.Console.WriteLine("\nПосле масштабирования");
    System.Console.Write($"A({a[0]*s};{a[1]*s}) ");
    System.Console.Write($"\nB({a[2]};{a[3]}) ");
    System.Console.Write($"\nC({a[4]*s};{a[5]*s}) "); 
}

int[] m=NotRandomIntArray();
Print(m);
System.Console.WriteLine();
System.Console.WriteLine(Scale(m));
PrintWithScale(m);




