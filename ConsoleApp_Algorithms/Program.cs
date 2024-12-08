double[] numbers = new double[15];
Random random = new Random();

for (int i = 0; i < numbers.Length; i++)
{
    numbers[i] = Math.Round(random.NextDouble() * 50 - 20);
}
Print(numbers);
SelectionSort(numbers);
Print(numbers);

// Selection sort
static void SelectionSort(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        int minIndex = MinIndex(array, i, array.Length);

        Swap(ref array[i], ref array[minIndex]);
    }
}

// Insertion Sort

static int MinIndex(double[] numbers, int start, int end)
{
    return 0;
}

static void Swap<T>(ref T x, ref T y)
{
    T temp = x;
    x = y;
    y = temp;
}

static void Print<T>(T[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine("\n");
}
