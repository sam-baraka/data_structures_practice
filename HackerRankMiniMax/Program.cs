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

    public static void miniMaxSum(List<int> arr)
    {
       arr.Sort();
        List<Int64> sortedAndParsed=new List<Int64>();
        arr.ForEach(x => sortedAndParsed.Add(x));
       List<Int64> sums=new List<Int64> { sortedAndParsed.Take(4).Sum(), sortedAndParsed.Skip(1).Sum(), };
        Console.WriteLine(sums[0]+ " "+ sums[1]);

    }

}

class Solution
{
    public static void Main(string[] args)
    {

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        Result.miniMaxSum(arr);
    }
}
