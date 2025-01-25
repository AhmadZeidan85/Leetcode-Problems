public class Solution {
    public int MajorityElement(int[] nums) {

         Dictionary<int, int> dictionary =  
                       new Dictionary<int, int>(); 
    int maxValue=0;
    int majorityElement=0;



    for(int i=0;i<nums.Length;i++){

        if (dictionary.ContainsKey(nums[i])){

            dictionary[nums[i]] += 1;


        }

        else{

             dictionary.Add(nums[i], 1);

        }
    }

           foreach (KeyValuePair<int, int> pair in dictionary)
            {
                if (pair.Value>maxValue) {
                   maxValue= pair.Value;
                   majorityElement=pair.Key;

                }
            }

        





    return majorityElement;
        
    }
        
    }
