using System;

public class Solution {
    public string solution(string s) {
        string answer = "";
        char[] s_char = s.ToCharArray();
        Array.Sort(s_char);
        Array.Reverse(s_char);
        return string.Join("", s_char);
    }
}