double[] numbers = new double[7];
Random random = new Random();

for (int i = 0; i < numbers.Length; i++)
{
    numbers[i] = Math.Round(random.NextDouble() * 50);
}
Print(numbers);
SelectionSort(numbers);
Print(numbers);

static void SelectionSort(double[] numbers)
{
    for (int i = 0; i < numbers.Length - 1; i++)
    {
        int minIndex = MinIndex(numbers, i, numbers.Length);
        // swap i minIndex
        if (minIndex != i)
        {
            Swap(ref numbers[i], ref numbers[minIndex]);
        }
    }
}

// Insertion Sort
// Insertion Sort vsSelected Sort
// Merge Sort
// Bubble Sort

static void Swap<T>(ref T x, ref T y)
{
    (x, y) = (y, x);
    //T temp = x;
    //x = y;
    //y = temp;
}

static int MinIndex(double[] numbers, int start, int end)
{
    int result = start;

    for (int i = start; i < end; i++)
    {
        if (numbers[i] < numbers[result])
        {
            result = i;
        }
    }

    return result;
}

static void Print<T>(T[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine(/*"\n"*/);
}