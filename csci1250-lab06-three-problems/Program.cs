/*
* Name: Adrian Aguero
* Course: CSCI 1250, Section 001
* Assignment: Lab 06, Three Short Problems
* Date: October 21, 2026
* Description: A menu that keeps running until the user quits, offering three
* independent exercises or all three at once. Each exercise
* practices decisions and one of the four loops.
*/




int choice = 0; 
Random rng = new Random();




    

    


do
{
//The Introduction
    Console.WriteLine("");
    Console.WriteLine("=== CSCI 1250 Lab 06 ===");   
    Console.WriteLine("1. The Grade Checker ");   
    Console.WriteLine("2. The Dice Table");   
    Console.WriteLine("3. The Score Report");   
    Console.WriteLine("4. All Three ");   
    Console.WriteLine("5. Quit");   
    Console.Write("Choose 1 through 5: ");
    choice = Convert.ToInt32(Console.ReadLine());
//This makes sure the desired value is achieved.
    while(choice > 5 || choice < 1)
    {
        Console.WriteLine("Choose a number from 1 to 5.");
        Console.Write("Choose 1 through 5: ");
        choice = Convert.ToInt32(Console.ReadLine());
    }

    Console.WriteLine("");


    //The Grade Checker.
    if (choice == 1 || choice == 4)
    {
        Console.WriteLine("");
        Console.WriteLine("=== The Grade Checker ===");
        Console.Write("Score: ");
        int scorePartOne = Convert.ToInt32(Console.ReadLine());
        // Had to make the While loop seperate from the statements to ensure a proper number is recieved. 
        while(scorePartOne < 0 || scorePartOne > 100)
        {
            Console.WriteLine("A score must be between 0 and 100");
            Console.Write("Score: ");
            scorePartOne = Convert.ToInt32(Console.ReadLine());
        }
        // This is what actually checks the grade. 
        if (scorePartOne < 60)
        {
            Console.WriteLine(scorePartOne + " earns an F.");
        }
        else if (scorePartOne >= 60 && scorePartOne < 70)
        {
            Console.WriteLine(scorePartOne + " earns an D.");
        }
        else if (scorePartOne >= 70 && scorePartOne < 80)
        {
            Console.WriteLine(scorePartOne + " earns an C.");
        }  
        else if (scorePartOne >= 80 && scorePartOne < 90)
        {
            Console.WriteLine(scorePartOne + " earns an B.");
        }  
        else if (scorePartOne >= 90 && scorePartOne < 100)
        {
            Console.WriteLine(scorePartOne + " earns an A.");
        }
    }


    //This is the Dice Table
    if (choice == 2 || choice == 4)
    {
        Console.WriteLine("");

        int counter = 0;
        int wins = 0;
        string Result = "";

        Console.WriteLine("=== Excercise 2: The Dice Table ===");
    //The game does not keep going on indefinitely if any other loop is used
        while(true)
        {
            int diceOne = rng.Next(1,7);
            int diceTwo = rng.Next(1,7); 
            int diceTotal = diceOne + diceTwo;
            int winner = diceOne + diceTwo;
            counter = counter + 1;
            if (diceOne == 1 && diceTwo == 1)
            {
                Result = "Snake Eyes.";
            }
            else if (diceOne == diceTwo)
            {
                Result = "Doubles!"; 
            }
            else if (winner == 7 || winner == 11)
            {
                Result = "A Winner.";
                wins = wins + 1;
            }
            else
            {
                Result = "";
            }

            Console.WriteLine("Roll " + counter + ": " + diceOne + " and " + diceTwo + ", total " + diceTotal + ". " + Result);
            Console.Write("Roll Again? (y/n) : ");
            string? keepGoing = Console.ReadLine();
            if (keepGoing == "n")
            {
                Console.WriteLine("You rolled " + counter + " times and won " + wins + ".");
                break;
            }

        }
    }



    //This is the score report
    if  (choice == 3 || choice == 4)
    {
        Console.WriteLine("");
        Console.WriteLine("=== Excersice 3: The Score Report ===");
        int[] scores = new int[5];
        int countAmount = 0;
        int passingScore = 0;
        double total = 0;
        int high = int.MinValue;



        //a standard for loop is used to ensure that the score length is what is being met
        for (int i = 0; i < scores.Length; i++)
        {
            countAmount = countAmount + 1;
            Console.Write("Score " + countAmount + ": " );
            scores[i] = int.Parse(Console.ReadLine());
        }

        // this loop takes full advantage of the array being the list that is actually read.
        foreach (int score in scores)
        {
            total += score;

            if (score > high)
            {
                high = score;
            }

            if (score >= 60)
            {
                passingScore = passingScore + 1;
            }

    
        }
        double average = total / scores.Length;

        Console.WriteLine("");
        Console.WriteLine("Scores entered: " + scores.Length);
        Console.WriteLine("Total: " + total);
        Console.WriteLine("Average: " + average);
        Console.WriteLine("Highest: " + high);
        Console.WriteLine("Passing: " + passingScore + " of " + scores.Length);
    }


    

}while(choice != 5);

Console.WriteLine("");
Console.WriteLine("Goodbye.");