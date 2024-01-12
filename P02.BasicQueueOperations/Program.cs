namespace P02.BasicQueueOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] data = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int[] numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            Queue<int> numbersQueue = new Queue<int>(numbers);

            for (int i = 0; i < data[1]; i++)
            {
                numbersQueue.Dequeue();
            }

            if (numbersQueue.Count == 0)
            {
                Console.WriteLine(0);
            }
            else if (numbersQueue.Contains(data[2]))
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine(numbersQueue.Min());
            }

        }
    }
}