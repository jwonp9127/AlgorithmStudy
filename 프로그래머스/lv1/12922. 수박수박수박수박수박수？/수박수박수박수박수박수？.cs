public class Solution {
    public string solution(int n) {
        string answer = "";
        while(n-- > 0){
            answer += answer.Length % 2 == 0? "수":"박";
        }
        return answer;
    }
}