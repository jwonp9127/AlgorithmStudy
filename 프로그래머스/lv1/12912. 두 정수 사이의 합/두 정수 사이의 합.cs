public class Solution {
    public long solution(int a, int b) {
        long answer = 0;
        int bigger = a > b ? a : b;
        int smaller = a <= b ? a : b;
        for(int i = smaller; i <= bigger; i++)
            answer += i;
        return answer;
    }
}