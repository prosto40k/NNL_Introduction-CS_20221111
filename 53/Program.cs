//53. Найти точку пересечения двух прямых заданных уравнением
// y = k1 * x + b1, y = k2 * x + b2, b1 k1 и b2 и k2 заданы

double X(double b1=1,double k1=2,double b2=3,double k2=4)
{
    double x=(b2-b1)/(k1-k2);
    return x;  
}
double Y(double b1=1,double k1=2,double b2=3,double k2=4)
{
    double x=(b2-b1)/(k1-k2);
    double y=k1*x+b1;
    return y;
}

double a=X();
double b=Y();
System.Console.WriteLine($"({a};{b})");

//y = k1 * x + b1=y = k2 * x + b2
//k1*x-k2*x=b2-b1
//x(k1-k2)=b2-b1
//x(2-4)=3-1
//-2x=2
//x=-1

