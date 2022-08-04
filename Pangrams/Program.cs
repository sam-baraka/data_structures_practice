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
     * Complete the 'pangrams' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts STRING s as parameter.
     */

    public static string pangrams()
    {
        String s = "We promptly judged antique ivory buckles for the next prize";
        List<char> alpha = "abcdefghijklmnopqrstuvwxyz".ToList();
        List<char>  stell = s.ToLower().ToList();
        List<char> va=new List<char>{};
        foreach(char a in alpha){
            if(stell.Contains(a)){
                va.Add(a);
            }
        }
        /// Check if the length is 26
        if(va.Count==26){
            return "pangram";
        }else{
            return "not pangram";
        }

    }

}

class Solution
{
    public static void Main(string[] args)
    {


        string result = Result.pangrams();

        Console.WriteLine(result);
    }
}
