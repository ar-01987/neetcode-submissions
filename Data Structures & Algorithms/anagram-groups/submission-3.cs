public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        var groups = new List<List<string>>();
        var anagram = new Dictionary<string, int>();
        int nAnagrams = 0;
        for(int i = 0; i < strs.Length; i++) {
            int[] alpha = new int[26];
            for(int j = 0; j < strs[i].Length; j++) 
                alpha[strs[i][j] - 'a']++;
            
            string strmap = "";
            for(int n = 0; n < 26; n++) {
                for(int j = 0; j < alpha[n]; j++)
                    strmap += (char)('a' + n);
            }

            if (!anagram.ContainsKey(strmap)) {
                anagram.Add(strmap, nAnagrams);
                groups.Add(new List<string>());
                nAnagrams++;
            }
            groups[anagram[strmap]].Add(strs[i]);
        }
        return groups;
    }
}
