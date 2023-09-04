using System;

public class Solution {
    public int solution(int left, int right) {
        int answer = 0;
        
        for(int num = left; num <= right; num++){
            int cnt = 1;
            for(int i = 1; i <= num/2; i++){
                if(num % i == 0)
                    cnt++;
            }
            answer += cnt % 2 == 0? num : -num;
        } 
        return answer;
    }
}