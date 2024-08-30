public class Solution {
    public int DaysBetweenDates(string date1, string date2) {
        
         DateTime dateTine1 = DateTime.Parse(date1);
         DateTime dateTine2 = DateTime.Parse(date2);
         return Math.Abs((dateTine1 - dateTine2).Days);
    }
}