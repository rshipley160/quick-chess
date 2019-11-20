/***************************************************************
 * File: Piece.cs
 * Created By: Syed Ghulam Akbar		Date: 27 June, 2005
 * Description: This class contains all the chess game pieces movement
 * rules.
 ***************************************************************/
using System;
using System.Collections;

namespace ChessLibrary
{
	/// <summary>
	/// This class contains all the chess game pieces movement
	/// rules.
	/// </summary>
	public class DCRules : Rules
	{

		public DCRules(Board board, Game game) : base(board, game)
        {
            
        }

		// calculate the possible moves for the knight piece and insert them into passed array
		protected override void GetKnightMoves(Cell source, ArrayList moves)
		{
			Cell newcell;

			// First check top two left and right moves for knight
			newcell = m_Board.TopCell(source);
			if (newcell!=null)
			{
				newcell = m_Board.TopLeftCell(newcell);
				// target cell is empty or is owned by the enemy piece
				if (newcell!=null && !newcell.IsOwned(source)) 
					moves.Add(newcell);

				newcell = m_Board.TopCell(source);
				newcell = m_Board.TopRightCell(newcell);
				// target cell is empty or is owned by the enemy piece
				if (newcell!=null && !newcell.IsOwned(source) ) 
					moves.Add(newcell);

                newcell = m_Board.TopCell(source);
                newcell = m_Board.LeftCell(newcell);
                // target cell is empty or is owned by the enemy piece
                if (newcell != null && !newcell.IsOwned(source))
                    moves.Add(newcell);

                newcell = m_Board.TopCell(source);
                newcell = m_Board.RightCell(newcell);
                // target cell is empty or is owned by the enemy piece
                if (newcell != null && !newcell.IsOwned(source))
                    moves.Add(newcell);
            }
			// Now check 2nd bottom left and right cells
			newcell = m_Board.BottomCell(source);
			if (newcell!=null)
			{
				newcell = m_Board.BottomLeftCell(newcell);
				// target cell is empty or is owned by the enemy piece
				if (newcell!=null && !newcell.IsOwned(source) ) 
					moves.Add(newcell);

				newcell = m_Board.BottomCell(source);
				newcell = m_Board.BottomRightCell(newcell);
				// target cell is empty or is owned by the enemy piece
				if (newcell!=null && !newcell.IsOwned(source) ) 
					moves.Add(newcell);

                newcell = m_Board.BottomCell(source);
                newcell = m_Board.LeftCell(newcell);
                // target cell is empty or is owned by the enemy piece
                if (newcell != null && !newcell.IsOwned(source))
                    moves.Add(newcell);

                newcell = m_Board.BottomCell(source);
                newcell = m_Board.RightCell(newcell);
                // target cell is empty or is owned by the enemy piece
                if (newcell != null && !newcell.IsOwned(source))
                    moves.Add(newcell);
            }
			// Now check 2nd Left Top and bottom cells
			newcell = m_Board.LeftCell(source);
			if (newcell!=null)
			{
				newcell = m_Board.TopLeftCell(newcell);
				// target cell is empty or is owned by the enemy piece
				if (newcell!=null && !newcell.IsOwned(source) ) 
					moves.Add(newcell);

				newcell = m_Board.LeftCell(source);
				newcell = m_Board.BottomLeftCell(newcell);
				// target cell is empty or is owned by the enemy piece
				if (newcell!=null && !newcell.IsOwned(source) ) 
					moves.Add(newcell);
			}
			// Now check 2nd Right Top and bottom cells
			newcell = m_Board.RightCell(source);
			if (newcell!=null)
			{
				newcell = m_Board.TopRightCell(newcell);
				// target cell is empty or is owned by the enemy piece
				if (newcell!=null && !newcell.IsOwned(source) ) 
					moves.Add(newcell);

				newcell = m_Board.RightCell(source);
				newcell = m_Board.BottomRightCell(newcell);
				// target cell is empty or is owned by the enemy piece
				if (newcell!=null && !newcell.IsOwned(source) ) 
					moves.Add(newcell);
			}
		}

