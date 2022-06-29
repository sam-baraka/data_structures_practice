using System;

public class Solution
{
    public bool IsValid(string s)
    {
       
            int n = -1;
            while (s.Length != n)
            {
                n = s.Length;
                s = s.Replace("()", "");
                s = s.Replace("{}", "");
                s = s.Replace("[]", "");
            }
            if (s.Length == 0) return true;
            else return false;
        


    }
}

class ValidParentheses
{
    static void Main(String[] args) { 
    Solution solution = new Solution();

        if (solution.IsValid(Console.ReadLine()))
                Console.WriteLine("valid");
        else
            Console.WriteLine("invalid");
    }
}