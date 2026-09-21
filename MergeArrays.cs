public class MergeArrays
{
    public int[] Merge(int[] arr1, int[] arr2)
    {
        var result = new int[arr1.Length + arr2.Length]; // m + n

        int i = 0, j = 0, k = 0; // k is the write index for the result array

        while (i < arr1.Length || j < arr2.Length)
        {
            if (i < arr1.Length && j < arr2.Length) // both arrays have elements
            {
                if (arr1[i] <= arr2[j])
                {
                    result[k++] = arr1[i++];
                }
                else
                {
                    result[k++] = arr2[j++];
                }
            }
            else if (i < arr1.Length) // only arr1 has remaining elements
            {
                result[k++] = arr1[i++];
            }
            else // only arr2 has remaining elements
            {
                result[k++] = arr2[j++];
            }
        }

        return result;
    }
}