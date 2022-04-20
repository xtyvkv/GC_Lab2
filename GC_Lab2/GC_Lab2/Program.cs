using System;

public class GC_Lab2
{
    static void Main(string[] args)
    {
        int inputInt;
        Console.WriteLine("Please enter an integer.");
        string input = Console.ReadLine();
        if (!int.TryParse(input, out inputInt))
        {
            Console.WriteLine("Not an integer. And I DON'T WANT YOU TO TRY AGAIN BECAUSE I'M TIRED AND I WORK TOO MUCH!!!");
            Console.WriteLine("Bye!!!!!!!!!");

        }
        else
        {
            powers powerTable = new powers();
            Console.WriteLine();
            Console.WriteLine($"Congratulations! {inputInt}!!!! You get to live. If you had entered a letter or blank/white space\n(I know the code to deal with that but I'm too tired and braindead to implement it)\nI would've punched you in your eyes.");
            Console.WriteLine();
            Console.WriteLine("Number\t Squared\t Cubed");
            Console.WriteLine("=======\t =======\t =======");
            Console.WriteLine($"{inputInt}\t {powerTable.Squared(inputInt)}\t\t {powerTable.Cube(inputInt)}");
        }
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

