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
   * Complete the 'miniMaxSum' function below.
   *
   * The function accepts INTEGER_ARRAY arr as parameter.
   */

  public static void miniMaxSum(List<long> arr)
  {
    arr.Sort();
    List<long> arrMax = new List<long>(arr);
    List<long> arrMin = new List<long>(arr);
    arrMax.RemoveAt(0);
    arrMin.RemoveAt(arrMin.Count - 1);
    long sumMax = arrMax.Sum();
    long sumMin = arrMin.Sum();
    Console.Write(sumMin + " " + sumMax);
  }

}

class Solution
{
  public static void Main(string[] args)
  {

    List<long> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt64(arrTemp)).ToList();

    Result.miniMaxSum(arr);
  }
}
