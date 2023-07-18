public class InputManager
{
    public static int[] AutoGameSettingsBuffer { get; set; } = new int[2];

    public static int GetDoorNumber()
    {
        Console.Write("Please choose a door: ");
        string input = Console.ReadLine();
        int doorNumber = 0;

        try
        {
            doorNumber = Convert.ToInt32(input);
        }
        catch
        {
            Console.WriteLine("Input Exeption");
        }

        return doorNumber - 1;
    }

    public static bool GetDiffDoor()
    {
        Console.WriteLine("Would you like to change the door?");
        Console.WriteLine("Yes - y");
        Console.WriteLine("No  - n");

        while (true)
        {
            Console.Write("Your pick is... ");
            string input = Console.ReadLine();

            input = input.ToLower();
            input = String.Concat(input.Where(c => !Char.IsWhiteSpace(c)));

            if (input == "y")
                return true;
            else if (input == "n")
                return false;
            else
                continue;
        }
    }

    public static int ChooseGameType()
    {
        Console.WriteLine("Choose Game Type:");
        Console.WriteLine("Manual - m");
        Console.WriteLine("Auto - a");

        while (true)
        {
            Console.Write("Your pick is... ");
            string input = Console.ReadLine();

            input = input.ToLower();
            input = String.Concat(input.Where(c => !Char.IsWhiteSpace(c)));

            if (input == "m")
            {
                return 1;
            }
            else if (input == "a")
            {
                SetAutoGameSettings();
                return 2;
            }
        }
    }

    public static void SetAutoGameSettings()
    {
        while (true)
        {
            Console.Write("Number of games (from 1 to 9999): ");

            int input = Convert.ToInt32(Console.ReadLine());
            if (input > 0 && input < 10000)
            {
                Console.WriteLine("Ok!");
                AutoGameSettingsBuffer[0] = input;
                break;
            }
            else
            {
                Console.WriteLine("Invalid number. Try Again!");
            }
        }

        while (true)
        {
            Console.Write("Number of doors (from 3 to 10000): ");

            int input = Convert.ToInt32(Console.ReadLine());
            if (input > 2 && input < 10001)
            {
                Console.WriteLine("Ok!");
                AutoGameSettingsBuffer[1] = input;
                break;
            }
            else
            {
                Console.WriteLine("Invalid number. Try Again!");
            }
        }
    }
}