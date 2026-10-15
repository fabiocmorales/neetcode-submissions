public class Solution
{
    public bool IsValidSudoku(char[][] board)
    {
        var hashSet = new HashSet<string>();

        for (int i = 0; i < board.Length; i++)
        {
            for (int j = 0; j < board[0].Length; j++)
            {
                if (board[i][j] == '.') continue;

                if (!hashSet.Add($"row{i}-{board[i][j]}")) return false;
                if (!hashSet.Add($"col{j}-{board[i][j]}")) return false;
                if (!hashSet.Add($"box{i / 3}-{j / 3}-{board[i][j]}")) return false;
            }
        }
        return true;
    }
}