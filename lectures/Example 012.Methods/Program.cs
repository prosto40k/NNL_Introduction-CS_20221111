// //1ая группа
// void Method1()
// {
//     System.Console.WriteLine("Автор Я");
// }
// Method1();

// //2ая группа
// void Method2(string msg)
// {
//     System.Console.WriteLine(msg);
// }
// Method2(msg:"Текст сообщениая");
// //
// void Method21(string msg,int count)
// {
//     int i=1;
//     while (i<count)
//     {
//         System.Console.WriteLine(msg);
//         i++;
//     }
//     System.Console.WriteLine(msg);
// }
// Method21("Текст", 2);
// //3 группа

// int Method3()
// {
//     return DateTime.Now.Year;
// }

// int year=Method3();
// System.Console.WriteLine(year);

// //4 группа

// // string Method4(int count, string c )
// // {
// //     int i=0;
// //     string result=String.Empty;
// //     while (i<count)
// //     {
// //         result=result+c;
// //         i++;
// //     }
// //     return result;
// // }
// string Method4(int count, string c )
// {
//     string result=String.Empty;
//     for (int i = 0;i<count; i++)
//     {
//        result=result+c; 
//     }
//     return result;
// }

// string res=Method4(3, "as");
// System.Console.WriteLine(res);

// //цикл в цикле
// //Таблица умножения
// int n=2;
// for (int i = 2; i < 10; i++)
// {
//     System.Console.WriteLine($"Для {n}");
//     for (int j = 2; j < 10; j++)
//     {
//         System.Console.WriteLine($"{i} * {j} = {i*j}");
//     }
//     n++;
//     System.Console.WriteLine();
// }
// //Замена символа в строке
// string text=" Qs1 1 F  ФЫАфыа ываыв-кС сыф 234";
// string Replace(string text, char oldValue, char newValue)
// {
//     string result=String.Empty;
//     int length=text.Length;
//     for (int i = 0; i < length; i++)
//     {
//         if (text[i]==oldValue) result=result+$"{newValue}";
//         else
//         {
//             result=result+ $"{text[i]}";
//         }
            
//     }
//     return result;

// }
// System.Console.WriteLine(text);
// string newText=Replace(text, ' ', '|');
// // System.Console.WriteLine(newText);
// newText=Replace(newText, 'к', 'К');
// // System.Console.WriteLine(newText);
// newText=Replace(newText, 'С', 'с');
// System.Console.WriteLine(newText);


