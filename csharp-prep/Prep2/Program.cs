using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Please enter a percentage. %");
        string number = Console.ReadLine();
        int givenPercentage = int.Parse(number);
         
        if (givenPercentage >= 90){
            Console.WriteLine("You got an A");
        }
        else if (givenPercentage >= 80){
            Console.WriteLine("You got a B");
        }
        else if (givenPercentage >= 70){
            Console.WriteLine("You got a C");
        }
        else if (givenPercentage >= 60){
            Console.WriteLine("You got a D");
        }
        else{
            Console.WriteLine("You got a F");
        }
    }
}