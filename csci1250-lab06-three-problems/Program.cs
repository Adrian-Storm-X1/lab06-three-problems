/*
* Name: Adrian Aguero
* Course: CSCI 1250, Section 001
* Assignment: Lab 06, Three Short Problems
* Date: October 21, 2026
* Description: A menu that keeps running until the user quits, offering three
* independent exercises or all three at once. Each exercise
* practices decisions and one of the four loops.
*/




// int choice = 0; 
// Random rng = new Random();


//do{



//  Console.WriteLine("=== CSCI 1250 Lab 06 ===");   
//  Console.WriteLine("1. The Grade Checker ");   
//  Console.WriteLine("2. The Dice Table");   
//  Console.WriteLine("3. The Score Report");   
//  Console.WriteLine("4. All Three ");   
//  Console.WriteLine("5. Quit");   
//  Console.WriteLine("Choose 1 through 5: ");


//The Grade Checker.
// if (choice == 1 || choice == 4)
// {
//     Console.WriteLine("=== The Grade Checker ===");
//     Console.Write("Score: ");
//     int score = Convert.ToInt32(Console.ReadLine());
//     // Had to make the While loop seperate from the statements to ensure a proper number is recieved. 
//     while(score < 0 || score > 100)
//     {
//         Console.WriteLine("A score must be between 0 and 100");
//         Console.Write("Score: ");
//         score = Convert.ToInt32(Console.ReadLine());
//     }
//     // This is what actually checks the grade. 
//     if (score < 60)
//     {
//         Console.WriteLine(score + " earns an F.");
//     }
//     else if (score >= 60 && score < 70)
//     {
//         Console.WriteLine(score + " earns an D.");
//     }
//     else if (score >= 70 && score < 80)
//     {
//         Console.WriteLine(score + " earns an C.");
//     }  
//     else if (score >= 80 && score < 90)
//     {
//         Console.WriteLine(score + " earns an B.");
//     }  
//     else if (score >= 90 && score < 100)
//     {
//         Console.WriteLine(score + " earns an A.");
//     }
// }


// if (choice == 2 || choice == 4)
// {
    
//     int counter = 1;
//     int wins = 0;
//     string Result = "";

//     Console.WriteLine("=== Excercise 2: The Dice Table ===");
//     while(true)
//     {
//         int diceOne = rng.Next(1,7);
//         int diceTwo = rng.Next(1,7); 
//         int diceTotal = diceOne + diceTwo;
//         int winner = diceOne + diceTwo;
//         counter = counter + 1;
//         if (diceOne == 1 && diceTwo == 1)
//         {
//             Result = "Snake Eyes.";
//         }
//         else if (diceOne == diceTwo)
//         {
//             Result = "Doubles!"; 
//         }
//         else if (winner == 7 || winner == 11)
//         {
//             Result = "A Winner.";
//             wins = wins + 1;
//         }
//         else
//         {
//             Result = "";
//         }

//         Console.WriteLine("Roll " + counter + ": " + diceOne + " and " + diceTwo + ", total " + diceTotal + ". " + Result);
//         Console.Write("Roll Again? (y/n) : ");
//         string? keepGoing = Console.ReadLine();
//         if (keepGoing == "n")
//         {
//             Console.WriteLine("You rolled " + counter + " times and won " + wins + ".");
//             break;
//         }
        
//     }
// }













//}while(choice != 5);