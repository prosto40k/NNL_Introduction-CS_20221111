//21. Задать номер четверти, показать диапазоны для возможных координат ∞
System.Console.WriteLine("Введите четверть");
int a=Convert.ToInt32(Console.ReadLine());
if(a==1)
{
System.Console.WriteLine("x=(0;+бесконечности)");
System.Console.WriteLine("y=(0;+бесконечности)");
}
else
{
    if(a==2)
    {
        System.Console.WriteLine("x=(0;-бесконечности)");
        System.Console.WriteLine("y=(0;+бесконечности)");
    }
      else
    {
        if(a==3)
        {
            System.Console.WriteLine("x=(0;-бесконечности)");
            System.Console.WriteLine("y=(0;-бесконечности)");
        }
        else
        {
            if(a==4)
            {
                System.Console.WriteLine("x=(0;+бесконечности)");
                System.Console.WriteLine("y=(0;-бесконечности)");
            }
            else
            {
                System.Console.WriteLine("Неверно введена четверть");
            }
        }
    }
}

