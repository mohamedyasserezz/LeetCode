public class Solution {
    public bool HalvesAreAlike(string s) {
        char[] vowels = ['a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U'];
        char[] sa = s.ToCharArray();
        int a = 0, b = 0;
        for (int i = 0; i < s.Length / 2; i++)
        {
            for (int j = 0; j < vowels.Length; j++)
            {
                if (sa[i] == vowels[j])
                {
                    a++;
                    break;
                }
            }
        }
        for (int i = s.Length/2; i < s.Length; i++)
        {
            for (int j = 0; j < vowels.Length; j++)
            {
                if (sa[i] == vowels[j])
                {
                    b++;
                    break;
                }
            }
        }
        return (a == b);
    }
}