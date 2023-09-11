using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int[] lottos, int[] win_nums) {
            int[] answer = new int[2];

            List<int> lottosList = new List<int>();
            List<int> winNumsList = new List<int>();


            for(int i = 0; i< lottos.Length; i++)
            {
                lottosList.Add(lottos[i]);
                winNumsList.Add(win_nums[i]);
            }

            int maxWinNum = 0;
            int minWinNum = 0;

            for(int i =0; i< lottosList.Count; i++)
            {
                if (winNumsList.Contains(lottosList[i]))
                {
                    minWinNum++;
                }
                else if(lottosList[i] == 0) 
                {
                    maxWinNum++;
                }
            }

            maxWinNum += minWinNum;

            if (minWinNum >= 2)
                answer[1] = 7 - minWinNum;
            else
                answer[1] = 6;

            if (maxWinNum >= 2)
                answer[0] = 7 - maxWinNum;
            else
                answer[0] = 6;


            return answer;
    }
}