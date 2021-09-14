using System;

class Program {
  public static void Main (string[] args) {
    Console.WriteLine ("Enter salesperson name:");
    var name = Console.ReadLine();
    Console.WriteLine("Enter sales amount");
    double sales = Convert.ToDouble(Console.ReadLine());
    double commission = (200 + .09 * sales);
    Console.WriteLine("Sales commission for " + name + " is $" + commission);
    if(sales > 15000)
      {
        Console.WriteLine("Performance is outstanding!");
      }
    if(sales >= 10000)
      {
        if(14999 >= sales)
        {
          Console.WriteLine("Performance is excellent.");
        }
      }
      if(sales >= 5000)
      {
        if(9999 >= sales)
        {
          Console.WriteLine("Performance is good.");
        }
      }
       if(sales >= 3000)
      {
        if(4999 >= sales)
        {
          Console.WriteLine("Performance is average.");
        }
      }
       if(sales >= 0)
      {
        if(2999 >= sales)
        {
          Console.WriteLine("Performance is poor.");
        }
      }

  }
}