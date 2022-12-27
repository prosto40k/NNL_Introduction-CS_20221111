//82. C клавиатуры вводится строка разделенная точкой. Подсчитать количество символов до точки


    string s="sadds.a";
    char a ='.';
    int count = s.Split(a).First().Length; 
    Console.WriteLine(count); 