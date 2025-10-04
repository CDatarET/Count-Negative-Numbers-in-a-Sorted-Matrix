public class Solution {
    public int CountNegatives(int[][] grid) {
        int n = 0;
        for(int i = grid.Length - 1; i >= 0; i--){
            for(int j = grid[i].Length - 1; j >= 0; j--){
                if(grid[i][j] < 0){
                    n++;
                }
                else{
                    break;
                }
            }
        }

        return(n);
    }
}
