using System;

public class Solution {
    int cnt = 0, del = 0;
    public string change(string s){
        string s_n = s.Replace("0", "");
        if(s.Length == 1)   return s;
        else{
            del += s.Length - s_n.Length;
            cnt++;
            return change(LenToBinary(s_n.Length));
        }

    }

    public string LenToBinary(int len){
        string str = "";
        while(len / 2 >= 1){
            str = (len % 2) + str;
            len /= 2;
        }
        str = (len % 2) + str;
        return str;   
    }
    
    public int[] solution(string s) {
        change(s);
        return new int[]{cnt, del};
    }
    
    
}