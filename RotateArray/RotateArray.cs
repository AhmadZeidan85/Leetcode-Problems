public class Solution {
    public void Rotate(int[] nums, int k) {

           if (k >= nums.Length)
                k %= nums.Length;
      for (int start = 0, count = 0; start < k && count < nums.Length; start++)
            {
               int curr = start;
                var prevValue = nums[curr];
                do
                {
                    int next = curr + k;
                    if (next >= nums.Length)
                        next -= nums.Length;

                    int nextvalue = nums[next];
                    nums[next] = prevValue;
                    prevValue = nextvalue;
                    curr = next;

                    count++;
                } while (start != curr);
            }


}
        

        
        
    }
