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
}