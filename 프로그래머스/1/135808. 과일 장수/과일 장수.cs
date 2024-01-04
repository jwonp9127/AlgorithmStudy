using System;

public class Solution {
    public int solution(int k, int m, int[] score) {
        int answer = 0, temp;
        
        Array.Sort(score);
        Array.Reverse(score);
        
        for(int j = 0; j < score.Length / m; j++){
            answer += score[m * (j + 1) - 1] * m;
        }
        
        return answer;
    }
}