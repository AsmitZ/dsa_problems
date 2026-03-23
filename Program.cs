// See https://aka.ms/new-console-template for more information

using Algorithms.Array_Hashset;
using Algorithms.BinarySearch;
using Algorithms.GreedyAlgorithm;
using Algorithms.Heaps;
using Algorithms.LinkedList;
using Algorithms.Recursion;
using Algorithms.Stack;
using static Algorithms.LinkedList.MergeSortedList;

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

// var pairs = FourSum.Find([-2, -1, -1, 1, 1, 2, 2], 0);
// foreach (var pair in pairs)
// {
//     Console.WriteLine(string.Join(", ", pair));
// }

// var length = LongestConsecutiveSequence.Length([100, 200, 1, 3, 4]);
// var length = LongestSubArray.Length([6, -2, 2, -8, 1, 7, 4, -10]);
// Console.WriteLine(length);

// Node head = new Node(1);
// head.Next = new Node(3);
// head.Next.Next = new Node(2);
// head.Next.Next.Next = new Node(4);

// ReverseLinkedList.PrintLinkedList(head);
// var reversedList = ReverseLinkedList.Reverse(head);
// var reversedList = ReverseLinkedList.ReverseLoop(head);
// ReverseLinkedList.PrintLinkedList(reversedList);

// var middle = MiddleElement.Find(head);
// ReverseLinkedList.PrintLinkedList(middle);

// MergeSortedList.ListNode list1 = new MergeSortedList.ListNode(1);
// list1.next = new MergeSortedList.ListNode(5);
// list1.next.next = new MergeSortedList.ListNode(7);
// list1.next.next.next = new MergeSortedList.ListNode(8);
// list1.next.next.next.next = new MergeSortedList.ListNode(9);

// ListNode list2 = new ListNode(2);
// list2.next = new ListNode(4);
// list2.next.next = new ListNode(6);

// var mergedList = MergeSortedList.Merge(list1, list2);
// MergeSortedList.PrintLinkedList(mergedList);

// var nthNode = LinkedList.FindNthNodeFromEnd(list1, 6);
// System.Console.WriteLine(nthNode.val);

// var updatedList = LinkedList.RemomveNthNodeFromEnd(list1, 1);
// MergeSortedList.PrintLinkedList(updatedList);

// NListNode list1 = new NListNode(2);
// list1.next = new NListNode(4);
// list1.next.next = new NListNode(3);

// NListNode list2 = new NListNode(5);
// list2.next = new NListNode(6);
// list2.next.next = new NListNode(4);

// var sumList = AddNumbers.AddTwoNumbers(list1, list2);
// AddNumbers.PrintLinkedList(sumList);

MergeSortedList.ListNode list = new MergeSortedList.ListNode(2);
list.next = new MergeSortedList.ListNode(4);
list.next.next = new MergeSortedList.ListNode(6);
list.next.next.next = new MergeSortedList.ListNode(8);
// list.next.next.next.next = new MergeSortedList.ListNode(4);
// list.next.next.next.next.next = new MergeSortedList.ListNode(5);
// list.next.next.next.next.next.next = new MergeSortedList.ListNode(6);

var reorderedList = ReorderList.Do(list);
MergeSortedList.PrintLinkedList(reorderedList);


// int[] start = [1, 3, 0, 5, 8, 5];
// int[] end = [2, 4, 5, 7, 9, 9];
// // int[] start = [10, 12, 20];
// // int[] end = [20, 25, 30];

// var (count, order) = NMeetingInOneRoom.Count(start, end);
// System.Console.WriteLine($"Max Meeting - {count}, in order - {string.Join(',', order)}");

// var (jobs, profit) = JobSequencing.Find(4, [(1, 4, 20), (2, 1, 10), (3, 1, 40), (4, 1, 30)]);
// var (jobs, profit) = JobSequencing.Find(5, [(1, 2, 100), (2, 1, 19), (3, 2, 27), (4, 1, 25), (5, 1, 15)]);
// System.Console.WriteLine($"Job performed - {jobs}, with profit - {profit}");

// var maxQuantity = FractionalKnapsack.Max(50, [100, 60, 120], [20, 10, 30]);
// System.Console.WriteLine($" max quantity is {maxQuantity}");

// var maxChilden = AssginCookiee.FindContentChildren([1, 2, 3], [1, 1]);
// System.Console.WriteLine(maxChilden);

// var result = SubsetSum.Find([5, 2, 1]);
// System.Console.WriteLine(string.Join(", ", result));

// UniqueSubsets.Print([1, 2, 2]);
// UniqueSubsets.PrintOptimized([1, 2, 2]);

// var sumList = CombinationSum1.Find([2, 3, 6, 7], 7);
// var sumList = CombinationSum2.Find([10, 1, 2, 7, 6, 1, 5], 8);

// var palindroms = PalindromPartition.Find("aabb");

// var permutations = ArrayPermutations.Permute_A2([1, 2, 3]);

// var nQueenAnswer = NQueenProblem.Solve(4);
// foreach (var item in nQueenAnswer)
// {
//     System.Console.Write("[");
//     System.Console.Write(string.Join(",", item));
//     System.Console.Write("] ");
// }

// var nthRoot = NthRoot.Find(3, 27);
// System.Console.WriteLine(nthRoot);

// var singleElement = SingleElementInSortedArray.Find([1, 1, 2, 2, 3, 3, 4, 5, 5, 6, 6]);
// System.Console.WriteLine(singleElement);

// var element = ElementInSortedRotatedArray.Find([4, 5, 6, 7, 0, 1, 2], 0);
// System.Console.WriteLine(element);

// var element = KthElementOfTwoSortedArray.Find([2, 3, 6, 7, 9], [1, 4, 8, 10], 5);
// System.Console.WriteLine(element);

// var arr = KthLargestElement.Find([-5, 4, 1, 2, -3], 5);
// System.Console.WriteLine(arr);


// var result = MergeKSortedArrays.Merge([[1, 2, 3], [2, 7, 8], [1, 4, 9]], 3);

// var result = KMostFrequestElement.FindByBucketSort([1, 2, 1, 2, 1, 2, 3, 1, 3, 2], 2);

// var result = NextGreaterElement.Find([6, 8, 0, 1, 3]);

// var result = NextSmallerelement.Find([4, 8, 5, 2, 25]);

// System.Console.Write("[");
// System.Console.Write(string.Join(",", result));
// System.Console.Write("] ");

// var stack = new Stack<int>();
// stack.Push(4);
// stack.Push(2);
// stack.Push(1);
// stack.Push(3);
// SortStack.Sort(stack);

// while (stack.Count > 0)
// {
//     System.Console.WriteLine(stack.Pop());
// }

// var result = SmallestElement.Search([3, 4, 5, 6, 1, 2]);
// System.Console.WriteLine("Result is " + result);