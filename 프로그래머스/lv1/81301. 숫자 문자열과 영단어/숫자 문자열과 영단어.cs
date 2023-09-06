using System;

public class Solution {
    public int solution(string s) {
        string answer = "";
        for(int i = 0; i < s.Length; i++){
            // isNumber
            if(int.TryParse(s[i].ToString(), out int _)){
                answer += s[i];
                continue;
            }

            switch(s[i]){
                case 'z':
                    answer += "0";
                    i += 3;
                    break;
                case 'o':
                    answer += "1"; 
                    i += 2;
                    break;
                case 't':
                    answer += s[i+1] == 'w' ? "2" : "3";
                    i += s[i+1] == 'w' ? 2 : 4;
                    break;
                case 'f':
                    answer += s[i+1] == 'o' ? "4" : "5";
                    i += 3;
                    break;
                case 's':
                    answer += s[i+1] == 'i' ? "6" : "7";
                    i += s[i+1] == 'i' ? 2 : 4;
                    break;
                case 'e':
                    answer += "8";
                    i += 4;
                    break;
                case 'n':
                    answer += "9";
                    i += 3;
                    break;
            }  
        }
        return int.Parse(answer);
    }
}