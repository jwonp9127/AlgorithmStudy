using System;

public class Solution {
    public string solution(string s) {
        string[] sp = s.Split(" ");
        string answer = "";

        foreach(string st in sp){
            for(int i = 0; i < st.Length; i++){
                answer += (i % 2 == 1) ? char.ToLower(st[i]) : char.ToUpper(st[i]);
            }
            if(s.Length != answer.Length)
                answer += " ";
        }
        return answer;
    }
}