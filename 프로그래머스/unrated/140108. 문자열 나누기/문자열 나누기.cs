using System;

public class Solution {
    public int solution(string s) {
        int answer = 0;
        while(s.Length > 0){
            int sameCnt = 0, diffCnt = 0;
            char same = s[0];
            foreach(char spel in s){
                if(spel == same)
                    sameCnt++;
                else
                    diffCnt++;
                if(sameCnt == diffCnt)
                    break;
            }
            s = s.Substring(sameCnt + diffCnt);
            answer++;
        }
        return answer;
    }
}