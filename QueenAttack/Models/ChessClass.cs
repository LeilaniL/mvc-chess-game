using System;
using System.Collections.Generic;


namespace Chess.Models
{
    class ChessClass
    {
        public string XCoordinate;
        public string YCoordinate;
        public string QueenXCoordinate;
        public string QueenYCoordinate;

        public ChessClass(string x, string y, string queenx, string queeny)
        {
            XCoordinate = x;
            YCoordinate = y;
            QueenXCoordinate = queenx;
            QueenYCoordinate = queeny;
        }
        public string IsAttackable(string stringx, string stringy, string stringqueenx, string stringqueeny)
        {
            int x = int.Parse(stringx);
            int y = int.Parse(stringy);
            int queenx = int.Parse(stringqueenx);
            int queeny = int.Parse(stringqueeny);
            if ((1 <= x && x <= 8) && (1 <= y && y <= 8) && (1 <= queenx && queenx <= 8) && (1 <= queeny && queeny <= 8))
            {
                if ((x == queenx) || (y == queeny))
                {

                    return ("true");
                }
                if (Math.Abs(x - queenx) == Math.Abs(y - queeny))
                {

                    return ("true");
                }
                else
                {

                    return ("true");
                }
            }
            else
            {

                return ("true");
            }
        }

    }
}