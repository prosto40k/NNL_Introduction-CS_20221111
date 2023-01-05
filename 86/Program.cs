//86. Подсчитать сколько раз определенный символ (например 'a') встречается в строке.
string a = "asdfga";
int i = 0;
char srch='a';
foreach (char c in a)
{
    if (c==srch)
    {
        i++;
    }
}
System.Console.WriteLine($"Символ \"а\" встречается {i} раза");