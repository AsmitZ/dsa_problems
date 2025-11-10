namespace Algorithms.Recursion;

// Question-https://takeuforward.org/data-structure/combination-sum-1/
public static class CombinationSum1
{
    public static IList<IList<int>> Find(int[] candidates, int target)
    {
        var ansList = new List<IList<int>>();
        FindSubset(candidates, target, 0, [], ansList);
        return ansList;
    }
    
    private static void FindSubset(int[] candidates, int target, int index,
        List<int> subset, List<IList<int>> ansList)
    {
        if (index == candidates.Length)
        {
            if (target == 0)
            {
                ansList.Add([.. subset]);
            }
            return;
        }

        if (candidates[index] <= target) // pick
        {
            subset.Add(candidates[index]);
            FindSubset(candidates, target - candidates[index], index, subset, ansList);
            subset.RemoveAt(subset.Count - 1);
        }
        FindSubset(candidates, target, index + 1, subset, ansList); // No pick
    }
}