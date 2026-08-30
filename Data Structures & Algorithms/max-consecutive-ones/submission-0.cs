public class Solution {
    public int FindMaxConsecutiveOnes(int[] nums) {
        int saveNumber = 0;
        int consecutiveOnes = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] == 1)
            {
                consecutiveOnes++;
                if(consecutiveOnes >= saveNumber)
                {
                    saveNumber = consecutiveOnes;
                }
            }
            else
            {
                consecutiveOnes = 0;
            }
        }
        return saveNumber;
    }
}