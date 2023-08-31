using System;

public class Solution {
    public int solution(int[] numbers) {
        int answer = 0;
        bool find = false;
        for(int i = 0; i < 10; i++){
            find = false;
            foreach(int num in numbers){
                if(num == i){
                    find = true;
                    break;
                }
            }
            if(find == false) answer += i;
        }
        return answer;
    }
}