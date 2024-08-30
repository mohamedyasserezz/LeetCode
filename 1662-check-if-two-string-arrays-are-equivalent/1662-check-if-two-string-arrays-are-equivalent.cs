public class Solution {
    public bool ArrayStringsAreEqual(string[] word1, string[] word2) {
        string W1 = string.Join("", word1);
        string W2 = string.Join("", word2);
        return W1 == W2;
    }
}