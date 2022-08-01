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


    public static int diagonalDifference(List<List<int>> arr)
    {
        int rowsCount = arr.Count()-1;
        List<int> topLeftBottomRight = new List<int>();
        List<int>  topRightBottomLeft = new List<int> ();
        ///Get the first diagonal numbers
        for (int i=0; i<=rowsCount; i++)
        {
            topLeftBottomRight.Add(arr[i][i]);
        }
        ///Get the second diagonal numbers
        for (int i = 0; i <= rowsCount; i++)
        {
            topRightBottomLeft.Add(arr[i][rowsCount-i]);
        }

        return Math.Abs(topLeftBottomRight.Sum() - topRightBottomLeft.Sum());
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<List<int>> arr = new List<List<int>>();

        for (int i = 0; i < n; i++)
        {
            arr.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList());
        }

        int result = Result.diagonalDifference(arr);

        Console.WriteLine(result);

        //textWriter.Flush();
        //textWriter.Close();
    }
}
