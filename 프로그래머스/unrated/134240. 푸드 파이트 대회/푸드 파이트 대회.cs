using System;

public class Solution {
    public string solution(int[] food) {
        string answer = "";
        for(int i = 1; i < food.Length; i++){
            if(food[i] % 2 != 0)
                food[i]--;
            
            for(int j = 0; j < food[i] / 2; j++){
                answer += i.ToString();
            }
        }
        char[] answerArray = answer.ToCharArray();
        Array.Reverse(answerArray);
        answer = answer + "0" + (string.Join("", answerArray));

        return answer;
    }
}