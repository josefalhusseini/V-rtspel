
class RobotInvaders
{
    static void Main()
    {
        Console.WriteLine("Robot Invaders");
        Random random = new Random();
        int score = 0;

        for (int turn = 0; turn < 25; turn++)
        {
            System.Threading.Thread.Sleep(random.Next(200, 500));
            int x = random.Next(0, 20);
            int y = random.Next(0, 15);
            char robotSymbol = (char)(random.Next(33, 87));

            Console.Clear();
            for (int i = 0; i < y; i++)
            {
                Console.WriteLine();
            }
            Console.SetCursorPosition(x, y);
            Console.Write(robotSymbol);

            Console.SetCursorPosition(0, 20);
            Console.Write("Type the character: ");
            string input = Console.ReadLine();

            if (!string.IsNullOrEmpty(input) && input[0] == robotSymbol)
            {
                Console.WriteLine("A hit!");
                score++;
            }
            else
            {
                Console.WriteLine("Missed");
            }
        }

        Console.Clear();
        Console.WriteLine($"You scored {score} / 25");
    }
}