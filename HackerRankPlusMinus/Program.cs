using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Result
{

    /*
     * Complete the 'plusMinus' function below.
     *
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    public static void plusMinus(List<int> arr)
    {
        List<int> positive = arr.FindAll(delegate (int a) { return a > 0; });
        
        List<int> negative = arr.FindAll(delegate (int a) { return a < 0; });
        List<int> zero = arr.FindAll(delegate (int a) { return a == 0; });

        List<List<int>> items = new List<List<int>>(){positive, negative, zero};

        items.ForEach(item => Console.WriteLine("{0:0.000000}", Convert.ToDouble(item.Count) / Convert.ToDouble(arr.Count)));


    }

}

class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        Result.plusMinus(arr);
    }
}
