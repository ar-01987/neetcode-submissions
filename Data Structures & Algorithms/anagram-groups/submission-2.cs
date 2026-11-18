public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        var groups = new List<List<string>>();
        var anagram = new Dictionary<string, int>();
        int variation = 0;

        for(int i = 0; i < strs.Length; i++) {
            int[] alphabet = new int[26];
            foreach(char c in strs[i]) alphabet[c-'a']++;

            char[] result = new char[strs[i].Length];
            int pos = 0;
            for(int j = 0; j < 26; j++) {
                for(int k = 0; k < alphabet[j]; k++) {
                    result[pos++] = (char)('a'+j);
                }
            }

            string sorted = new string(result);
            if(anagram.ContainsKey(sorted)) {
                groups[anagram[sorted]].Add(strs[i]);
            } else {
                anagram[sorted] = variation;
                variation++;

                var list = new List<string>();
                list.Add(strs[i]);

                groups.Add(list);
            }
        }
        return groups;
    }
}
