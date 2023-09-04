using System;

public class Solution {
    public int solution(int n) {
        string n_3 = "";
        while(n > 0){
            n_3 = (n % 3).ToString() + n_3;
            n = (n - n % 3) / 3;
        }
        int i = 1, answer = 0;
        foreach(char num in n_3){
            answer += int.Parse(num.ToString()) * i;
            i *= 3;
        }
        return answer;
    }
}
       