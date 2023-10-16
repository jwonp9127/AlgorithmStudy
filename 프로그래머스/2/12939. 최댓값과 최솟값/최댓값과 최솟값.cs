using System.Collections.Generic;
using System;
using System.Linq;

public class Solution {
    public string solution(string s) {
        List<int> s_l = new List<int>(s.Split(' ').Select(Int32.Parse).ToList());
        s_l.Sort();
        return s_l[0] + " " + s_l[s_l.Count - 1];
    }
}