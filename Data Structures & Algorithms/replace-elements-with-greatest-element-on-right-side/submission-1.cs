public class Solution {
    public int[] ReplaceElements(int[] arr) {

        int length = arr.Length;
        int currentHighest = -1;
        int[] answerArray = new int[length];

        for(int i = length - 1; i >= 0; i--)
        {
            answerArray[i] = currentHighest;
            currentHighest = Math.Max(arr[i], currentHighest);
        }

        return answerArray;
    }
}