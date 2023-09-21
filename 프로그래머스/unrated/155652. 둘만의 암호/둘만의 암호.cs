using System;
using System.Linq;

public class Solution {
    public string solution(string s, string skip, int index) {
        string answer = "";
        char[] s_s = s.ToCharArray();
                
        for(int i = 0; i < s_s.Length; i++){
            for(int j = 1; j <= index; j++){
                s_s[i] = s_s[i] + 1 > 'z' ? 'a' : (char)(s_s[i] + 1);
                if(skip.Contains((char)(s_s[i])))
                    j--;
            }
        }

        return string.Join("", s_s);
    }
}