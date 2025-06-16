public class ThreeSum{
    public List<List<int>> Get(int[] nums)
    {
        if (nums.Length == 0)
        {
            return [[]];
        }

        Array.Sort(nums);

        int i = 0;

        var result = new List<List<int>>();
        while (i < nums.Length - 2)
        {
            if (i > 0 && nums[i] == nums[i - 1])
            {
                i++;
                continue;
            }

            int firstValue = nums[i];
            int left = i + 1;
            int right = nums.Length - 1;

            while (left < right)
            {
                int sum = firstValue + nums[left] + nums[right];

                if (sum == 0)
                {
                    result.Add([firstValue, nums[left], nums[right]]);

                    while (left < right && nums[left] == nums[left + 1]) left++;
                    while (left < right && nums[right] == nums[right - 1]) right--;

                    right--;
                    left++;
                }
                else if (sum < 0)
                {
                    left++;
                }
                else
                {
                    right--;
                }
            }

            i++;
        }

        return result;
    }
}