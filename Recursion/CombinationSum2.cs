namespace Algorithms.Recursion;

// Question-https://takeuforward.org/data-structure/combination-sum-ii-find-all-unique-combinations/
public static class CombinationSum2
{
    public static IList<IList<int>> Find(int[] candidates, int target)
    {
        var ansList = new List<IList<int>>();
        Array.Sort(candidates); // very important
        FindSubset(candidates, target, 0, [], ansList);
        return ansList;
    }
    
    private static void FindSubset(int[] candidates, int target, int index,
        List<int> subset, List<IList<int>> ansList)
    {
        if (target == 0)
        {
            ansList.Add([.. subset]);
            return;
        }

        for (int i=index; i<candidates.Length; i++)
        {
            if (i > index && candidates[i] == candidates[i - 1]) continue;
            if (candidates[i] > target) break;

            subset.Add(candidates[i]);
            FindSubset(candidates, target - candidates[i], i + 1, subset, ansList);
            subset.RemoveAt(subset.Count - 1);
        }
    }
}