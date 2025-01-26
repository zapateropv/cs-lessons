namespace random_numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            int dice1 = random.Next(1, 7); //this will generate random integer numbers
            int dice2 = random.Next(1, 7);
            int dice3 = random.Next(1, 7);
            // double num  = random.NextDouble(); this will generate random double numbers
            Console.WriteLine(dice1);
            Console.WriteLine(dice2);
            Console.WriteLine(dice3);
        }
    }
}
