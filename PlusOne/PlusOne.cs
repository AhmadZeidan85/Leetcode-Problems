public class Solution {
    public int[] PlusOne(int[] digits) {

         var result = new List<int>();

            var onHand = 1;
            var value = 0;
            for (int i = digits.Length - 1; i >= 0; i--)
            {
                value = digits[i] + onHand;
                
                onHand = value == 10 ? 1 : 0;
               
                result.Insert(0, value % 10);
            }

            if (onHand >= 1)
                result.Insert(0, onHand);


        

            return result.ToArray();

        
        
    }
}
