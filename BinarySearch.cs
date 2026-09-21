public class BinarySearch
{
    public int FirstOccurrence(int[] arr, int target)
    {
        int bad = -1;
        int good = arr.Length;

        while (good - bad > 1)
        {
            int mid = bad + (good - bad) / 2; // Avoids potential overflow
            if (arr[mid] >= target)
                good = mid;
            else
                bad = mid;
        }

        return good;
    }

    public int LastOccurrence(int[] arr, int target)
    {
        int bad = -1;
        int good = arr.Length;

        while (good - bad > 1)
        {
            int mid = bad + (good - bad) / 2;
            if (arr[mid] > target)
                good = mid;
            else
                bad = mid;
        }

        return bad;
    }

    public int BinarySearchIterative(int[] arr, int target)
    {
        int left = 0;
        int right = arr.Length - 1;

        while (left <= right)
        {
            int mid = left + (right - left) / 2;

            if (arr[mid] == target)
                return mid;
            else if (arr[mid] < target)
                left = mid + 1;
            else
                right = mid - 1;
        }

        return -1; // Target not found
    }

    public int BinarySearchRecursive(int[] arr, int target, int left, int right)
    {
        if (left > right)
            return -1; // Target not found

        int mid = left + (right - left) / 2;

        if (arr[mid] == target)
            return mid;
        else if (arr[mid] < target)
            return BinarySearchRecursive(arr, target, mid + 1, right);
        else
            return BinarySearchRecursive(arr, target, left, mid - 1);
    }

    /// <summary>
    /// A generic binary search method that uses a predicate to determine the "good" side.
    /// </summary>
    /// <param name="arr">The sorted array to search.</param>
    /// <param name="predicate">A function that returns true for "good" elements and false for "bad" elements.</param>
    /// <returns>The index of the first "good" element, or arr.Length if all elements are "bad".</returns>
    public int BinarySearchPredicate(int[] arr, Func<int, bool> predicate)
    {
        int bad = -1;
        int good = arr.Length;

        while (good - bad > 1)
        {
            int mid = bad + (good - bad) / 2;
            if (predicate(arr[mid]))
                good = mid;
            else
                bad = mid;
        }

        return good; // To get the last occurance, you can do good - 1, but you need to check if good is not equal to arr.Length
    }
}