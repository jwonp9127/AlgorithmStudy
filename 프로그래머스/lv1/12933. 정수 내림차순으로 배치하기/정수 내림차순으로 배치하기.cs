using System;
using System.Linq;

public class Solution {
    public long solution(long n) {
        long answer = 0;
        
        char[] n_char = n.ToString().ToCharArray();
        Array.Sort(n_char);
        Array.Reverse(n_char);
        answer = long.Parse(String.Join("", n_char));
        return answer;
    }
}