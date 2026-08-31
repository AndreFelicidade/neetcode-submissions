public class Solution {
    public int RemoveElement(int[] nums, int val) {
        for(int i = 0; i < nums.Length; i++)
        {
            if(nums[i]==val)
            {
                nums[i] = 999;
            }
        }

        int counter = 0;

        for(int i = 0; i < nums.Length; i++)
        {
            if(nums[i] !=999)
            {
                counter++;
            }
        }

        Array.Sort(nums);

        return counter;
    }
}