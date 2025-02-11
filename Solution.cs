public class Solution {
    public bool DetectCapitalUse(string word) {
        int n = word.Length;
        bool allUpper = true, allLower = true, firstUpperRestLower = char.IsUpper(word[0]);

        for (int i = 1; i < n; i++) {
            if (char.IsUpper(word[i])) {
                allLower = false;
                firstUpperRestLower = false;
            } else {
                allUpper = false;
            }
        }

        return allUpper || allLower || firstUpperRestLower;
    }
}