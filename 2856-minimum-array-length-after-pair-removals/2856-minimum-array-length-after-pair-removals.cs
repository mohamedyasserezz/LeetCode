public class Solution {
    public int MinLengthAfterRemovals(IList<int> nums) {
       int len = nums.Count;
       int l = 0;
       int mid = nums.Count / 2;
       int r = len;
       while (l < mid && mid < len && r >= 2)
       {
           if(nums[mid] > nums[l])
           {
               l++;
               mid++;
               r -= 2;
           }
           else
           {
               mid++;
           }
       }
       return r;
    }
}