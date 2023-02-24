using System;

namespace Variables_DeBord_Joshua
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int favoriteNumber; //this is a integer and is called favoriteNumber
            bool isJumping = false, isRunning = false; //this states that the user is not jumping or running when put in this WriteLine
            double applePie; //this is a floating point, also called a double. This floating point is called applePie
            applePie = 9; //this tells the system that the floating point "applePie" is 9.
            favoriteNumber = 7; //the explains that the creator's favorite number is 7. Now when ever the varaible is used in a WriteLine, it will show as 7.
            const double finalGrade = 69420; //this is a constant floating point. It is named "finalGrade". Because it is constant, it will always be 69420.
           
            Console.WriteLine($"My favorite number is {favoriteNumber}."); //This makes the Console write information to the user.
            Console.WriteLine($"{isJumping}"); //This makes the Console write information to the user.
            Console.WriteLine($"{isRunning}"); //This makes the Console write information to the user.
            Console.WriteLine($"{applePie}"); //This makes the Console write information to the user.
            Console.WriteLine($"{finalGrade}"); //This makes the Console write information to the user.
        } 
    }
}
