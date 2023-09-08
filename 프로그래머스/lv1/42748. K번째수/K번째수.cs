using System;

public class Solution {
    public int[] solution(int[] array, int[,] commands) {
        int commandsL = commands.GetLength(0);
        int[] answer = new int[commandsL];
        for(int index = 0; index < commandsL; index++){
            int i = commands[index, 0];
            int j = commands[index, 1];
            int k = commands[index, 2];
                int[] slicedArray = new int[j - i + 1];

            for(int index2 = 0; index2 <= j - i; index2++)
                slicedArray[index2] = array[index2 + i - 1];
            
            Array.Sort(slicedArray);
            answer[index] = slicedArray[k-1];
        }

        return answer;
    }
}