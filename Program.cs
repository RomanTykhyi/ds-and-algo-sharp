Console.WriteLine("Hello from ds-and-algo-sharp!");

var data = new int[] { 5, 10, 15, 20, 25, 30, 35, 40, 45, 50 };
                    // 0  1   2   3   4   5   6   7   8   9

var target = 25;
var index = BinarySearch(data, target);

Console.WriteLine($"Target {target} found at index: {index}");

int BinarySearch(int[] arr, int target)
{
    int bad = -1;
    int good = arr.Length;
    
    while (good - bad > 1)
    {
        int mid = bad + (good - bad) / 2;
        if (arr[mid] >= target)
            good = mid;
        else
            bad = mid;
    }

    return good;
}