Console.WriteLine("Hello from ds-and-algo-sharp!");

var data = new int[] { 5, 10, 15, 20, 25, 30, 35, 40, 45, 50 };
                    // 0  1   2   3   4   5   6   7   8   9

var target = 25;
var index = new BinarySearch().FirstOccurrence(data, target);

Console.WriteLine($"Target {target} found at index: {index}");

var dataForlastOccurrence = new int[] { 5, 10, 15, 20, 25, 25, 25, 25, 30, 35, 40, 45, 50 };
                                     // 0  1   2   3   4   5   6   7   8   9   10  11  12

var lastIndex = new BinarySearch().LastOccurrence(dataForlastOccurrence, target);
Console.WriteLine($"Last occurrence of target {target} found at index: {lastIndex}");

var array1 = new int[] { 1, 3};
var array2 = new int[] { 2, 4, 6, 8, 12, 14, 16 };
var mergedArray = new MergeArrays().Merge(array1, array2);

Console.WriteLine(mergedArray[mergedArray.Length - 1]);
Console.WriteLine("Merged Array: " + string.Join(", ", mergedArray));

var sw = new System.Diagnostics.Stopwatch();

//var unsortedArray = new int[] { 2, 4, 1, 5, 8, 3, 9, 0, 12, -2, 4, -6, 15 };
var unsortedArray = new int[] { 1, 3, 5, 6, 17, 32, 44, 45, 62, 77, 87, 88, 92, 101 };
Console.WriteLine("N: " + unsortedArray.Length);

sw.Start();
var sorted = new BubbleSort().DoBubbleSortOptimized(unsortedArray);
sw.Stop();

Console.WriteLine($"Bubble sorted: {string.Join(',', sorted)}. Elapsed: {sw.Elapsed}");