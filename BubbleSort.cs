public class BubbleSort
{
    public int[] DoBubbleSortOptimized(int[] arr)
    {
        if (arr == null || arr.Length <= 1)
        {
            return arr;
        }
        
        for(int i = 0; i < arr.Length; ++i)
        {
            // to optimize the algorithm, we can stop if no swaps were made in the inner loop
            var swapped = false;

            // -i is an optimization to avoid checking the already sorted elements at the end of the array
            // and -1 is to avoid index out of bounds when accessing arr[j + 1]
            for(int j = 0; j < arr.Length - 1 - i; ++j) 
            {
                Console.WriteLine("comparing elements");

                if(arr[j] > arr[j + 1])
                {
                    var temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;

                    swapped = true;    
                }
            }

            // If no swaps were made, the array is already sorted
            if(!swapped)
            {
                break;  
            }
        }

        return arr;
    }

    public int[] DumbBubbleSort(int[] arr)
    {
        if (arr == null || arr.Length < 2)
        {
            return arr;
        }

        var n = arr.Length;

        for (int i = 0; i < n; ++i)
        {
            for (int j = 0; j < n - 1; ++j)
            {
                Console.WriteLine("comparing elements");

                if (arr[j] > arr[j + 1])
                {
                    var tmp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = tmp;
                }
            }
        }

        return arr;
    }
}