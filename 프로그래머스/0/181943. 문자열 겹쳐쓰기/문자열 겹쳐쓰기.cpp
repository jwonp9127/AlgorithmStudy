#include <string>
#include <vector>

using namespace std;

string solution(string my_string, string overwrite_string, int s) {
    string answer = "";
    
    int my_len = my_string.size();
    int overwrite_len = overwrite_string.size();
    
    for(int i = 0; i < my_len; i++){
        if(i < s){
            answer += my_string[i];
        }
        else if(i < s + overwrite_len){
            answer += overwrite_string[i - s];
        }
        else{
            answer += my_string[i];
        }
    }
    
    return answer;
}