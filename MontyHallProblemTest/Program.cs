public class Program
{
    private static void Main(string[] args)
    {
        Random rng = new Random();
        Game game = new Game();

        SimpleVisualizer.ShowDoors<string>(game.Doors);
        SimpleVisualizer.ShowDoors<bool>(game.DoorsValues);

        int input = InputManager.GetDoorNumber();
        game.OpenWrongDoor(input);
        SimpleVisualizer.ShowDoors<string>(game.Doors);
    }
}