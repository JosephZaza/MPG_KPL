using System;
/** Class Program takes the gallons used and miles driven, given by the user, 
 * to then calculate and display the miles per gallon and kilometers per liter.
 * @author Joseph Kern
 */
class Program
{
  static void Main(string[] args)
  {
    double gallonsUsed = 0;
    double beginningOdom = 0;
    double endingOdom = 0;
    string calcMileage = "";
    const double KILOS_PER_MILE = 1.60934;
    const double LITERS_PER_GALLON = 3.78541;
    
    // Get the number of gallons used
    do
    {
      Console.Write("Please enter number of gallons used: ");
      gallonsUsed = float.Parse(Console.ReadLine());
      
      // Get the starting and ending odometer
      if (gallonsUsed > 0)
      {
        Console.Write("Pleas enter the beginning odometer reading: ");
        beginningOdom = float.Parse(Console.ReadLine());
        Console.Write("Pleas enter the ending odometer reading: ");
        endingOdom = float.Parse(Console.ReadLine());

        // Display the miles per gallon and liters per kilometer
        if (endingOdom > beginningOdom)
        {
          double milesPerGal = (endingOdom - beginningOdom) / gallonsUsed;
          double kilosPerLit = ((endingOdom - beginningOdom) * KILOS_PER_MILE) 
            / (gallonsUsed * LITERS_PER_GALLON);

          Console.WriteLine($"\nMiles per gallon: {milesPerGal:F4}");
          Console.WriteLine($"Kilometers per liter: {kilosPerLit:F4}");
        }
        // Display error message
        else
        {
          Console.WriteLine("I'm sorry, the ending odometer reading must be " +
            "greater than the starting odometer reading.");
        }
      }
      // Display error message
      else
      {
        Console.WriteLine("I'm sorry, gallons used must be greater than 0.");
      }

      // Ask to continue or stop
      Console.Write("\nCalculate more mileage? (Y or N): ");
      calcMileage = (Console.ReadLine().ToUpper());
      Console.WriteLine("===============================");
    } while (calcMileage == "Y");
  }
}
