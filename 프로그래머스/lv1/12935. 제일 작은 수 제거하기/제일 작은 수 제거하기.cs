using System;
using System.Linq;

public class Solution {
    public int[] solution(int[] arr) {
        int arr_L = arr.Length;
        if(arr_L == 1) return new int[1]{-1};
        
        int[] answer = new int[arr_L-1];
        int index = Array.IndexOf(arr, arr.Min());
            
        for(int i = 0; i < arr_L; i++){
            if(i < index)   answer[i] = arr[i];
            if(i > index)   answer[i-1] = arr[i];
        }
        
        return answer;
    }
}