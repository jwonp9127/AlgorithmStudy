using System.Collections.Generic;
using System.Linq;

public class Solution {
    public string[] solution(string[] strings, int n) {
        Dictionary<string, string> dic= new Dictionary<string, string>();
        
        for(int i = 0; i < strings.Length; i++)
            dic.Add(strings[i], strings[i][n].ToString());
        
        string[] answer = dic.OrderBy(x => x.Value).ThenBy(x => x.Key).Select(x => x.Key).ToArray();

        return answer;
    }
}