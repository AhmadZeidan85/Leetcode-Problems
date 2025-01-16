public class Solution {
    public int[] TwoSum(int[] nums, int target) {

     int [] solution= new int[2];

        int firstIndex, secondIndex;



        for(int i=0;i<nums.Length; i++){

            firstIndex=i;
            for(int j=i+1;j<nums.Length;j++){

                if(nums[i]+nums[j]==target){
                    secondIndex=j;

                    solution[0]=firstIndex;
                    solution[1]=secondIndex;

                    return solution;

                }


            }


        }

        return solution;
        
    }
}
