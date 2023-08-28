using System;

public class Solution {
    public int solution(int num) {
        
        int answer;
        long num2 = (long)num;
        
        for(answer = 0; answer < 500; answer++)
        {
            if(num2 == 1)    return answer;
            num2 = (num2 % 2 == 0 ? num2 / 2 : num2 * 3 + 1);
        }
        return -1;
    }
}