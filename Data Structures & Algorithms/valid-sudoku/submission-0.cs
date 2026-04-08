public class Solution {
    public bool IsValidSudoku(char[][] board) {
        for(int row = 0; row <= 8; row++)
        {
            HashSet<char> seen = new HashSet<char>();
            for(int i = 0; i <= 8; i++)
            {
                if(board[row][i] == '.') continue;
                if(seen.Contains(board[row][i])) return false;
                seen.Add(board[row][i]);
            }
        }
        for(int column = 0; column<=8; column++)
        {
            HashSet<char> seen = new HashSet<char>();
            for(int i=0; i<= 8; i++)
            {
                if(board[i][column] == '.') continue;
                if(seen.Contains(board[i][column])) return false;
                seen.Add(board[i][column]);
            }
        }

        for(int square = 0; square<=8; square++)
        {
            HashSet<char> seen = new HashSet<char>();
            for(int i=0; i<=2; i++)
            {
                for(int j=0; j<=2; j++)
                {   
                    int row = (square/3)*3 + i;
                    int column = (square%3)*3 + j;
                    if(board[row][column] == '.') continue;
                    if(seen.Contains(board[row][column])) return false;
                    seen.Add(board[row][column]);
                }   
                
            }
        }

        return true;

    }
}
