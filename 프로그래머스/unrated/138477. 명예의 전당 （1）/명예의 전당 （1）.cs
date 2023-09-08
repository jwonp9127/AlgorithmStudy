using System;

public class Solution {
    public int[] solution(int k, int[] score) {
        int[] answer = new int[score.Length];
        int[] HOF = new int[k];
        for(int i = 0; i < score.Length; i++){
            for(int j = 0; j < k; j++){
                if(score[i] > HOF[j]){
                    HOF[j] = score[i];
                    break;
                }
            }
            Array.Sort(HOF);
            answer[i] = i + 1 < k ? HOF[k - i - 1] : HOF[0];
        }
        
        
        return answer;
    }
}