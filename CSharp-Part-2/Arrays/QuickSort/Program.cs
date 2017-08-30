namespace QuickSort
{
    using System;
    using System.Linq;
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            int[] numbers = new int[n];
            for (int i = 0; i < n; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }

            SortArray(numbers, 0, numbers.Length - 1);
            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }
        }

        private static void SortArray(int[] numbers, int left, int right)
        {
            int pivot;

            if (left < right)
            {
                pivot = Partition(numbers, left, right);

                if (pivot > 1)
                {
                    SortArray(numbers, left, pivot - 1);
                }
                if (pivot + 1 < right)
                {
                    SortArray(numbers, pivot + 1, right);
                }
            }
        }

        private static int Partition(int[] numbers, int left, int right)
        {
            int pivot = numbers[left];

            while (true)
            {
                while (numbers[left] < pivot) ++left;
                while (numbers[right] > pivot) --right;

                if (numbers[right] == numbers[left] && numbers[left] == pivot)
                    ++left;

                if (left < right)
                {
                    numbers[left] ^= numbers[right];
                    numbers[right] ^= numbers[left];
                    numbers[left] ^= numbers[right];
                }
                else
                    return right;
            }
        }
    }
}