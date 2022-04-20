using System;

public class GC_Lab2
{
    static void Main(string[] args)
    {
        bool go = true;

        Console.WriteLine("Learn your squares and cubes!");
        Console.WriteLine();

        while (go == true)
        {
            int inputInt;
            Console.WriteLine("Enter an integer:");
            string input = Console.ReadLine();
            if (!int.TryParse(input, out inputInt))
            {
                Console.WriteLine();
                Console.WriteLine("Invalid input.");
            }
            /*
          
            else

                if (inputInt >= Int32.MaxValue)
                {
                    Console.WriteLine("You have exceeded the minimum or maximum number whose cube will fit in an integer.");
                }
            */
            else
            {
                powers powerTable = new powers();
                Console.WriteLine();
                Console.WriteLine("Number\tSquared\tCubed");
                Console.WriteLine("======\t=======\t======");

                for (int x = 0; x < inputInt; x++)
                {
                    Console.WriteLine($"{x + 1}\t{powerTable.Squared(x + 1)}\t{powerTable.Cube(x + 1)}");
                    /*Console.WriteLine(String.Format("{0,6} {1,8} {2,7}", inputInt, powerTable.Squared(inputInt), powerTable.Cube(inputInt)));
                    inputInt--;*/
                }
            }
            Console.WriteLine();
            Console.WriteLine("If you would like to try again, press Y.");
            string goAgain = Console.ReadLine();
            if (goAgain.ToUpper() != "Y")
            {
                go = false;
            }
            else
            {
                Console.WriteLine();
            }
        }
        Console.WriteLine();
        Console.WriteLine("Goodbye!");
    }
}
public class powers
{
    // Square function
    public int Squared(int inputInt)
    {
        return inputInt * inputInt;
    }
    // Cube function
    public int Cube(int inputInt)
    {
        return inputInt * inputInt * inputInt;
    }
}

