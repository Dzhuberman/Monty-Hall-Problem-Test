public struct ASCIIImage
{
    public static string SimpleClosedDoor { get; } = "[ ]";
    public static string SimpleRightDoor { get; } = "[V]";
    public static string SimpleWrongDoor { get; } = "[X]";

    public static string ClosedDoor { get; } = 
@"
_________________
|\ ___________ /|
| |  _ _ _ _  | |
| | | | | | | | |
| | |-+-+-+-| | |
| | |-+-+-+-| | |
| | |_|_|_|_| | |
| |     ___   | |
| |    /__/   | |
| |   [%==] ()| |
| |         ||| |
| |         ()| |
| |           | |
| |           | |
| |           | |
|_|___________|_|
";
    public static string RightDoor { get; } = 
@"
_________________
|\ ___________ /|
| |           | |
| |           | |
| |           | |
| |         V | |
| |        V  | |
| | V     V   | |
| |  V   V    | |
| |   V V     | |
| |    V      | |
| |           | |
| |           | |
| |           | |
| |           | |
|_|___________|_|
";
    public static string WrongDoor { get; } = 
@"
_________________
|\ ___________ /|
| |           | |
| |           | |
| | X       X | |
| |  X     X  | |
| |   X   X   | |
| |    X X    | |
| |     X     | |
| |    X X    | |
| |   X   X   | |
| |  X     X  | |
| | X       X | |
| |           | |
| |           | |
|_|___________|_|
";
}