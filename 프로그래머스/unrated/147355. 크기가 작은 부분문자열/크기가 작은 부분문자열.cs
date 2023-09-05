using System;

public class Solution {
    public int solution(string t, string p) {
        int answer = 0, t_l = t.Length, p_l = p.Length;
        
        for(int i = 0; i < t_l - p_l + 1; i++){
            if(long.Parse(t.Substring(i, p_l)) <= long.Parse(p)){
                answer++;
            }
        }
        return answer;
    }
}