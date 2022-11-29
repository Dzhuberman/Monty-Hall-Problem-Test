public class Game
{
    public static bool RightValue { get; } = true;
    public static bool WrongValue { get; } = false;

    public string[] Doors { get; set; }
    public bool[] DoorsValues { get; set; }

    public int FirstPick { get; set; }
    public int SecondPick { get; set; }
    public int SecretPick { get; set; }

    private const int _defaultAmountOfDoors = 3;

    public Game(int size)
    {
        CreateDoors(size);
    }

    public Game()
    {
        CreateDoors(_defaultAmountOfDoors);
    }

    private void CreateDoors(int amountOfDoors)
    {
        Doors = new string[amountOfDoors];
        for (int i = 0; i < Doors.Length; i++)
        {
            Doors[i] = ASCIIImage.SimpleClosedDoor;
        }

        GenerateRandomValues(Doors.Length);
    }

    private void GenerateRandomValues(int amountOfDoors)
    {
        Random rng = new Random();

        DoorsValues = new bool[amountOfDoors];
        
        DoorsValues[rng.Next(0, amountOfDoors)] = true;
    }

    public void OpenWrongDoor(int doorNumber)
    {
        FirstPick = doorNumber;
        
        for (int i = 0; i < DoorsValues.Length; i++)
        {
            if (DoorsValues[i] == false && i != FirstPick)
            {
                Doors[i] = ASCIIImage.SimpleWrongDoor;
            }
        }
    }

    public void OpenDoor(int doorNumber)
    {
        if ((doorNumber < 1 && doorNumber > Doors.Length) || Doors[doorNumber] != ASCIIImage.SimpleClosedDoor)
        {
            Console.WriteLine("Door number is out of bounds or Already Opened.");
            return;
        }

        Doors[doorNumber] = DoorsValues[doorNumber] ? 
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

    /*private int GetSecretDoor()
    {
        
    }*/
}