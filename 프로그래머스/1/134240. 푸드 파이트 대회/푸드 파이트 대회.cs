using System;

public class Solution {
    public string solution(int[] food) {
        string answer = "";
        int num;
        
        for(int i = 1; i < food.Length; i++){
            num = food[i];
            food[i] = num % 2 == 0 ? num / 2 : (num - 1) / 2;
            for(int j = 0; j < food[i]; j++){
                answer += i;
            }
        }
        
        char[] reverse_c = answer.ToCharArray();
        Array.Reverse(reverse_c);
        
        return answer + "0" + String.Join("", reverse_c);
    }
}