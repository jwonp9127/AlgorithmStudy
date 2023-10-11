using System;
using System.Linq;
using System.Text;

public class Solution {
    public int solution(int[] ingredient) {
        int answer = 0, i = 0;
        StringBuilder num = new StringBuilder(string.Join("", ingredient));
        while(true){
            for(i = 0; i < num.Length - 3; i++){
                if(num[i] == '1' && num[i+1] == '2'
                   && num[i+2] == '3' && num[i+3] == '1'){
                    num.Replace("1231", "", i, 4);
                    answer++;
                    i = i-3 < 0 ? -1 : i-4;
                }
                if(i == num.Length - 4) return answer;
            }
            if(num.Length < 4) return answer;
        }
        return answer;
    }
}