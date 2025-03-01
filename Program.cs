namespace LearnAlgorhythms;

class Program
{
    private static void Main(string[] args)
    {   
        Console.WriteLine($"Hello, World! ");
        //Binary_search();
        var array = GetRandomArray();
        ShowArray(array);
        Console.WriteLine($"Hello, World! ");
        ShowArray(Selection_sort(array));
    }

    /// <summary>
    /// ����������� �����
    /// </summary>
    static void Binary_search()
    {
        int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        int item = 10;
        
        int low = 0;
        int high = array.Length - 1;

        while (low <= high)
        {
            int mid = (high + low) / 2;
            int guess = array[mid];
            if (guess == item)
            {
                Console.WriteLine($"Item {item} found");
                break;
            }
            else if (guess > item) high = mid - 1;
            else low = mid + 1;
        }
    }

    /// <summary>
    /// ���������� �������
    /// </summary>
    /// <param name="array"></param>
    /// <returns></returns>
    static int[] Selection_sort(int[] array)
    {
        for (int i = 0; i < array.Length - 1; i++)
        {   
            int tmp;
            for (int j = i + 1; j < array.Length - 1; j++)
            {
                if (array[j] < array[i])
                {
                    tmp = array[i];
                    array[i] = array[j];
                    array[j] = tmp;
                }
            }
        }
        return array;
    }
    
    /// <summary>
    /// ����� �����������
    /// </summary>
    static int FindSmallest(int [] array)
    {
        int smallest = array[0];
        int smallestIndex = 0;

        for (int i = 0; i < array.Length-1; i++)
        {
            if (array[i] < smallest)
            {
                smallest = array[i];
                smallestIndex = i;
            } 
        }
        
        return smallestIndex;
    }
    
    /// <summary>
    /// ������ �����
    /// </summary>
    /// <returns></returns>
    static int[] GetRandomArray()
    {
        int N = 10;
        int[] array = new int[N];
        
        for (int i = 0; i < N; i++)
        {
            array[i] = Random.Shared.Next(1, N);
        }
        
        return array;
    }

    static void ShowArray(int[] array)
    {
        for (int i = 0; i < array.Length-1; i++)
        {
            Console.WriteLine(array[i]);
        }
    }
}