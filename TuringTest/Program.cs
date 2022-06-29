

class Solution
{
    public static string ReverseOnlyLetters(string s)
    {
        char memory;
        char[] array = s.ToCharArray();
        int j = s.Length - 1;
        for (int i = 0; i <= j; j--, i++)
        {
            while (((int)array[i] < 65 || (int)array[i] > 122 || (int)array[i] > 90 && (int)array[i] < 97) && i < j) i++;
            while (((int)array[j] < 65 || (int)array[j] > 122 || (int)array[j] > 90 && (int)array[j] < 97) && i < j) j--;
            if (i <= j)
            {
                memory = array[i]; array[i] = array[j]; array[j] = memory;
            }

        }
        return string.Join("", array);
    }
}

public class ReverseOnlyLetters
{
    static void Main(string[] args)
    {
        string s =Console.ReadLine();
        Console.WriteLine(Solution.ReverseOnlyLetters(s));
    }
}