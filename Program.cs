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
        ShowArray(Fast_sort(array, 0, array.Length - 1));
    }

    /// <summary>
    /// Быстрая сортировка
    /// </summary>
    /// <param name="array"></param>
    /// <returns></returns>
    static int[] Fast_sort(int[] array, int minIndex, int maxIndex)
    {
        if (minIndex >= maxIndex)
        {
            return array;
        }

        int pivot = GetPivotIndex(array, minIndex, maxIndex);

        Fast_sort(array, minIndex, pivot -1);
        
        Fast_sort(array, pivot + 1, maxIndex);
         
        return array;
    }
    
    private static int GetPivotIndex(int[] array, int minIndex, int maxIndex)
    {
        int pivot = minIndex - 1;
        int temp;

        for (int i = minIndex; i <= maxIndex; i++)
        {
            if (array[i] < array[maxIndex])
            {
                pivot++;
                
                temp = array[pivot];

                array[pivot] = array[i];

                array[i] = temp;
            }
        }

        pivot++;
        
        temp = array[pivot];

        array[pivot] = array[maxIndex];

        array[maxIndex] = temp;

        return pivot;
    }
    

    /// <summary>
    /// Пузырьковый поиск
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
    /// Сортировка выбором
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
    /// Поиск наименьшего
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
    /// Массив интов
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

    /// <summary>
    /// Показать массив
    /// </summary>
    /// <param name="array"></param>
    static void ShowArray(int[] array)
    {
        for (int i = 0; i < array.Length-1; i++)
        {
            Console.Write($"{array[i]} ");
        }
        Console.WriteLine();
    } 
}