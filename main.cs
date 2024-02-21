public class Solution {
    public int ArraySign(int[] nums) {
        BigInteger multi = 1;
        for(int i = 0; i < nums.Length; i++)
        {
            multi *= nums[i];
        }
        if(multi > 0)
        {
            return 1;
        }
        else if (multi < 0)
        {
            return -1;
        }
        return 0;
    }
}
