public class Game
{
    public static bool RightValue { get; } = true;
    public static bool WrongValue { get; } = false;

    public string[] Doors { get; set; }
    public bool[] DoorsValues { get; set; }

    public int FirstPick { get; set; }
    public int SecondPick { get; set; }

    protected Random rng = new Random();

    protected const int _defaultAmountOfDoors = 3;

    public Game(int size)
    {
        CreateDoors(size);
    }

    public Game()
    {
        CreateDoors(_defaultAmountOfDoors);
    }

    protected void CreateDoors(int amountOfDoors)
    {
        Doors = new string[amountOfDoors];
        for (int i = 0; i < Doors.Length; i++)
        {
            Doors[i] = ASCIIImage.SimpleClosedDoor;
        }

        GenerateRandomValues(Doors.Length);
    }

    protected void GenerateRandomValues(int amountOfDoors)
    {
        DoorsValues = new bool[amountOfDoors];
        
        DoorsValues[rng.Next(0, amountOfDoors)] = true;
    }

    public void OpenWrongDoor(int doorNumber)
    {
        FirstPick = doorNumber;

        for (int i = 0; i < DoorsValues.Length; i++)
        {
            if (DoorsValues[i] == false)
                Doors[i] = ASCIIImage.SimpleWrongDoor;
        }

        Doors[FirstPick] = ASCIIImage.SimpleClosedDoor;

        if (DoorsValues[FirstPick] == true)
        {
            int randomDoor = rng.Next(0, DoorsValues.Length);
            randomDoor = randomDoor > 0 ? randomDoor : randomDoor + 1;
            Doors[randomDoor] = ASCIIImage.SimpleClosedDoor;
        }

        GetSecondPick();
    }

    public void OpenDoor(bool isSecondDoor)
    {
        if (isSecondDoor == false)
            Doors[FirstPick] = DoorsValues[FirstPick] ? 
                ASCIIImage.SimpleRightDoor : 
                ASCIIImage.SimpleWrongDoor;
        else
            Doors[SecondPick] = DoorsValues[SecondPick] ? 
                ASCIIImage.SimpleRightDoor : 
                ASCIIImage.SimpleWrongDoor;
        

    }

    public void OpenAllDoors()
    {
        for (int i = 0; i < Doors.Length; i++)
        {
            Doors[i] = DoorsValues[i] ? 
                ASCIIImage.SimpleRightDoor : 
                ASCIIImage.SimpleWrongDoor;
        }
    }

    private void GetSecondPick()
    {
        for (int i = 0; i < Doors.Length; i++)
        {
            if (i != FirstPick && Doors[i] == ASCIIImage.SimpleClosedDoor)
                SecondPick = i;
        }
    }
}