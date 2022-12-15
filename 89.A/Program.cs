// See https://aka.ms/new-console-template for more information

void Words(string A, ref string w, int N)
    {
        if (N < 1)
        {
            Console.Write($"{w} ");
            return;
        }
        foreach (char c in A)        
        {
            w=w+c;
            Words(A,ref w, N-1);
            w = w.Remove(w.Length - 1);
        }
    }
    
    Console.WriteLine("Введите количество букв, из которых будет состоять слово: ");
    int n = Convert.ToInt32(Console.ReadLine());
    string word = "";
    Words("KLMN", ref word, n);

