using System;
using System.Linq;

public class Solution {
    public int[] solution(int[] arr, int divisor) {
        int answerLength = 0;
        foreach(int num in arr){
            if(num % divisor == 0)
                answerLength++;
        }
        int[] answer = new int[answerLength];
        int j = 0;
        for(int i = 0; i < arr.Length; i++){
            if(arr[i] % divisor == 0){
                answer[j] = arr[i];
                j++;
            }
        } 
        Array.Sort(answer);

        return answer.Length > 0 ? answer : new int[]{-1};
    }
}