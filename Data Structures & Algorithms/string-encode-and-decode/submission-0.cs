public class Solution {
    public string DecimalToBinary(int letter) {
        string output = "";
        while(letter > 0) {
            if(letter % 2 == 1) {
                output = '1' + output;
            } else {
                output = '0' + output;
            }
            letter = letter / 2;
        }

        while(output.Length < 8) {
            output = '0' + output;
        }

        return output;
    }

    public int BinaryToDecimal(string binLetter) {
        int output = 0;
        int k = binLetter.Length - 1;

        for (int i = 0; i < binLetter.Length; i++) {
            int bit = binLetter[k] - '0';
            output += bit * (int)Math.Pow(2, i);
            k--;
        }
        return output;
    }

    public string Encode(IList<string> strs) {
        string encodedString = "";
        for(int i = 0; i < strs.Count; i++) {
            string encodeCount = DecimalToBinary(strs[i].Length);
            encodedString += encodeCount;

            for(int j = 0; j < strs[i].Length; j++) {
                string enLetter = DecimalToBinary((int)strs[i][j]);
                encodedString += enLetter;
            }
        }
        return encodedString;
    }

    public List<string> Decode(string s) {
        var decodedStrings = new List<string>();
        int encodedStringLength = s.Length;
        int pos = 0;
        
        while(pos < encodedStringLength) {
            int strLength = 0;
            string len = "";

            for(int i = 0; i < 8; i++) {
                len = len + s[pos];
                pos++;
            }

            strLength = BinaryToDecimal(len);
            string decodedStr = "";

            while(strLength > 0) {
                string tempHolder = "";
                for(int i = 0; i < 8; i++) {
                    tempHolder = tempHolder + s[pos];
                    pos++;
                }
                decodedStr = decodedStr + (char)BinaryToDecimal(tempHolder); // remember char
                strLength--;
            }
            decodedStrings.Add(decodedStr);
        }

        return decodedStrings;
    }
}
