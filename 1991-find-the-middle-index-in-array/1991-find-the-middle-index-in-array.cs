public class Solution {
    public int FindMiddleIndex(int[] nums) {
      Dictionary<int, Tuple<int, int>> Sum = new(nums.Length);
 for (int i = 0; i < nums.Length; i++)
 {
     int sL = 0;
     int sR = 0;

    
         for (int j = i + 1; j < nums.Length; j++)
         {
             sR += nums[j];
         }
     
   
         for (int j = i - 1; j >= 0; j--)
         {
             sL += nums[j];
         }
     
     Sum.Add(i, new Tuple<int, int>(sL, sR));
 }
 foreach (var iL in Sum)
 {
     if (iL.Value.Item1 == iL.Value.Item2)
     {
         return iL.Key;
     }
 }
 return -1;
    }
}