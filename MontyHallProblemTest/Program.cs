public class Program
{
    private static void Main(string[] args)
    {
        PlayManualGame();
    }

    private static void PlayManualGame()
    {
        Random rng = new Random();
        Game game = new Game();

        SimpleVisualizer.ShowDoors<string>(game.Doors);
        //SimpleVisualizer.ShowDoors<bool>(game.DoorsValues);

        int input = InputManager.GetDoorNumber();
        game.OpenWrongDoor(input);
        SimpleVisualizer.ShowDoors<string>(game.Doors);

        game.OpenDoor(InputManager.GetDiffDoor());
        SimpleVisualizer.ShowDoors<string>(game.Doors);
    }

    private static void PlayAutoGames(int amountOfGames, int amountOfDoors)
    {
        for (int i = 0; i < amountOfGames; i++)
        {
            AutoGame autoGame = new AutoGame(amountOfDoors);
            autoGame.PlayAutoGame();
        }

        Console.WriteLine($"First Doors Victories - {AutoGame.FirstPickWins}");
        Console.WriteLine($"Second Doors Victories - {AutoGame.SecondPickWins}");
    }
}