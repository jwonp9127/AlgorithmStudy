using System;

public class Solution {
    public int solution(int a, int b, int n) {
        int temp = 0, answer = 0;
        
        while(n >= a){
            temp = n % a;
            answer += (n / a) * b;
            n = (n / a) * b + temp;
        }
        
        return answer;
    }
}