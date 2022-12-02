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
PrintWithScale(m);




