using System;

public class Solution {
    public int solution(string[] babbling) {
        int answer = 0;
        foreach(string words in babbling){
            bool canbab = true;
            int before = -1;
            for(int i = 0; i < words.Length; i++){
                switch(words[i]){
                    case 'a':
                        if(words.Length - i >= 3 && before != 0 && words.Substring(i, 3).Equals("aya")){
                            before = 0;
                            i += 2;
                        }
                        else
                            canbab = false;
                        break;
                    case 'y':
                        if(words.Length - i >= 2 && before != 1 && words.Substring(i, 2).Equals("ye")){
                            before = 1;
                            i += 1;
                        }
                        else
                            canbab = false;
                        break;
                    case 'w':
                        if(words.Length - i >= 3 && before != 2 && words.Substring(i, 3).Equals("woo")){
                            before = 2;
                            i += 2;
                        }
                        else
                            canbab = false;
                        break;
                    case 'm':
                        if(words.Length - i >= 2 && before != 3 && words.Substring(i, 2).Equals("ma")){
                            before = 3;
                            i += 1;
                        }
                        else
                            canbab = false;
                        break;
                    default:
                        canbab = false;
                        break;
                }
            }
            answer += canbab ? 1 : 0;
        }
        return answer;
    }
}

