using System;
class HelloWorld {
  static void Main() {
    
    Random random = new Random();
    int num = random.Next(1, 4);
    String playerPick;
    String computer = " ";
    bool playgame = true;
    char choice;
    int playerScore = 0;
    int computerScore = 0;
    
    
   
    
    while(playgame)
    {
         Console.WriteLine("Enter ROCK, PAPER, SCISSORS: ");
         playerPick = Convert.ToString(Console.ReadLine()).ToLower();
         
         switch(num){
             case 1: computer = "rock";
             break;
             
             case 2: computer = "paper";
             break;
             
             case 3: computer = "scissors";
             break;
         }
         
        if(playerPick == "scissors" && computer == "rock")
        {
            Console.WriteLine($"Player: {playerPick}");
            Console.WriteLine($"Computer: {computer}");
            Console.WriteLine("You lose!");
            computerScore++;
            Console.WriteLine($"computer score: {computerScore}");
            Console.WriteLine($"player score: {playerScore}");
        }
        else if(playerPick == "scissors" && computer == "paper")
        {
            Console.WriteLine($"Player: {playerPick}");
            Console.WriteLine($"Computer: {computer}");
            Console.WriteLine("You win!");
            playerScore++;
            Console.WriteLine($"computer score: {computerScore}");
            Console.WriteLine($"player score: {playerScore}");
        }
        else if(playerPick == "scissors" && computer == "scissors")
        {
            Console.WriteLine($"Player: {playerPick}");
            Console.WriteLine($"Computer: {computer}");
            Console.WriteLine("It's a draw!");
            Console.WriteLine($"computer score: {computerScore}");
            Console.WriteLine($"player score: {playerScore}");
        }
        else if(playerPick == "rock" && computer == "scissors")
        {
            Console.WriteLine($"Player: {playerPick}");
            Console.WriteLine($"Computer: {computer}");
            Console.WriteLine("You win!");
            playerScore++;
            Console.WriteLine($"computer score: {computerScore}");
            Console.WriteLine($"player score: {playerScore}");
        }
         else if(playerPick == "rock" && computer == "paper")
        {
            Console.WriteLine($"Player: {playerPick}");
            Console.WriteLine($"Computer: {computer}");
            Console.WriteLine("You Lose!");
            computerScore++;
            Console.WriteLine($"computer score: {computerScore}");
            Console.WriteLine($"player score: {playerScore}");
        }
        else if(playerPick == "rock" && computer == "rock")
        {
            Console.WriteLine($"Player: {playerPick}");
            Console.WriteLine($"Computer: {computer}");
            Console.WriteLine("It's a draw!");
            Console.WriteLine($"computer score: {computerScore}");
            Console.WriteLine($"player score: {playerScore}");
        }
         else if(playerPick == "paper" && computer == "rock")
        {
            Console.WriteLine($"Player: {playerPick}");
            Console.WriteLine($"Computer: {computer}");
            Console.WriteLine("You win!");
            playerScore++;
            Console.WriteLine($"computer score: {computerScore}");
            Console.WriteLine($"player score: {playerScore}");
        }
         else if(playerPick == "paper" && computer == "scissors")
        {
            Console.WriteLine($"Player: {playerPick}");
            Console.WriteLine($"Computer: {computer}");
            Console.WriteLine("You lose!");
            computerScore++;
            Console.WriteLine($"computer score: {computerScore}");
            Console.WriteLine($"player score: {playerScore}");
        }
        else{
            Console.WriteLine($"Player: {playerPick}");
            Console.WriteLine($"Computer: {computer}");
            Console.WriteLine("It's a draw!");
            Console.WriteLine($"computer score: {computerScore}");
            Console.WriteLine($"player score: {playerScore}");
        }
        
        Console.WriteLine("Would you like to play again? (y/n)");
        choice = Convert.ToChar(Console.ReadLine());
        
        if(choice == 'y')
        {
            
        }
        else{
            playgame = false;
            Console.WriteLine("Thanks for playing! see u next time...");
        }
    }
    
  }
}
