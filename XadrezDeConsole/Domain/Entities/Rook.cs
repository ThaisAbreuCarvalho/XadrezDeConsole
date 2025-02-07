﻿using System;
using System.Collections.Generic;
using System.Text;
using XadrezDeConsole.Domain.Abstraction;
using XadrezDeConsole.Helpers.Enums;

namespace XadrezDeConsole.Domain.Entities
{
    public class Rook : Piece
    {
        public override string Name { get; set; } = "R";

        public Rook(Board board, Color color) : base(board, color)
        {
        }

        public override bool[,] PossibleMovements()
        {
            var response = new bool[this.Board.Lines, this.Board.Columns];

            for (int i = this.Position.Line + 1; i < this.Board.Lines; i++)
            {
                var position = new Position(i, this.Position.Column);
                if (IsMovementValid(position))
                {
                    response[position.Line, position.Column] = true;
                    if (this.Board.Piece(position.Line, position.Column) != null)
                    {
                        break;
                    }
                }
                else
                {
                    break;
                }
            }

            for (int i = this.Position.Line - 1; i >= 0; i--)
            {
                var position = new Position(i, this.Position.Column);
                if (IsMovementValid(position))
                {
                    response[position.Line, position.Column] = true;
                    if (this.Board.Piece(position.Line, position.Column) != null)
                    {
                        break;
                    }
                }
                else
                {
                    break;
                }
            }

            for (int i = this.Position.Column + 1; i < this.Board.Columns; i++)
            {
                var position = new Position(this.Position.Line, i);
                if (IsMovementValid(position))
                {
                    response[position.Line, position.Column] = true;
                    if (this.Board.Piece(position.Line, position.Column) != null)
                    {
                        break;
                    }
                }
                else
                {
                    break;
                }
            }

            for (int i = this.Position.Column - 1; i >= 0; i--)
            {
                var position = new Position(this.Position.Line, i);
                if (IsMovementValid(position))
                {
                    response[position.Line, position.Column] = true;
                    if (this.Board.Piece(position.Line, position.Column) != null)
                    {
                        break;
                    }
                }
                else
                {
                    break;
                }
            }

            return response;
        }

        public override string ToString()
        {
            return $" {this.Name} ";
        }
    }
}
