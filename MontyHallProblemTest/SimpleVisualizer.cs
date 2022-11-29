public class SimpleVisualizer
{
    public static void ShowDoors<T>(T[] doorsArray)
    {
        Console.WriteLine("==========================================");

        for (int i = 0; i < doorsArray.Length - 1; i++)
        {
            Console.Write($"{doorsArray[i]} | ");
        }
        Console.WriteLine($"{doorsArray[doorsArray.Length - 1]}");
        Console.WriteLine("==========================================");
    }
}