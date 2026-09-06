public class Solution {
    public int CalPoints(string[] operations) {

        int total = 0;
        List<int> recordList = new List<int>();

        for(int i = 0; i < operations.Length; i++)
        {
            if(Int32.TryParse(operations[i], out int j))
            {
                total = total + j;
                recordList.Add(j);
            }
            else
            {
                switch(operations[i])
                {
                    case "+":
                        int sum = recordList[recordList.Count - 1] + recordList[recordList.Count - 2];
                        total = total + sum;
                        recordList.Add(sum);
                        break;

                    case "C":
                        total = total - recordList[recordList.Count - 1];
                        recordList.RemoveAt(recordList.Count - 1);
                        break;

                    case "D":
                        int doubled = recordList[recordList.Count - 1]*2;
                        total = total + doubled;
                        recordList.Add(doubled);
                        break;
                }
            }
        }
        return total;
    }
}