		// calculate the possible moves for the Rook piece and insert them into passed array
		protected override void GetRookMoves(Cell source, ArrayList moves)
		{
			Cell newcell;

			// Check all the move squars available in top direction
			newcell = m_Board.TopCell(source);
			while (newcell!=null)	// move as long as cell is available in this direction
			{
				if (newcell.IsEmpty())	//next cell is available for move
					moves.Add(newcell);

				if (newcell.IsOwnedByEnemy(source))	//next cell is owned by the enemy object
				{
					moves.Add(newcell);	// Add this to available location
					break;	// force quite the loop execution
				}

				if (newcell.IsOwned(source))	//next cell contains owner object
					break;	// force quite the loop execution

				newcell = m_Board.TopCell(newcell); // keep moving in the top direction
			}

			// Check all the move squars available in left direction
			newcell = m_Board.LeftCell(source);
			while (newcell!=null)	// move as long as cell is available in this direction
			{
				if (newcell.IsEmpty())	//next cell is available for move
					moves.Add(newcell);

				if (newcell.IsOwnedByEnemy(source))	//next cell is owned by the enemy object
				{
					moves.Add(newcell);	// Add this to available location
					break;	// force quite the loop execution
				}

				if (newcell.IsOwned(source))	//next cell contains owner object
					break;	// force quite the loop execution

				newcell = m_Board.LeftCell(newcell); // keep moving in the left direction
			}

			// Check all the move squars available in right direction
			newcell = m_Board.RightCell(source);
			while (newcell!=null)	// move as long as cell is available in this direction
			{
				if (newcell.IsEmpty())	//next cell is available for move
					moves.Add(newcell);

				if (newcell.IsOwnedByEnemy(source))	//next cell is owned by the enemy object
				{
					moves.Add(newcell);	// Add this to available location
					break;	// force quite the loop execution
				}

				if (newcell.IsOwned(source))	//next cell contains owner object
					break;	// force quite the loop execution

				newcell = m_Board.RightCell(newcell); // keep moving in the right direction
			}

			// Check all the move squars available in bottom direction
			newcell = m_Board.BottomCell(source);
			while (newcell!=null)	// move as long as cell is available in this direction
			{
				if (newcell.IsEmpty())	//next cell is available for move
					moves.Add(newcell);

				if (newcell.IsOwnedByEnemy(source))	//next cell is owned by the enemy object
				{
					moves.Add(newcell);	// Add this to available location
					break;	// force quite the loop execution
				}

				if (newcell.IsOwned(source))	//next cell contains owner object
					break;	// force quite the loop execution

				newcell = m_Board.BottomCell(newcell); // keep moving in the bottom direction
			}
		}

