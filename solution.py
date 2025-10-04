class Solution:
    def countNegatives(self, grid):
        n = 0
        for i in range(len(grid) - 1, -1, -1):
            for j in range(len(grid[i]) - 1, -1, -1):
                if(grid[i][j] < 0):
                    n += 1
                else:
                    break
        
        return(n)
