namespace BinarySearch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int[] ints = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int numberTosearch = random.Next(16);
            int numberIndex = BinarySearch(ints, numberTosearch);

            Console.Write($"У нас есть массив чисел ");

            foreach (int i in ints)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine($"\n\nИщем в нем число {numberTosearch}.");

            if (numberIndex == -1)
            {
                Console.WriteLine($"\nЧисло {numberTosearch} в массиве не найдено.");
            }
            else
            {
                Console.WriteLine($"\nЧисло {numberTosearch} найдено в массиве, его индекс {numberIndex}.");
            }
        }

        public static int BinarySearch(int[] ints, int numberToSearch)
        {
            int subArrayFirstElementIndex = 0;
            int subArrayLastElementIndex = ints.Length - 1;

            while (subArrayFirstElementIndex <= subArrayLastElementIndex)
            {
                int subArrayMiddleElementIndex = (subArrayFirstElementIndex + subArrayLastElementIndex) / 2;

                if (ints[subArrayMiddleElementIndex] == numberToSearch)
                {
                    return subArrayMiddleElementIndex;
                }
                else if (ints[subArrayMiddleElementIndex] > numberToSearch)
                {
                    subArrayLastElementIndex = subArrayMiddleElementIndex - 1;
                }
                else
                {
                    subArrayFirstElementIndex = subArrayMiddleElementIndex + 1;
                }
            }

            return -1;
        }
    }
}