		// calculate the possible moves for the bishop piece and insert them into passed array
		protected override void GetBishopMoves(Cell source, ArrayList moves)
		{
			Cell newcell;

			// Check all the move squars available in top-left direction
			newcell = m_Board.TopLeftCell(source);
			while (newcell!=null)	// move as long as cell is available in this direction
			{
				if (newcell.IsEmpty())	//next cell is available for move
					moves.Add(newcell);

				if (newcell.IsOwnedByEnemy(source))	//next cell is owned by the enemy object
				{
					moves.Add(newcell);	// Add this to available location
					break;	// force quite the loop execution
				}

				if (newcell.IsOwned(source))	//next cell contains owner object
					break;	// force quite the loop execution

				newcell = m_Board.TopLeftCell(newcell); // keep moving in the top-left direction
			}

			// Check all the move squars available in top-right direction
			newcell = m_Board.TopRightCell(source);
			while (newcell!=null)	// move as long as cell is available in this direction
			{
				if (newcell.IsEmpty())	//next cell is available for move
					moves.Add(newcell);

				if (newcell.IsOwnedByEnemy(source))	//next cell is owned by the enemy object
				{
					moves.Add(newcell);	// Add this to available location
					break;	// force quite the loop execution
				}

				if (newcell.IsOwned(source))	//next cell contains owner object
					break;	// force quite the loop execution

				newcell = m_Board.TopRightCell(newcell); // keep moving in the top-right direction
			}

			// Check all the move squars available in bottom-left direction
			newcell = m_Board.BottomLeftCell(source);
			while (newcell!=null)	// move as long as cell is available in this direction
			{
				if (newcell.IsEmpty())	//next cell is available for move
					moves.Add(newcell);

				if (newcell.IsOwnedByEnemy(source))	//next cell is owned by the enemy object
				{
					moves.Add(newcell);	// Add this to available location
					break;	// force quite the loop execution
				}

				if (newcell.IsOwned(source))	//next cell contains owner object
					break;	// force quite the loop execution

				newcell = m_Board.BottomLeftCell(newcell); // keep moving in the bottom-left direction
			}

			// Check all the move squars available in the bottom-right direction
			newcell = m_Board.BottomRightCell(source);
			while (newcell!=null)	// move as long as cell is available in this direction
			{
				if (newcell.IsEmpty())	//next cell is available for move
					moves.Add(newcell);

				if (newcell.IsOwnedByEnemy(source))	//next cell is owned by the enemy object
				{
					moves.Add(newcell);	// Add this to available location
					break;	// force quite the loop execution
				}

				if (newcell.IsOwned(source))	//next cell contains owner object
					break;	// force quite the loop execution

				newcell = m_Board.BottomRightCell(newcell); // keep moving in the bottom-right direction
			}
		}

		// calculate the possible moves for the queen piece and insert them into passed array
		protected override void GetQueenMoves(Cell source, ArrayList moves)
		{
			// Queen has moves combination of both bishop and rook moves
			GetRookMoves(source, moves); // first get moves for the rook
			GetBishopMoves(source, moves); // then get moves for the bishop
		}

