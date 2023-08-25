using System;
using System.Linq;

public class Solution {
    public long solution(long n) {
        long answer = 0;
        
        string n_str = n.ToString();
        int[] n_int = Array.ConvertAll(n_str.ToArray(), item => int.Parse(item.ToString()));
        Array.Sort(n_int);
        Array.Reverse(n_int);
        answer = long.Parse(String.Join("", n_int));
        return answer;
    }
}