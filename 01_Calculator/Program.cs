using System;
namespace CalculatorProgram {

    class Calculator{

        static void Main(string [] args)
        {
            bool showMenu = true;
            while (showMenu)
            {
                showMenu = MainMenu();
            }
        }
            private static bool MainMenu()
                {
                    Console.Clear();
                    Console.WriteLine("Welcome to the Calculator Console Application! This calculator will Add, Subtract, Multiply, or Divide two numbers. Please select an option.");
                    Console.WriteLine ("1) Addition");
                    Console.WriteLine("2) Subtraction");
                    Console.WriteLine("3) Multiplication");
                    Console.WriteLine("4) Division");
                    Console.WriteLine("5) Exit Program");

                    switch (Console.ReadLine())
                    {
                        case "1":
                        Addition();
                        return true;
                        case "2":
                        Subtraction();
                        return true;
                        case "3":
                        Multiplication();
                        return true;
                        case "4":
                        Division();
                        return true;
                        case "5":
                        return false;
                        default:
                        return true;
                    }

                }
                private static void Addition()
                {
                    calcCommands calculation = new calcCommands();
                    int numOne;
                    int numTwo;
                    //First number
                    System.Console.WriteLine("Please give the first number: ");
                    string inputOne = Console.ReadLine();
                    //Check for valid input1
                    bool parseSuccess1 = int.TryParse(inputOne, out numOne);
                    if (parseSuccess1)
                    {
                        
                    }
                    else {
                        Console.WriteLine("You entered an invalid character. Please enter numerical digits only with no spaces or commas.");
                        Addition();
                    }
                    //Second number
                    Console.WriteLine("Please give the second number: ");
                    string inputTwo = Console.ReadLine();
                    //Check for valid input2
                    bool parseSuccess2 = int.TryParse(inputTwo, out numTwo);
                    if (parseSuccess2)
                    {

                    }
                    else {
                        Console.WriteLine("You entered an invalid character. Please enter numerical digits only with no spaces or commas.");
                        Addition();
                    }
                    //Calculation and result
                    Console.Write("The answer is: ");
                    Console.WriteLine(calculation.Add(numOne, numTwo));
                    Console.WriteLine("Would you like to add again? y/n");
                    string response = Console.ReadLine();  
                    if (response == "y"){
                        Addition();
                    }
                    else {
                        return;
                    }
                }
                private static void Subtraction()
                {
                    calcCommands calculation = new calcCommands();
                    int numOne;
                    int numTwo;
                    //First number
                    System.Console.WriteLine("Please give the first number: ");
                    string inputOne = Console.ReadLine();
                    //Check for valid input1
                    bool parseSuccess1 = int.TryParse(inputOne, out numOne);
                    if (parseSuccess1)
                    {
                        
                    }
                    else {
                        Console.WriteLine("You entered an invalid character. Please enter numerical digits only with no spaces or commas.");
                        Subtraction();
                    }
                    Console.WriteLine("Please give the second number: ");
                    string inputTwo = Console.ReadLine();
                    //Check for valid input2
                    bool parseSuccess2 = int.TryParse(inputTwo, out numTwo);
                    if (parseSuccess2)
                    {

                    }
                    else {
                        Console.WriteLine("You entered an invalid character. Please enter numerical digits only with no spaces or commas.");
                        Subtraction();
                    }
                    //Calculation and result
                    Console.Write("The answer is: ");
                    Console.WriteLine(calculation.Subtract(numOne, numTwo));
                    Console.WriteLine("Would you like to subtract again? y/n");
                    string response = Console.ReadLine();  
                    if (response == "y"){
                        Subtraction();
                    }
                    else {
                        return; 
                    } 
                }
                private static void Multiplication()
                {
                    calcCommands calculation = new calcCommands();
                    int numOne;
                    int numTwo;
                    //First number
                    System.Console.WriteLine("Please give the first number: ");
                    string inputOne = Console.ReadLine();
                    //Check for invalid input1
                    bool parseSuccess1 = int.TryParse(inputOne, out numOne);
                    if (parseSuccess1)
                    {

                    }
                    else {
                        Console.WriteLine("You entered an invalid character. Please enter numerical digits only with no spaces or commas.");
                        Multiplication();
                    }
                    //Second number
                    Console.WriteLine("Please give the second number: ");
                    string inputTwo = Console.ReadLine();
                    //Check for invalid input2
                    bool parseSuccess2 = int.TryParse(inputTwo, out numTwo);
                    if (parseSuccess2)
                    {

                    }
                    else {
                        Console.WriteLine("You entered an invalid character. Please enter numerical digits only with no spaces or commas.");
                        Multiplication();
                    }
                    //Calculation and result
                    Console.Write("The answer is: ");
                    Console.WriteLine(calculation.Multiply(numOne, numTwo));
                    Console.WriteLine("Would you like to multiply again? y/n");
                    string response = Console.ReadLine();  
                    if (response == "y"){
                        Multiplication();
                    }
                    else {
                        return;
                    }  
                }

                private static void Division()
                {
                    calcCommands calculation = new calcCommands();
                    int numOne;
                    int numTwo;
                    //First number
                    System.Console.WriteLine("Please give the first number: ");
                    string inputOne = Console.ReadLine();
                    //Check for invalid input1
                    bool parseSuccess1 = int.TryParse(inputOne, out numOne);
                    if (parseSuccess1)
                    {
                        
                    }
                    else {
                        Console.WriteLine("You entered an invalid character. Please enter numerical digits only with no spaces or commas.");
                        Division();
                    }
                    Console.WriteLine("Please give the second number: ");
                    string inputTwo = Console.ReadLine();
                    //Check for invalid input2
                    bool parseSuccess2 = int.TryParse(inputTwo, out numTwo);
                    if (parseSuccess2)
                    {

                    }
                    else {
                        Console.WriteLine("You entered an invalid character. Please enter numerical digits only with no spaces or commas.");
                        Division();
                    }
                    //Calculation and result
                    Console.Write("The answer is: ");
                    Console.WriteLine(calculation.Divide(numOne, numTwo));
                    Console.WriteLine("Would you like to divide again? y/n");
                    string response = Console.ReadLine();  
                    if (response == "y"){
                        Division();
                    }
                    else {
                        return;
                    }   
                }
        class calcCommands {
            public int Add(int numOne, int numTwo)
            {
                return numOne + numTwo;
            }
            public int Subtract(int numOne, int numTwo)
            {
                return numOne - numTwo;
            }
            public int Multiply(int numOne, int numTwo)
            {
                return numOne * numTwo;
            }
            public int Divide(int numOne, int numTwo)
            {
                return numOne / numTwo;
            }

        }
    }
}
