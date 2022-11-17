// 20. Определить номер четверти плоскости, в которой находится точка с координатами Х и У, причем X ≠ 0 и Y ≠ 
System.Console.WriteLine("Введите х");
double x=Convert.ToDouble(Console.ReadLine());
System.Console.WriteLine("Введите y");
double y=Convert.ToDouble(Console.ReadLine());

if(x>0 && y>0)
{
    System.Console.WriteLine("I четверть");
}
else
{
    if(y>0 && x<0)
    {
        System.Console.WriteLine("II четверть");
    }
    else
    {
        if(y<0 && x<0)
        {
            System.Console.WriteLine("III четверть");
        }
        else
        {
            if(y<0 && x>0)
            {
                System.Console.WriteLine("IV четверть");
            }
        }
    }
}

