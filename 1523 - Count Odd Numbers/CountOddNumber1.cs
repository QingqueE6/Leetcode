public class Solution {
    public int CountOdds(int low, int high) {
        int TheOddOne = 0;

        for(int i = low; i <= high; i++){
            if(i % 2 == 1){
                TheOddOne++;
                i++;
            }
        }
        return TheOddOne;
    }
}