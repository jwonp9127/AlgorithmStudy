public class Solution {
    public string solution(string[] seoul) {
        string answer = "", name;
        for(int i = 0; i < seoul.Length; i++){
            name = seoul[i];
            if(name.Length != 3){
                continue;
            }
            if(name[0] != 'K'){
                continue;
            }
            if(name[1] != 'i'){
                continue;
            }
            if(name[2] != 'm'){
                continue;
            }
            answer = "김서방은 " + i + "에 있다";
        }
        return answer;
    }
}