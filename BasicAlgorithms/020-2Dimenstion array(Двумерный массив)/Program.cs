class Min
{
    public int MinVal(params int[] nums)
    {
        if (nums.Length == 0)
        {
            Console.WriteLine("Ошибка: нет аргументов.");
            return 0;
        }
 
        int m = nums[0];
        for (int i = 1; i < nums.Length; i++)
        {
            if (nums[i] < m)
                m = nums[i];
        }
 
        Console.Write("Наименьшее значение равно ");
        return m;
    }
}
 
class MinDemo
{
    static void Main()
    {
        Min ob = new Min();
        int min;
        int a = 10, b = 20;
 
        min = ob.MinVal();
        Console.WriteLine(min);
 
        min = ob.MinVal(a, b);
        Console.WriteLine(min);
 
        min = ob.MinVal(3, 5, a, 8, 9, b, 4);
        Console.WriteLine(min);
 
        Console.ReadLine();
    }
}