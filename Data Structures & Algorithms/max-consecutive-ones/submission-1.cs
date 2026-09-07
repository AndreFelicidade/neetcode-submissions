public class Solution {
    public int FindMaxConsecutiveOnes(int[] nums) {
        int maxConsec = 0;
        int auxVar = 0;

        for(int i = 0; i < nums.Length; i++)
        {
            if(nums[i] == 1)
            {
                auxVar++;
                if(maxConsec < auxVar)
                {
                    maxConsec = auxVar;
                }
            }
            else 
            {
                auxVar = 0;
            }
        }

        return maxConsec;
    }
}