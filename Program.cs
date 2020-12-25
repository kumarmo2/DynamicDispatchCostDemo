using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace DynamicDispatchCostDemo
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Hello World!");
      var list = new List<string>();
      var set = new HashSet<string>();

      for (var i = 0; i < 10; i++)
      {
        set.Add(i.ToString());
      }
      DynamicDispatchExample(set);

      for (var i = 0; i < 10000000; i++)
      {
        list.Add(i.ToString());
      }
      DynamicDispatchExample(list);
      //   StaticDispatchExample(list);
    }

    private static int DynamicDispatchExample(IEnumerable<string> list)
    {
      var stopWatch = Stopwatch.StartNew();
      var sum = 0;

      foreach (var ele in list)
      {
        sum += 1;
      }
      Console.WriteLine($"{stopWatch.ElapsedMilliseconds} for dynamic dispatch");
      return sum;

    }
    private static int StaticDispatchExample(List<string> list)
    {
      var stopWatch = Stopwatch.StartNew();
      var sum = 0;
      for (var i = 0; i < list.Count; i++)
      {
        sum += 1;
      }
      Console.WriteLine($"{stopWatch.ElapsedMilliseconds} for static dispatch");
      return sum;
    }


  }
}
