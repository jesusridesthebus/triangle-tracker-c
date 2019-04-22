using System;

namespace Triangles {

  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Enter first triangle side length: ");
      int sideOne = int.Parse(Console.ReadLine());
      Console.WriteLine("Enter second triangle length: ");
      int sideTwo = int.Parse(Console.ReadLine());
      Console.WriteLine("Enter third triangle length: ");
      int sideThree = int.Parse(Console.ReadLine());

      if ((sideOne + sideTwo <= sideThree) || (sideTwo + sideThree <= sideOne) || (sideOne + sideThree <= sideTwo))
      {
        Console.WriteLine("This is not a triangle. Make sure that the longest side is not greater than the sum of the other two sides.");
      }
      else if ((sideOne == sideTwo) && (sideTwo == sideThree))
      {
        Console.WriteLine("This is an equilateral triangle.");
      }
      else if ((sideOne == sideTwo) || (sideTwo == sideThree))
      {
        Console.WriteLine("This is an isosceles triangle.");
      }
      else if ((sideOne != sideTwo) || (sideOne != sideThree))
      {
        Console.WriteLine("This is a scalene triangle.");
      }
    }
  }
}
