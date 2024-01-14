namespace P07.TruckTour
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int petrolPumps = int.Parse(Console.ReadLine());
            Queue<int[]> pumpsQueue = new Queue<int[]>();

            for (int i = 0; i < petrolPumps; i++)
            {
                int[] data = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
                pumpsQueue.Enqueue(data);
            }

            int position = 0;
            while (true)
            {
                int fuel = 0;

                foreach (var pump in pumpsQueue)
                {
                    fuel += pump[0] - pump[1];
                    if (fuel < 0)
                    {
                        position++;
                        pumpsQueue.Enqueue(pumpsQueue.Dequeue());
                        break;
                    }
                }

                if (fuel >= 0)
                {
                    break;
                }
            }

            Console.WriteLine(position);
        }
    }
}