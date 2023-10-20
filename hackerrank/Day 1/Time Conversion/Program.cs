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

  public static string timeConversion(string s)
  {
    List<string> time = s.Split(':').ToList();
    string hour = time[0];
    string minutes = time[1];
    string seconds = time[2].Substring(0, 2);
    if (s.Contains("PM"))
    {
      if (hour != "12")
      {
        hour = (int.Parse(hour) + 12).ToString();
      }
    }
    else
    {
      if (hour == "12")
      {
        hour = "00";
      }
    }
    string result = hour + ":" + minutes + ":" + seconds;
    return result;
  }

}


class Solution
{
  public static void Main(string[] args)
  {
    TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

    string s = Console.ReadLine();

    string result = Result.timeConversion(s);

    textWriter.WriteLine(result);

    textWriter.Flush();
    textWriter.Close();
  }
}
