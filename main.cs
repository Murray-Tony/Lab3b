using System;

class Program {
  public static void Main (string[] args) {
    Console.WriteLine ("Enter salesperson name:");
    var name = Console.ReadLine();
    Console.WriteLine("Enter sales amount");
    double sales = Convert.ToDouble(Console.ReadLine());
    double commission = (200 + .09 * sales);
    Console.WriteLine("Sales commission for " + name + " is $" + commission);
    if(commission > 15000)
      {
        Console.WriteLine("Performance is outstanding!");
      }
    if(commission >= 10000)
      {
        if(14999 >= commission)
        {
          Console.WriteLine("Performance is excellent.");
        }
      }
      if(commission >= 5000)
      {
        if(9999 >= commission)
        {
          Console.WriteLine("Performance is good.");
        }
      }
       if(commission >= 3000)
      {
        if(4999 >= commission)
        {
          Console.WriteLine("Performance is average.");
        }
      }
       if(commission >= 0)
      {
        if(2999 >= commission)
        {
          Console.WriteLine("Performance is poor.");
        }
      }

  }
}