using System;

public class Solution {
    public int[] solution(string s) {
        int[] answer = new int[s.Length];
        
        for(int i = 0; i < s.Length; i++){
            for(int j = i - 1; j >= 0; j--){
                if(s[j] == s[i]){
                    answer[i] = i - j;
                    break;
                }
            }
            if(answer[i] == 0)
                answer[i] = -1;
        }
        
        return answer;
    }
}