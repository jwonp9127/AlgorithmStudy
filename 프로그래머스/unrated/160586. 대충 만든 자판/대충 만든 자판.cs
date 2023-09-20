using System;

public class Solution {
    public int[] solution(string[] keymap, string[] targets) {
        int[] answer = new int[targets.Length];
        for(int i = 0; i < targets.Length; i++){
            int ans = 0;
            foreach(char spel in targets[i]){
                int min = 1000;
                foreach(string key in keymap){
                    int index = key.IndexOf(spel) + 1;
                    if(index > 0 && index < min)
                        min = index;                    
                }
                if(min == 1000){
                    ans = -1;
                    break;
                }
                else
                    ans += min;
            }
            answer[i] = ans;
        }
        return answer;
    }
}