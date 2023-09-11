using System;

public class Solution {
    public string solution(string[] cards1, string[] cards2, string[] goal) {
        int cards1_i = 0, cards2_i = 0;
        foreach(string word in goal){
            if(cards1_i < cards1.Length && cards1[cards1_i] == word)
                cards1_i++;
            else if(cards2_i < cards2.Length && cards2[cards2_i] == word)
                cards2_i++;
            else
                return "No";
        }
        return "Yes";
    }
}