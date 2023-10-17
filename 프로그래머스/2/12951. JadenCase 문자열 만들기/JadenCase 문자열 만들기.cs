public class Solution {
    public string solution(string s) {
        string[] s_a = s.Split(' ');
        string answer = "";
        for(int i = 0; i < s_a.Length; i++){
            if(s_a[i].Equals("")){
                if(i != s_a.Length - 1) answer += " ";
                continue;
            }
            answer += s_a[i].Substring(0, 1).ToUpper();
            answer += s_a[i].Substring(1).ToLower();
            if(i != s_a.Length - 1) answer += " ";
        }
        return answer;
    }
}