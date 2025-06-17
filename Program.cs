// See https://aka.ms/new-console-template for more information

using Algorithms.Array_Hashset;

// Console.WriteLine("Hello, World!");

// PascalTriangle.GetPascalTriangle(5);

// var result = NextPermutation.GetNextPermutation(new int[] { 3, 2, 1 });
// var result = NextPermutation.GetNextPermutation(new int[] { 1, 2, 3 });
// Console.WriteLine(string.Join(", ", result));

// KadanesAlgorithm.GetContinousLargestSubArraySum([-2, 1, -3, 4, -1, 2, 1, -5, 4]);

// InPaceSort0s1s2s.Sort([0, 1, 2, 0, 2, 1, 0]);

// StockBuyAndSell.GetMaxProfit([7, 1, 5, 3, 6, 4]);

// Rotate90Degree.Rotate([[1, 2, 3], [4, 5, 6], [7, 8, 9]]);

// MergeOverlappingSubInterval.Merge([[1, 3], [2, 6], [8, 10], [15, 18]]);

// MergeSortedArrays.Merge([1, 4, 8, 10], [2, 3, 9], 4, 3);

// DuplicateInArrayWithN_1Elements.FindDuplicate([1, 3, 4, 2, 2]);

// RepeatingAndMissingNumber.FindUsingMaths([3, 1, 2, 5, 4, 6, 7, 5]);

// RepeatingAndMissingNumber.FindUsingBitManipulation([3, 1, 2, 5, 4, 6, 7, 5]);

// CountInversions.Count([5, 4, 3, 2, 1]);

// var result = SearchSorted2DArray.Find([[1, 2, 4], [6, 7, 8], [9, 10, 34]], 3, 3, 78);
// System.Console.WriteLine($"Fount the target : {result}");

// PowXRaisedToN.Pow(2, 10);

// int result = MajorElementMoreThanHalf.Find([2, 2, 2, 3, 3]);
// System.Console.WriteLine($"Major element is {result}");

// var result = MajorElementMoreThan1By3.Find([11, 33, 33, 11, 33, 11]);
// System.Console.WriteLine($"Major element is {string.Join(", ", result)}");

// UniquePath.FindByCombination(3, 7);
// UniquePath.FindByRescursion(3, 7);
// UniquePath.FindByDPRecursion(3, 7);

// var reversePairs = new ReversePairs().Find([2,4,3,5,1]);
// System.Console.WriteLine(reversePairs);

// var pairs = new ThreeSum().Get([-1, 0, 1, 2, -1, -4]);
// foreach (var pair in pairs)
// {
//     Console.WriteLine(string.Join(", ", pair));
// }

var pairs = FourSum.Find([-2, -1, -1, 1, 1, 2, 2], 0);
foreach (var pair in pairs)
{
    Console.WriteLine(string.Join(", ", pair));
}