using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public int solution(int n, int[] lost, int[] reserve) {        
        List<int> lost_l = lost.Where(x => !reserve.Contains(x)).ToList();
        List<int> reserve_l = reserve.Where(x => !lost.Contains(x)).ToList();
        List<int> lostMatch = lost_l.Where(x => reserve_l.Contains(x - 1) || reserve_l.Contains(x + 1)).ToList();
        List<int> reserveMatch = reserve_l.Where(x => lost_l.Contains(x - 1) || lost_l.Contains(x + 1)).ToList();
        return n - lost_l.Count() + (lostMatch.Count() > reserveMatch.Count() ? reserveMatch.Count() : lostMatch.Count());
    }
}