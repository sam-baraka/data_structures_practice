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
     * Complete the 'timeConversion' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts STRING s as parameter.
     */
    //07:05:45PM
    //19:05:45

    public static string timeConversion(string s)
    {
        DateTime currentDate = Convert.ToDateTime(s);
        return currentDate.ToString("HH:mm:ss");
    }

}

class Solution
{
    public static void Main(string[] args)
    {
       // TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string s = Console.ReadLine();

        string result = Result.timeConversion(s);
        Console.WriteLine(result);

      //  textWriter.WriteLine(result);

        //textWriter.Flush();
        //textWriter.Close();
    }
}
