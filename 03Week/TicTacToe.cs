using System;

public class Program
{
    public static string playerTurn = "X";
    public static string[][] board = new string[][]
    {
        new string[] {" ", " ", " "},
        new string[] {" ", " ", " "},
        new string[] {" ", " ", " "}
     };

    public static void Main()
    {
        do
        {
            DrawBoard();
            GetInput();

        } while (!CheckForWin() && !CheckForTie());

        // leave this command at the end so your program does not close automatically
        Console.ReadLine();
    }

    public static void GetInput()
    {
        Console.WriteLine("Player " + playerTurn);
        Console.WriteLine("Enter Row:");
        int row = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter Column:");
        int column = int.Parse(Console.ReadLine());
        PlaceMark(row, column);

        if (CheckForWin())
        {
            DrawBoard();
            Console.WriteLine("Player " + playerTurn + "Won!");
            return;
        }
        else if (CheckForTie())
        {
            DrawBoard();
            Console.WriteLine("It's a tie!");
            return;
        }

        playerTurn = (playerTurn == "X") ? "O" : "X";

    }

    public static void PlaceMark(int row, int column)
    {
        board[row][column] = playerTurn;
    }

    public static bool CheckForWin()
    {
        return (HorizontalWin() || VerticalWin() || DiagonalWin());
    }

    public static int SlotsAvailable()
    {
        int openSlots = 0;

        foreach (var row in board)
        {
            foreach (var column in row)
            {
                if (column != "X" && column != "O")
                {
                    openSlots++;
                }
            }
        }

        return openSlots;

    }

    public static bool CheckForTie()
    {
        // your code goes here

        return false;
    }

    public static bool HorizontalWin()
    {
        // your code goes here

        return false;
    }

    public static bool VerticalWin()
    {
        // your code goes here

        return false;
    }

    public static bool DiagonalWin()
    {
        // your code goes here

        return false;
    }

    public static void DrawBoard()
    {
        Console.WriteLine("  0 1 2");
        Console.WriteLine("0 " + String.Join("|", board[0]));
        Console.WriteLine("  -----");
        Console.WriteLine("1 " + String.Join("|", board[1]));
        Console.WriteLine("  -----");
        Console.WriteLine("2 " + String.Join("|", board[2]));
    }
}
