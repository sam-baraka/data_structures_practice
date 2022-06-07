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
     * Complete the 'flippingBits' function below.
     *
     * The function is expected to return a LONG_INTEGER.
     * The function accepts LONG_INTEGER n as parameter.
     */

    public static long flippingBits(long n)
    {
        var value=Convert.ToString(n,2).PadLeft(32,'0');
        char[] array =value.ToCharArray();
        //Flip the array bits
        for (int i = 0; i < array.Length; i++)
        {
            if(array[i] == array[i-1]&& array[i-1] == array[i - 2])
            {
                if (array[i] == '0') {array[i]='1'; array[i-1] = '1'; array[i - 2] = '1'; }
                else { array[i]='0'; array[i - 1] = '0'; array[i - 2] = '0'; }
                i += 2;
            }
        }

        return Convert.ToInt32(new String(array),2);
    }


}

class Solution
{
    public static void Main(string[] args)
    {
       // TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int q = Convert.ToInt32(Console.ReadLine().Trim());

        for (int qItr = 0; qItr < q; qItr++)
        {
            long n = Convert.ToInt64(Console.ReadLine().Trim());

            long result = Result.flippingBits(n);

            Console.WriteLine(result);
        }

      //  textWriter.Flush();
        //textWriter.Close();
    }
}
