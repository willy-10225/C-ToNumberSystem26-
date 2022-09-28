using System;

class Program
{
    // 數字轉26英文進制
    public static string ToNumberSystem26(int n)
    {
        string s = string.Empty;
        while (n > 0)
        {
            int m = n % 26;
            if (m == 0) m = 26;
            s = (char)(m + 64) + s;
            n = (n - m) / 26;
        }
        return s;
    }

    // 英文轉數字
    public static int FromNumberSystem26(string s)
    {
        if (string.IsNullOrEmpty(s)) return 0;
        int n = 0;
        for (int i = s.Length - 1, j = 1; i >= 0; i--, j *= 26)
        {
            char c = Char.ToUpper(s[i]);
            if (c < 'A' || c > 'Z') return 0;
            n += ((int)c - 64) * j;
        }
        return n;
    }

    static void Main(string[] args)
    {
        int[] numbers = { 1, 10, 26, 27, 256, 702, 703 };
        foreach (int n in numbers)
        {
            string s = ToNumberSystem26(n);
            Console.WriteLine(n + "\t" + s + "\t" + FromNumberSystem26(s));
        }
        Console.ReadLine();
    }
}
