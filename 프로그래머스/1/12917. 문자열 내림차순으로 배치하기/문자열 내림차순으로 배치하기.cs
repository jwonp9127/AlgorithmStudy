using System;

public class Solution {
    public string solution(string s) {
        char[] a_s = s.ToCharArray();
        Array.Sort(a_s);
        Array.Reverse(a_s);
        return String.Join("", a_s);
    }
}