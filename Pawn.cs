﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Schack
{
    abstract class Pawn : Piece
    {
        public bool isFirstMove;
        public Pawn(Texture2D texture, Rectangle rectangle, Vector2 vector, Vector2 tempPos, bool isWhite, bool[] allowedMoves, bool[] am, bool isDead, int checkCounter) : base(texture, rectangle, vector, tempPos, isWhite, allowedMoves, am, isDead, checkCounter)
        {
            this.texture = texture;
            this.rectangle = rectangle;
            this.vector = vector;
            this.tempPos = tempPos;
            this.isWhite = isWhite;
            this.allowedMoves = allowedMoves;
            this.am = am;
            isFirstMove = true;
            this.isDead = isDead;
        }

    }
}