        protected override void GetKingMoves(Cell source, ArrayList moves)
        {
            Cell newcell;
            int numCaptured = 0;

            if (source.piece.Side.isWhite())
                numCaptured = m_Game.blackCaptures/2;
            else numCaptured = m_Game.whiteCaptures/2;
            // King can move to any of it's neighbor cells at the distance of one cell

            // check if king can move to top
            newcell = m_Board.TopCell(source);
            for (int i = 1; i <= numCaptured + 1 && newcell != null; i++)
            {
                if (newcell.IsEmpty())  //next cell is available for move
                    moves.Add(newcell);

                if (newcell.IsOwnedByEnemy(source)) //next cell is owned by the enemy object
                {
                    moves.Add(newcell); // Add this to available location
                    break;  // force quite the loop execution
                }

                if (newcell.IsOwned(source))    //next cell contains owner object
                    break;  // force quite the loop execution

                newcell = m_Board.TopCell(newcell); // keep moving in the top direction
            }
            // check if king can move to left
            newcell = m_Board.LeftCell(source);
            for (int i = 1; i <= numCaptured + 1 && newcell != null; i++)
            {
                if (newcell.IsEmpty())  //next cell is available for move
                    moves.Add(newcell);

                if (newcell.IsOwnedByEnemy(source)) //next cell is owned by the enemy object
                {
                    moves.Add(newcell); // Add this to available location
                    break;  // force quite the loop execution
                }

                if (newcell.IsOwned(source))    //next cell contains owner object
                    break;  // force quite the loop execution

                newcell = m_Board.LeftCell(newcell); // keep moving in the top direction
            }
            // check if king can move to right
            newcell = m_Board.RightCell(source);
            for (int i = 1; i <= numCaptured + 1 && newcell != null; i++)
            {
                if (newcell.IsEmpty())  //next cell is available for move
                    moves.Add(newcell);

                if (newcell.IsOwnedByEnemy(source)) //next cell is owned by the enemy object
                {
                    moves.Add(newcell); // Add this to available location
                    break;  // force quite the loop execution
                }

                if (newcell.IsOwned(source))    //next cell contains owner object
                    break;  // force quite the loop execution

                newcell = m_Board.RightCell(newcell); // keep moving in the top direction
            }

            // check if king can move to bottom
            newcell = m_Board.BottomCell(source);
            for (int i = 1; i <= numCaptured + 1 && newcell != null; i++)
            {
                if (newcell.IsEmpty())  //next cell is available for move
                    moves.Add(newcell);

                if (newcell.IsOwnedByEnemy(source)) //next cell is owned by the enemy object
                {
                    moves.Add(newcell); // Add this to available location
                    break;  // force quite the loop execution
                }

                if (newcell.IsOwned(source))    //next cell contains owner object
                    break;  // force quite the loop execution

                newcell = m_Board.BottomCell(newcell); // keep moving in the top direction
            }
            // check if king can move to top-left
            newcell = m_Board.TopLeftCell(source);
            for (int i = 1; i <= numCaptured + 1 && newcell != null; i++)
            {
                if (newcell.IsEmpty())  //next cell is available for move
                    moves.Add(newcell);

                if (newcell.IsOwnedByEnemy(source)) //next cell is owned by the enemy object
                {
                    moves.Add(newcell); // Add this to available location
                    break;  // force quite the loop execution
                }

                if (newcell.IsOwned(source))    //next cell contains owner object
                    break;  // force quite the loop execution

                newcell = m_Board.TopLeftCell(newcell); // keep moving in the top direction
            }
            // check if king can move to top-right
            newcell = m_Board.TopRightCell(source);
            for (int i = 1; i <= numCaptured + 1 && newcell != null; i++)
            {
                if (newcell.IsEmpty())  //next cell is available for move
                    moves.Add(newcell);

                if (newcell.IsOwnedByEnemy(source)) //next cell is owned by the enemy object
                {
                    moves.Add(newcell); // Add this to available location
                    break;  // force quite the loop execution
                }

                if (newcell.IsOwned(source))    //next cell contains owner object
                    break;  // force quite the loop execution

                newcell = m_Board.TopRightCell(newcell); // keep moving in the top direction
            }
            // check if king can move to bottom-left
            newcell = m_Board.BottomLeftCell(source);
            for (int i = 1; i <= numCaptured + 1 && newcell != null; i++)
            {
                if (newcell.IsEmpty())  //next cell is available for move
                    moves.Add(newcell);

                if (newcell.IsOwnedByEnemy(source)) //next cell is owned by the enemy object
                {
                    moves.Add(newcell); // Add this to available location
                    break;  // force quite the loop execution
                }

                if (newcell.IsOwned(source))    //next cell contains owner object
                    break;  // force quite the loop execution

                newcell = m_Board.BottomLeftCell(newcell); // keep moving in the top direction
            }
            // check if king can move to bottom-right
            newcell = m_Board.BottomRightCell(source);
            for (int i = 1; i <= numCaptured + 1 && newcell != null; i++)
            {
                if (newcell.IsEmpty())  //next cell is available for move
                    moves.Add(newcell);

                if (newcell.IsOwnedByEnemy(source)) //next cell is owned by the enemy object
                {
                    moves.Add(newcell); // Add this to available location
                    break;  // force quite the loop execution
                }

                if (newcell.IsOwned(source))    //next cell contains owner object
                    break;  // force quite the loop execution

                newcell = m_Board.BottomRightCell(newcell); // keep moving in the top direction
            }

        }

        protected override void SetMoveType(Move move)
        {
            // start with the normal move type
            move.Type = Move.MoveType.NormalMove;

            // check if the move is of capture type
            if (move.EndCell.piece != null && move.EndCell.piece.Type != Piece.PieceType.Empty)
                move.Type = Move.MoveType.CaputreMove;
        }
    }
}
