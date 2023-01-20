public class InputManager
{
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
            {
                return true;
            }
            else if (input == "n")
            {
                return false;
            }
            else
            {
                continue;
            }
        }
    }
}