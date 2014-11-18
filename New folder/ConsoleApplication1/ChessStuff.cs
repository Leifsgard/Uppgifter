using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class ChessBoard
    {
        //Stuff        
    }
    public class ChessPiece
    {
        //Stuff
    }

    public class ChessLogic : IChessLogic
    {
        public ChessPiece CalculateBestMove(ChessBoard board)
        {
            Console.WriteLine("Calculating best piece to move");
            return null;
        }
    }

    public class ChessGame
    {
        private readonly IChessLogic logic;

        public ChessGame(IChessLogic newLogic)
        {
            logic = newLogic;
        }

        public ChessPiece CalculatePieceToMove(ChessBoard board)
        {
            //ChessLogic logic = new ChessLogic();
            ChessPiece move = logic.CalculateBestMove(board);

            return move;
        }

     
    } 
}
