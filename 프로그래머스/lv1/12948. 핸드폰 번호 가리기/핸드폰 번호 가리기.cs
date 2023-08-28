public class Solution {
    public string solution(string phone_number) {
        int phone_number_L = phone_number.Length;
        phone_number = new string('*', phone_number_L-4) + phone_number.Substring(phone_number_L-4);
        return phone_number;
    }
}