using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public string solution(string X, string Y) {
        string answer = "";
        List<char> X_list = X.ToList(), Y_list = Y.ToList();
        
        X_list.Sort();
        X_list.Reverse();
        Y_list.Sort();
        Y_list.Reverse();
        
        int commonCount = 0, YNumCnt;
        char num;

        while(X_list.Count > 0){
            num = X_list[0];
            YNumCnt = Y_list.IndexOf(num) > -1 ? Y_list.LastIndexOf(num) - Y_list.IndexOf(num) + 1 : 0;

            if(YNumCnt > 0){
                commonCount = X_list.LastIndexOf(num) + 1 < YNumCnt ? X_list.LastIndexOf(num) + 1 : YNumCnt;
                answer += new String(num, commonCount);
            }
            
            X_list.RemoveAll(s => s == num);
            Y_list.RemoveAll(s => s == num);
        }
        
        if(answer.Length == 0){
            return "-1";
        }
        else if(answer[0] == '0'){
            return "0";
        }
        else{
            return answer;
        }   
    }
}