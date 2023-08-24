using System.Linq;
using System;


public class Solution {
    public long[] solution(int x, int n)
    {
        long[] answer = new long[n];
        for (int cnt = 0; cnt < n; cnt++)
        {
            answer[cnt] = (cnt + 1) * (long)x;
        }
        return answer;
    }
}