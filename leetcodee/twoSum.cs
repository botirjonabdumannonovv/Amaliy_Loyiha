
namespace leetcodee;

//public class Solution
//{
//    public int[] TwoSum(int[] nums, int target)
//    {
//        int[] indices = { };

//        for (int i = 0; i < nums.Length; i++)
//        {
//            for (int j = 0; j < nums.Length; j++)
//            {
//                if (nums[i] == nums[j])
//                    continue;
//                else if (nums[i] + nums[j] == target)
//                    indices = indices.Append(i).ToArray();
//            }
//        }
//        return indices;
//    }
//}

public class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
        for(int i = 0; i < nums.Length; i++)
        {
            for (int j = i + 1; j < nums.Length; j++)
            {
                if (nums[i] + nums[j] == target)
                {
                    return new int[] { i, j };
                }
            }
        }
        throw new ArgumentException("No Two sum exception");
    }
}