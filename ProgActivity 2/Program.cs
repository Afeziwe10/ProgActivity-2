using System;
using System.Diagnostics.CodeAnalysis;

class Program
{
    static void Main()
    {
        //Declare variables
        int a = 10;
        int b = 5;
        
        //Addidion
        a += b;                 // a+=b Means A+b
        Console.ForegroundColor = ConsoleColor.Green;   // Making the font to be green
        Console.WriteLine("Your answer in addition is: " + a);
        Console.ResetColor();                           // Reset the color

        // My program will then be able to subract the answer i got from the previous operator

        //Subtraction
        a -= b;              // a-=b Means a - b
        Console.ForegroundColor= ConsoleColor.Blue; // Changing the color to be blue
        Console.WriteLine("Your answer in subtraction is: " + a);    
        Console.ResetColor();                         //Reste the color

        a *= b;           // a*=b Means a * b
        Console.ForegroundColor= ConsoleColor.Yellow; // Changing the color to be yellow
        Console.WriteLine("Your answer in multiplication is: " + a);
        Console.ResetColor();                         // Reset the Color

        a /= b;        // a/=b Means a/b
        Console.ForegroundColor= ConsoleColor.Magenta;  // Changing the color to be Magenta
        Console.WriteLine("Your answer in division is: " + a);
        Console.ResetColor();                           // Reset the color

        Console.ForegroundColor = ConsoleColor.DarkCyan;
        Console.WriteLine("Enter your age: ");          
        int age = Convert.ToInt32(Console.ReadLine());  // Converting string to int
        Console.ResetColor();

        String decision;  // a variale to hold the output of yes or no

        if (age <= 17)
        {
            decision = "No";          // if the user is under 16 or equal to is should display no

            Console.ForegroundColor = ConsoleColor.Yellow;  // Changing thr color to be yellow
            Console.Write("Are you eligible to drive? ");
            Console.ResetColor();                         // Reset the color to default

            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(decision);     
        }
        
        // Declare yes or No variables
        string choiceYes = "yes";  //choice for yes
        string choiceNo = "no";  // choice for no

        //check if the user is 18 and above
        if (age >= 18)
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("\nDo you have driver's license? (Yes/No )");
            string response = Console.ReadLine(); // read user input
            Console.ResetColor();

            //checking if the user says yes
            if (response == choiceYes)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("Are you eligible to drive? ");
                Console.ResetColor();

                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(choiceYes);                     //output yes
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.Write("Are eligible to drive? ");
                Console.ResetColor();

                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.Write(choiceNo);                    // Output yes
                Console.ResetColor();
            }
        }
        
        // Ask the user to enter their age to recieve a message
        string message;
        Console.ForegroundColor= ConsoleColor.Green;
        Console.WriteLine("\nEnter your age again to recieve a message: ");
        int age1 = Convert.ToInt32(Console.ReadLine());
        Console.ResetColor() ;

        // check the age range and assign correct message
        if (age1 >=10 && age1<=15)
        {
            message = "You are too young to drive";

            Console.ForegroundColor= ConsoleColor.DarkRed;
            Console.WriteLine("Message: " + message);   // Output message for ages 10 - 15
            Console.ResetColor();
        }

        if (age1 >=16 && age1 <=17)
        {
            message = "You are almost old enough to drive";

            Console.ForegroundColor=ConsoleColor.Red;
            Console.WriteLine("Message: " + message);  // Output message for ages 16 - 17
            Console.ResetColor();
        }

        if(age1 >=18 && age1 <=24)
        {
            message = "You are legally eligible to drive";

            Console.ForegroundColor=ConsoleColor.DarkYellow;
            Console.WriteLine("Message: " + message);    // Output message for ages 18 - 24
            Console.ResetColor();
        }

        if (age1 >=25 )
        {
            message = "You are an experience driver";

            Console.ForegroundColor=ConsoleColor.DarkGreen;
            Console.WriteLine("Message: "+ message);  // Output message for ages 25 and above
            Console.ResetColor();
        }

        //string Manipulation
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("\nEnter your name");
        string firstname = Console.ReadLine();

        Console.WriteLine("Enter your last Name");
        string lastname = Console.ReadLine();
        Console.ResetColor();

        Console.WriteLine("\nUPPER: " + firstname.ToUpper() + " " + lastname.ToUpper());  //firstname and last name to be capital letters
        Console.WriteLine("LOWER: " + firstname.ToLower() + " " + lastname.ToLower()); // lower cases

        //printing the first character of the firstname
        char firstCharacter = firstname[0];

        Console.WriteLine($"First Character is:  { firstCharacter}");
    }
   
}