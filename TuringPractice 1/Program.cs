using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

class Solution
{
    public int CalPoints(string[] ops)
    {
       List<int> points = new List<int>();
        foreach(string op in ops)
        {
            //invalidate the previous score
            if (op == "C") { 
            points.RemoveAt((points.Count)-1);
            }
            // Record a score that is double the previous score
            else if(op == "D") { 
            int x=points[points.Count-1];
                points.Add((x*2));
            }
            // record a score that is a sum of the prvious 2 scores
            else if (op == "+") { 
            int x=points[points.Count-1];
                int y = points[points.Count- 2];
            points.Add(x+y);
            }
            // Add the int to the recors
            else { 
            points.Add(int.Parse(op));
            }
        }
        return points.Sum();

    }
}

class CalPoints
{
    static void Main(string[] args)
    {
        Solution solution = new Solution();
        char[] space = new char[] {' '};
        string [] ops = Console.ReadLine().Split(space);
        int output= solution.CalPoints(ops);
        Console.Write(output.ToString());
    }
}