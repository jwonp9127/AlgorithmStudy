public class Solution {
    public string solution(string[] seoul) {
        string answer = "";
        int x = 0;
        foreach(string name in seoul){
            if(name == "Kim"){
                return "김서방은 "+x.ToString()+"에 있다";
            }
            x++;
        }
        return answer;
    }
}