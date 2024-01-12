namespace P06.SongsQueue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] songs = Console.ReadLine().Split(", ").ToArray();
            Queue<string> songsQueue = new Queue<string>(songs);

            while (songsQueue.Count > 0)
            {
                string[] data = Console.ReadLine().Split(" ");
                string command = data[0];
                if (command == "Play")
                {
                    songsQueue.Dequeue();
                }
                else if (command == "Show")
                {
                    Console.WriteLine(string.Join(", ", songsQueue));
                }
                else if (command == "Add")
                {
                    string songName = string.Join(" ", data.Skip(1));
                    if (songsQueue.Contains(songName))
                    {
                        Console.WriteLine($"{songName} is already contained!");
                    }
                    else
                    {
                        songsQueue.Enqueue(songName);
                    }
                }
                                      
            }

            Console.WriteLine("No more songs!");
        }
    }
}