// 17. Дано число обозначающее день недели. Выяснить является номер дня недели выходным
int day=5;
//Monday - понедельник Tuesday - вторник Wednesday - среда Thursday - четверг Friday - пятница Saturday - суббота Sunday - воскресенье
int mon=1;
int tues=2;
int wednes=3;
int thurs=4;
int fri=5;
int satur=6;
int sun=7;

if(day!=6 || day!=7)
{
    System.Console.WriteLine("Сегодня не выходной");
}
else
{
    System.Console.WriteLine("Сегодня выходной");
}
