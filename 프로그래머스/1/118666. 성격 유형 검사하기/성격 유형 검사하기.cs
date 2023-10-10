using System;
using System.Collections.Generic;

public class Solution {
    public string solution(string[] survey, int[] choices) {
        string answer = "RCJA";
        Dictionary<char, int> scores = new Dictionary<char, int>();
        
        scores.Add('R', 0);
        scores.Add('T', 0);
        scores.Add('C', 0);
        scores.Add('F', 0);
        scores.Add('J', 0);
        scores.Add('M', 0);
        scores.Add('A', 0);
        scores.Add('N', 0);

        for(int i = 0; i < survey.Length; i++){
            if(choices[i] < 4)
                scores[survey[i][0]] += 4 - choices[i];
            else
                scores[survey[i][1]] += choices[i] - 4;
        }
        
        if(scores['R'] < scores['T'])   answer = answer.Replace('R', 'T');
        if(scores['C'] < scores['F'])   answer = answer.Replace('C', 'F');
        if(scores['J'] < scores['M'])   answer = answer.Replace('J', 'M');
        if(scores['A'] < scores['N'])   answer = answer.Replace('A', 'N');

        return answer;
    }
}