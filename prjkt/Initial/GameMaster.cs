using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Initial
{
    class GameMaster
    {
        FieldCreator fieldCreator;
        BattleField battleField;
        Point point;

        public GameMaster()
        {
            fieldCreator = new FieldCreator();
            point = new Point();
        }

        internal FieldCreator FieldCreator { get => fieldCreator; }
        internal BattleField BattleField { get => battleField; private set => battleField = value; }
        internal Point Point { get => point; set => point = value; }

        public void CreateBattleField(int _size)
        {
            BattleField = new BattleField();

            BattleField.Field = fieldCreator.InitField(_size);
        }

        public void SetPlayerToTheBattleField(Unit _unit)
        {
            BattleField.Field[5][5] = _unit.FieldRepresentation;
        }

        public void DefineUnitPosition(Unit _unit)
        {
            for (int y = 0; y < BattleField.Field.Length; y++)
            {
                for (int x = 0; x < BattleField.Field[y].Length; x++)
                {
                    if (BattleField.Field[y][x].Contains(_unit.FieldRepresentation))
                    {
                        point.Y = y;
                        point.X = x;
                    }
                }
            }
        }

        public bool CheckStep(int _direction, Directions _dir)
        {
            switch (_dir)
            {
                case Directions.Horizontal:

                    var _xPointToCheck = point.X + _direction;

                    if (_xPointToCheck >= 0 && _xPointToCheck < BattleField.Field[point.Y].Length)
                        if (BattleField.Field[point.Y][point.X + _direction].Contains("0"))
                        {
                            point.PointToMove[0] = point.Y;
                            point.PointToMove[1] = _xPointToCheck;

                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    break;

                case Directions.Vertical:

                    var _yPointToCheck = point.Y - _direction;

                    if (_yPointToCheck >= 0 && _yPointToCheck < BattleField.Field.Length)
                        if (BattleField.Field[point.Y + _direction][point.X].Contains("0"))
                        {
                            point.PointToMove[0] = _yPointToCheck;
                            point.PointToMove[1] = point.X;

                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    break;
            }

            return false;
        }

        public bool CheckStep(int _y, int _x)
        {
            var _xPointToCheck = point.X + _x;
            var _yPointToCheck = point.Y + -_y;

            if (_xPointToCheck >= 0 && _xPointToCheck < BattleField.Field[point.Y].Length
                && _yPointToCheck >= 0 && _yPointToCheck < BattleField.Field.Length)
                if (BattleField.Field[_yPointToCheck][_xPointToCheck].Contains("0"))
                {
                    point.PointToMove[0] = _yPointToCheck;
                    point.PointToMove[1] = _xPointToCheck;

                    return true;
                }
                else
                {
                    return false;
                }

            return false;
        }

        public void DefinePossibleMoveArea(Unit _unit)
        {
            for (int i = 1; i <= (int)_unit.TravelDistance; i++)
            {
                /*var _East = point.X + i;
                var _West = point.X - i;
                var _North = point.Y - i;
                var _South = point.Y + i;

                var _tempE = point.X + i;
                var _SE = _tempE;*/


              /*  if (_East >= 0 && _East < BattleField.Field[Point.Y].Length)
                    if (_East - point.X < _unit.TravelDistance)
                        if (BattleField.Field[point.Y][_East].Contains("0"))
                            BattleField.Field[point.Y][_East] = "+";

                if (_West >= 0 && _West < BattleField.Field[Point.Y].Length)
                    if (_West - point.X < _unit.TravelDistance)
                        if (BattleField.Field[point.Y][_West].Contains("0"))
                            BattleField.Field[point.Y][_West] = "+";


                if (_North >= 0 && _North < BattleField.Field.Length)
                    if (_North - point.Y < _unit.TravelDistance)
                        if (BattleField.Field[_North][point.X].Contains("0"))
                            BattleField.Field[_North][point.X] = "+";

                if (_South >= 0 && _South < BattleField.Field.Length)
                    if (_South - point.Y < _unit.TravelDistance)
                        if (BattleField.Field[_South][point.X].Contains("0"))
                            BattleField.Field[_South][point.X] = "+";

                if (_SE >= 0 && _SE < BattleField.Field.Length &&
                    _SE >= 0 && _SE < BattleField.Field[point.Y].Length)
                        if (BattleField.Field[_SE][_tempE].Contains("0"))
                        BattleField.Field[_SE][_tempE] = "+";*/


            }
        }

        public void MoveUnit(Unit _unit)
        {
            battleField.Field[point.PointToMove[0]][point.PointToMove[1]] = _unit.FieldRepresentation;
        }

        public void ResetPreviouseUnitPosition()
        {
            BattleField.Field[point.Y][point.X] = "0";
        }
    }
}
