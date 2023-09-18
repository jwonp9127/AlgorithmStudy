using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public string solution(string X, string Y) {
        string answer = "";
        Dictionary<char, int> ContX = new Dictionary<char, int>();
        Dictionary<char, int> ContY = new Dictionary<char, int>();
        List<char> Bf = new List<char>();
        
        foreach(char num in X){
            if(ContX.TryGetValue(num, out _))
                ContX[num]++;
            else
                ContX[num] = 1;
        }
        
        foreach(char num in Y){
            if(ContY.TryGetValue(num, out _))
                ContY[num]++;
            else
                ContY[num] = 1;
        }       
        
        foreach(KeyValuePair<char, int> item in ContX){
            if(ContY.TryGetValue(item.Key, out int num)){
                int end = item.Value < num ? item.Value : num;
                for(int i = 0; i < end; i++)
                    Bf.Add(item.Key);
            }
        }
        Bf.Sort();
        Bf.Reverse();
        answer = String.Join("", Bf).Equals("") ? "-1" : String.Join("", Bf);
        return answer[0].Equals('0') ? "0" : answer;
    }
}