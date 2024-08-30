public class Solution {
     public int MinimumBoxes(int[] apple, int[] capacity)
     { 
         Array.Sort(capacity,(a,b) =>b.CompareTo(a));
         Array.Sort(apple);
         int sum = 0;
         int result = 0;

         for (int i = 0; i < apple.Length; i++)
         {
             sum += apple[i];
         }
         for (int i = 0; i < capacity.Length; i++)
         {
             if (sum <= 0)
                 break;
             sum -= capacity[i];
             result++;
         }
         return result;
     }
}