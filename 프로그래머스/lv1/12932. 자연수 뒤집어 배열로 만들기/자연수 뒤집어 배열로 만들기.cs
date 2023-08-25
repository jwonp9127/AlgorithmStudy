using System;

public class Solution {
    public int[] solution(long n) {
        int num;
        long n1 = n;
        for(num = 0; n1 >= 1; num++)    n1 /= 10;
        int[] answer = new int[num];
        for(int i = 0; n >= 1; i++)
        {
            answer[i] = (int) (n % 10);
            n /= 10;
        }
        return answer;
    }
}