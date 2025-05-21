class NQueensSolver
{
    static void Main()
    {
        int N = 4;
        char[,] board = new char[N, N];

        // Initialize board with '_'
        for (int i = 0; i < N; i++)
            for (int j = 0; j < N; j++)
                board[i, j] = '_';

        SolveNQueens(board, 0, N);
    }

    static void SolveNQueens(char[,] board, int row, int N)
    {
        if (row == N)
        {
            PrintBoard(board, N);
            Console.WriteLine();
            return;
        }

        for (int col = 0; col < N; col++)
        {
            if (IsSafe(board, row, col, N))
            {
                board[row, col] = 'Q';  // Place queen
                SolveNQueens(board, row + 1, N);
                board[row, col] = '_';  // Backtrack
            }
        }
    }

    static bool IsSafe(char[,] board, int row, int col, int N)
    {
        // Check column above
        for (int i = 0; i < row; i++)
            if (board[i, col] == 'Q')
                return false;

        // Check upper-left diagonal
        for (int i = row - 1, j = col - 1; i >= 0 && j >= 0; i--, j--)
            if (board[i, j] == 'Q')
                return false;

        // Check upper-right diagonal
        for (int i = row - 1, j = col + 1; i >= 0 && j < N; i--, j++)
            if (board[i, j] == 'Q')
                return false;

        return true;
    }

    static void PrintBoard(char[,] board, int N)
    {
        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < N; j++)
                Console.Write(board[i, j] + " ");
            Console.WriteLine();
        }
    }
}
