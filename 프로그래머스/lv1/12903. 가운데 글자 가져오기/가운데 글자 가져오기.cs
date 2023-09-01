public class Solution {
    public string solution(string s) {
        int s_l = s.Length;
        if(s_l % 2 == 0){
            return $"{s[s_l/2-1]}{s[s_l/2]}";
        }
        return s[(s_l-1)/2].ToString();
    }
}