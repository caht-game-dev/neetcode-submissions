public class Solution {
    public bool IsValidSudoku(char[][] board) 
    {
        var row = board.Length;
        var col = board[0].Length;

        for (int i = 0; i < row; i++)
        {
            var hashset = new HashSet<char>();

            for (int y = 0; y < col; y++)
            {
                if (board[i][y] == '.') continue;
                if(!hashset.Add(board[i][y]))
                {
                    return false;
                }
            }
        }
        
        for (int i = 0; i < col; i++)
        {
            var hashset = new HashSet<char>();

            for (int y = 0; y < row; y++)
            {
                if (board[y][i] == '.') continue;
                if(!hashset.Add(board[y][i]))
                {
                    return false;
                }
            }
        }
        
        for (int square = 0; square < 9; square++) {
            HashSet<char> hashset = new HashSet<char>();
            for (int i = 0; i < 3; i++) {
                for (int j = 0; j < 3; j++) {
                    int rowTmp = (square / 3) * 3 + i;
                    int colTmp = (square % 3) * 3 + j;
                    if (board[rowTmp][colTmp] == '.') continue;
                    if (!hashset.Add(board[rowTmp][colTmp])) return false;
                }
            }
        }
        
        return true;
    }
}