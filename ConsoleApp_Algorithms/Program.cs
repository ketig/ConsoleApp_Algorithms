double[] numbers = new double[7];
Random random = new Random();

for (int i = 0; i < numbers.Length; i++)
{
    numbers[i] = Math.Round(random.NextDouble() * 50);
}
Print(numbers);
InsertionSort(numbers);
Print(numbers);

//8 19 33 0 19 1 9
//8 19 0 33 19 1 9
//8 0 19 33 19 1 9
//0 8 19 33 19 1 9
//0 8 19 19 33 1 9
//0 8 19 19 1 33 9
static void InsertionSort(double[] numbers)
{
    for (int i = 1; i < numbers.Length; i++)
    {
        for (int j = i - 1; j > -1; j--)
        {
            if (numbers[j] > numbers[j + 1])
            {
                Swap(ref numbers[j], ref numbers[j + 1]);
            }
            else
            {
                break;
            }
        }
    }
}

static void SelectionSort<T>(T[] numbers)
    where T : IComparable<T>
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
// Bubble Sort

// Merge Sort
// Interface

static void Swap<T>(ref T x, ref T y)
{
    (x, y) = (y, x);
}

static int MinIndex<T>(T[] numbers, int start, int end)
    where T : IComparable<T>
{
    int result = start;

    for (int i = start; i < end; i++)
    {
        if (numbers[i].CompareTo(numbers[result]) > 0)
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