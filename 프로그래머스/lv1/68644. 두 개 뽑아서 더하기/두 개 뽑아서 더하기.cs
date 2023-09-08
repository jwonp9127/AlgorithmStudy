using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int[] numbers) {
        List<int> list = new List<int>();
        for(int i = 0; i < numbers.Length; i++)
            for(int j = i + 1; j < numbers.Length; j++)
                if(!list.Contains(numbers[i] + numbers[j])) list.Add(numbers[i] + numbers[j]);
        int[] answer = list.ToArray();
        Array.Sort(answer);
        return answer;
    }
}