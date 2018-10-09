namespace TestGame.Structures
{
    enum Drctn
    {
        Up,
        Right,
        Down,
        Left
    }

    struct RectangleCrds
    {
        public Coords LB, RB, RT, LT;

        public RectangleCrds(Coords LeftBottomCoords, Coords LeftTopCoords, Coords RightTopCoords, Coords RightBottomCoords)
        {
            LB = LeftBottomCoords;
            RB = RightBottomCoords;
            RT = RightTopCoords;
            LT = LeftTopCoords;
        }
    }
}
