public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        var groups = new List<List<string>>();
        var anagram = new Dictionary<string, int>();
        int anagramCount = 0;

        for(int i = 0; i < strs.Length; i++) {
            int[] alphaCount = new int[26];
            for(int pos = 0; pos < strs[i].Length; pos++) {
                alphaCount[strs[i][pos] - 'a']++;
            }

            string letters = "";
            for(int j = 0; j < 26; j++) {
                if(alphaCount[j] == 0) continue;
                for(int k = alphaCount[j]; k > 0; k--) {
                    letters += (char)(j + 'a');
                }
            }

            if(!anagram.ContainsKey(letters)) {
                anagram.Add(letters, anagramCount++);
                groups.Add(new List<string>()); // only miss
            }
            groups[anagram[letters]].Add(strs[i]);
        }

        return groups;
    }
}
