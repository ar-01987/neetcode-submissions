public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        var groups = new List<List<string>>();
        bool[] used = new bool[strs.Length];
        
        for(int i = 0; i < strs.Length; i++) {
            if (used[i] == true) continue;
            var anagram = new List<string>();
            anagram.Add(strs[i]);
            used[i] = true;
            for(int j = i + 1; j < strs.Length; j++) {
                if (used[j] == true || strs[i].Length != strs[j].Length) continue;

                int[] alphabet = new int[26];
                for(int k = 0; k < strs[j].Length; k++) {
                    alphabet[strs[j][k] - 'a']++;
                    alphabet[strs[i][k] - 'a']--;
                }
                
                int zeroOut = 0;
                foreach(int n in alphabet) {
                    if (n != 0) break;
                    zeroOut++;
                }

                if(zeroOut == 26) {
                    anagram.Add(strs[j]);
                    used[j] = true;
                }
            }
            groups.Add(anagram);
        }
        return groups;
    }
}
