using System;

public class Solution {
    public int solution(int left, int right) {
        int answer = 0, divisor;
        for(int i = left; i <= right; i++){
            for(int j = 1; j * j <= i; j++){
                if(j * j == i){
                    answer -= 2 * i;
                    break;
                }
            }
            answer += i;
        }
        return answer;
    }
}