//86. Подсчитать сколько раз определенный символ (например 'a') встречается в строке.
string a = "asdfga";
int i = 0;
foreach (char c in a)
{
    if (c=='a')
    {
        i++;
    }
}
System.Console.WriteLine($"Символ \"а\" встречается {i} раза");