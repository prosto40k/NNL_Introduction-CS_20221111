//82. C клавиатуры вводится строка разделенная точкой. Подсчитать количество символов до точки

//83. Подсчитать количество цифр среди вводимых с клавиатуры символов




// for(int i=0;i<s.Length;i++)
//     if (char.IsLatin(s[i])) k++;
void M(string s);
{
int k=0;
foreach(char c in s)
    if (c>='a' && c<='z')
    {
        if (c>='A' && c<='Z')
        System.Console.WriteLine("It's Latin");
        k++;
    } 
    
    System.Console.WriteLine(k); 
}
string s=Console.ReadLine();
M(s);
    