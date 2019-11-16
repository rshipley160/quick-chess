/***************************************************************
 * File: Board.cs
 * Created By: Syed Ghulam Akbar		Date: 27 June, 2005
 * Description: The main chess board. Board contain the chess cell
 * which will contain the chess pieces. Board also contains the methods
 * to get and set the user moves.
 ***************************************************************/

using System;
using System.Collections;
using System.Xml;

namespace ChessLibrary
{
    /// <summary>
    /// he main chess board. Board contain the chess cell
    /// which will contain the chess pieces. Board also contains the methods
    /// to get and set the user moves.
    /// </summary>
    [Serializable]
    public class DCBoard : Board
    {
        // Initialize the chess board and place piece on thier initial positions
        public override void Init()
        {
            m_cells.Clear();        // Remove any existing chess cells

            // Build the 64 chess board cells
            for (int row = 1; row <= 8; row++)
                for (int col = 1; col <= 8; col++)
                {
                    m_cells.Add(new Cell(row, col));    // Initialize and add the new chess cell
                }

            // Now setup the board for black side
            m_cells["c1"].piece = new Piece(Piece.PieceType.Rook, m_BlackSide);
            m_cells["f1"].piece = new Piece(Piece.PieceType.Rook, m_BlackSide);
            m_cells["d2"].piece = new Piece(Piece.PieceType.Knight, m_BlackSide);
            m_cells["e2"].piece = new Piece(Piece.PieceType.Knight, m_BlackSide);
            m_cells["c2"].piece = new Piece(Piece.PieceType.Bishop, m_BlackSide);
            m_cells["f2"].piece = new Piece(Piece.PieceType.Bishop, m_BlackSide);
            m_cells["e1"].piece = new Piece(Piece.PieceType.King, m_BlackSide);
            m_cells["d1"].piece = new Piece(Piece.PieceType.Queen, m_BlackSide);

            // Now setup the board for white side
            m_cells["c8"].piece = new Piece(Piece.PieceType.Rook, m_WhiteSide);
            m_cells["f8"].piece = new Piece(Piece.PieceType.Rook, m_WhiteSide);
            m_cells["d7"].piece = new Piece(Piece.PieceType.Knight, m_WhiteSide);
            m_cells["e7"].piece = new Piece(Piece.PieceType.Knight, m_WhiteSide);
            m_cells["c7"].piece = new Piece(Piece.PieceType.Bishop, m_WhiteSide);
            m_cells["f7"].piece = new Piece(Piece.PieceType.Bishop, m_WhiteSide);
            m_cells["e8"].piece = new Piece(Piece.PieceType.King, m_WhiteSide);
            m_cells["d8"].piece = new Piece(Piece.PieceType.Queen, m_WhiteSide);
        }
    }
}
