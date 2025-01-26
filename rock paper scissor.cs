namespace rock_paper_scissor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String choice = "";
            Random random = new Random();
            bool play = true;
            String computer = "";

            while (play)
            {
                while (choice != "ROCK" && choice != "PAPER" && choice != "SCISSOR")
                {
                    Console.WriteLine("Enter ROCK, PAPER OR SCISSORS: ");
                    choice = Console.ReadLine();
                    choice = choice.ToUpper();

                    


                }
                int randomNum = random.Next(1, 4);
                switch (randomNum)
                {
                    case 1:
                        computer = "ROCK";
                        break;

                    case 2:
                        computer = "PAPER";
                        break;

                    case 3:
                        computer = "SCISSOR";
                        break;
                }

                switch (choice)
                {
                    case "ROCK":
                        if (computer == "ROCK")
                        {
                            Console.WriteLine("ITS A DRAW");
                            Console.WriteLine("player: " + choice);
                            Console.WriteLine("computer: " + computer);
                            choice = "";
                        }
                        else if (computer == "SCISSOR")
                        {
                            Console.WriteLine("YOU WON");
                            Console.WriteLine("player: " + choice);
                            Console.WriteLine("computer: " + computer);
                            choice = "";
                        }
                        else
                        {
                            Console.WriteLine("YOU LOSE");
                            Console.WriteLine("player: " + choice);
                            Console.WriteLine("computer: " + computer);
                            choice = "";
                        }
                        break;

                    case "PAPER":
                        if (computer == "ROCK")
                        {
                            Console.WriteLine("YOU WON");
                            Console.WriteLine("player: " + choice);
                            Console.WriteLine("computer: " + computer);
                            choice = "";
                        }
                        else if (computer == "SCISSOR")
                        {
                            Console.WriteLine("YOU LOSE");
                            Console.WriteLine("player: " + choice);
                            Console.WriteLine("computer: " + computer);
                            choice = "";
                        }
                        else
                        {
                            Console.WriteLine("ITS A DRAW");
                            Console.WriteLine("player: " + choice);
                            Console.WriteLine("computer: " + computer);
                            choice = "";
                        }
                        break;


                    case "SCISSOR":
                        if (computer == "ROCK")
                        {
                            Console.WriteLine("YOU LOSE");
                            Console.WriteLine("player: " + choice);
                            Console.WriteLine("computer: " + computer);
                            choice = "";
                        }
                        else if (computer == "SCISSOR")
                        {
                            Console.WriteLine("ITS A DRAW");
                            Console.WriteLine("player: " + choice);
                            Console.WriteLine("computer: " + computer);
                            choice = "";
                        }
                        else
                        {
                            Console.WriteLine("YOU WON");
                            Console.WriteLine("player: " + choice);
                            Console.WriteLine("computer: " + computer);
                            choice = "";
                        }
                        break;
                }
            }

          
        }
    }
}
