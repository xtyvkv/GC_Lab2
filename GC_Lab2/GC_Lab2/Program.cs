﻿using System;

public class GC_Lab2
{
    static void Main(string[] args)
    {
        bool go = true;

        Console.WriteLine("Learn your SQUARES AND CUBES >:[");
        Console.WriteLine();

        while (go == true)
        {
            int inputInt;
            Console.WriteLine("Enter an integer:");
            string input = Console.ReadLine();
            if (!int.TryParse(input, out inputInt))
            {
                Console.WriteLine("Invalid input.");
            }
            /*
            else if (inputInt >= Int32.MaxValue)
            {
                Console.WriteLine("You have exceeded the minimum or maximum number whose cube will fit in an integer.");
            }
            /* why does this only work if i enter the exact number. it should work for any number greater */
            else

                if (inputInt >= Int32.MaxValue)
                {
                    Console.WriteLine("You have exceeded the minimum or maximum number whose cube will fit in an integer.");
                }
            else
            {
                powers powerTable = new powers();
                Console.WriteLine();
                Console.WriteLine($"Nice! {inputInt}! Look, it may be backwards, but here is a nice table for you:");
                Console.WriteLine();
                Console.WriteLine("Number  Squared   Cubed");
                Console.WriteLine("======  =======  ======");

                while (inputInt > 0)
                {
                    Console.WriteLine(String.Format("{0,6} {1,8} {2,7}", inputInt, powerTable.Squared(inputInt), powerTable.Cube(inputInt)));
                    inputInt--;
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
        Console.WriteLine("BYE THEN.");
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

