#include <iostream>
#include <string>
#include <vector>

using namespace std;

int solution(vector<int> bandage, int health, vector<vector<int>> attacks) {    
    int bandTime = bandage[0];
    int recoveryPS = bandage[1];
    int finalRecovery = bandage[2];
    int maxHealth = health;
    
    int time = 0;
    int recoveryCount = 0;
    
    for(int i = 0; i < attacks.size(); time++){
        if(attacks[i][0] == time){
            health -= attacks[i][1];
            recoveryCount = 0;
            i++;
        }
        else{
            health += recoveryPS;
            recoveryCount += 1;
        }
        
        if(health <= 0){
            return -1;
        }
        
        if(recoveryCount == bandTime){
            health += finalRecovery;
            recoveryCount = 0;
        }
        
        if(health > maxHealth){
            health = maxHealth;
        }
    }
    return health;
}