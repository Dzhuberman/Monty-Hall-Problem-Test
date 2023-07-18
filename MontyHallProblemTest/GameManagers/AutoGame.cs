public class AutoGame : Game
{
    public static int FirstPickWins { get; set; }
    public static int SecondPickWins { get; set; }

    public AutoGame(int size)
    {
        CreateDoors(size);
    }

    public AutoGame()
    {
        CreateDoors(_defaultAmountOfDoors);
    }

    private int GetRandomDoor() => rng.Next(0, DoorsValues.Length);

    private bool IsFirstPickTrue()
    {
        if (DoorsValues[FirstPick])
            return true;
        else
            return false;
    }

    public void PlayAutoGame(bool isDebugging = false)
    {
        int randomDoor = GetRandomDoor();
        OpenWrongDoor(randomDoor);

        if (IsFirstPickTrue())
            FirstPickWins++;
        else
            SecondPickWins++;

        if (isDebugging == false) return;
        DebugAutoGame(randomDoor);
    }

    private void DebugAutoGame(int randomDoor)
    {
        OpenWrongDoor(randomDoor);
        Console.WriteLine($"Pick - {FirstPick + 1}");
        SimpleVisualizer.ShowDoors<string>(Doors);
        SimpleVisualizer.ShowDoorsBinaryBool(DoorsValues);

        OpenAllDoors();
        SimpleVisualizer.ShowDoors<string>(Doors);
    }
}