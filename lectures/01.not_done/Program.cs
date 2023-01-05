// Алгоритм: 
// 1. Определить три точки 
// 2. Выбрать две любых 
// 3. Найти середину 
// 4. Поставить точку 
// 5. Выбрать случайную вершину треугольника 
// 6. Соединить её с полученной на 4 шаге точкой 
// 7. Перейти к шагу 3 
// 8. Шаги 3 – 7 повторить 9, 28, 31 раз
double[] Points(double min =0,double max =10)
{
double [] point=new double [2];
Random random=new Random();
for(int i=0;i<2;i++)
    point[i]=random.NextDouble()*10;
    return point;
}


void Print(double[] a)
{
    for(int i=0;i<a.Length;i++)
        System.Console.Write($"{a[i],20}");
}

double[] p1=Points();
Print(p1);




