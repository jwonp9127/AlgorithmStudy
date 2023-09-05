using System;

public class Solution {
    public string solution(string s, int n) {
        string answer = "";
        
        for(int i = 0; i < s.Length; i++){
            if(s[i] == ' ')
                answer += ' ';
            else if((s[i] + n) > (int)'z')
                answer += ((char)(s[i] + n - ('z' - 'a' + 1))).ToString();
            else if(s[i] <= (int)'Z' && (s[i] + n) > (int)'Z')
                answer += ((char)(s[i] + n - ('Z' - 'A' + 1))).ToString();
            else
                answer += ((char)(s[i] + n)).ToString();
        }
        return answer;
    }
}