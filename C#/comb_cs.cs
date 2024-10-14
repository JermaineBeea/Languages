using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
      int alphasize = 6;
      char[] alphabetArray = new char[alphasize];
      for (int n = 0; n < alphasize; n++)
      {
        alphabetArray[n] = (char)('a' + n);
      }

      char[] set = alphabetArray;

      List<char[]> NetSet = new List<char[]>();
      int size = set.Length;

      for (int n = 0; n < size; n++)
      {
        for (int n2 = n + 1; n2 < size; n2++)
        {
          char[] arr = new char[2];
          arr[0] = set[n];
          arr[1] = set[n2];
          NetSet.Add(arr);
        }
      }

      foreach (char[] arr in NetSet)
      {
        Console.WriteLine(arr[0] + ", " + arr[1]);
      }
  }
}
