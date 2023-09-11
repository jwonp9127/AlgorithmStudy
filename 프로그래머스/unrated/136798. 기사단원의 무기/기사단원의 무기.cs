using System;
using System.Linq;

public class Solution {
    public int solution(int number, int limit, int power) {
        int answer = 0;
        int[] divisor = new int[number];
        for(int i = 1; i <= number; i++){
            int cnt = 0;
            for(int j = 1; j*j <= i; j++){
                if(i % j == 0)  cnt += 2;
                if((float)i / j == j)  cnt -= 1;
            }
            divisor[i - 1] = cnt > limit ? power : cnt;
        }
        
        return divisor.Sum();
    }
}