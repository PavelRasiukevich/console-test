using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Initial
{
    class Start
    {
        public static void Main(params string[] args)
        {
            GameMaster master = new GameMaster();
            master.CreateBattleField(10);

            Unit unit = new Unit();

            master.SetPlayerToTheBattleField(unit);
            master.DefineUnitPosition(unit);
            Console.WriteLine($"X:{master.Point.X} Y:{master.Point.Y}");
            master.DefinePossibleMoveArea(unit);
            master.BattleField.DisplayBattleField();


            while (true)
            {
                var _value = Input.InputValue;

                if (_value != 0)
                {

                    master.DefineUnitPosition(unit);

                    Console.Clear();

                    if (master.CheckStep(Input._v, Input._h))
                    {

                        master.ResetPreviouseUnitPosition();
                        master.MoveUnit(unit);
                        master.DefineUnitPosition(unit);
                        Console.WriteLine($"X:{master.Point.X} Y:{master.Point.Y}");

                    }

                    master.BattleField.DisplayBattleField();
                    Input.ResetInput();
                }

                #region Comments
                /*if (Input.Horizontal > 0)
                {
                    var _inputValue = Input.Horizontal;

                    Console.Clear();

                    master.DefineUnitPosition(unit);

                    if (master.CheckStep(_inputValue, Directions.Horizontal))
                    {
                        master.ResetPreviouseUnitPosition();
                        master.MoveUnit(unit);
                    }
                    else
                    {
                        // Console.WriteLine("Can't move");
                    }
                    master.BattleField.DisplayBattleField();

                }
                else if (Input.Horizontal < 0)
                {
                    var _inputValue = Input.Horizontal;

                    Console.Clear();

                    master.DefineUnitPosition(unit);

                    if (master.CheckStep(_inputValue, Directions.Horizontal))
                    {
                        master.ResetPreviouseUnitPosition();
                        master.MoveUnit(unit);
                    }
                    master.BattleField.DisplayBattleField();
                }
                else if (Input.Vertical > 0)
                {
                    var _inputValue = Input.Vertical;

                    Console.Clear();

                    master.DefineUnitPosition(unit);

                    if (master.CheckStep(_inputValue, Directions.Vertical))
                    {
                        master.ResetPreviouseUnitPosition();
                        master.MoveUnit(unit);
                    }
                    else
                    {
                        // Console.WriteLine("Can't move");
                    }
                    master.BattleField.DisplayBattleField();
                }
                else if (Input.Vertical < 0)
                {
                    var _inputValue = Input.Vertical;

                    Console.Clear();

                    master.DefineUnitPosition(unit);

                    if (master.CheckStep(_inputValue, Directions.Vertical))
                    {
                        master.ResetPreviouseUnitPosition();
                        master.MoveUnit(unit);
                    }
                    else
                    {
                        // Console.WriteLine("Can't move");
                    }
                    master.BattleField.DisplayBattleField();
                }*/
                #endregion

            }
        }
    }
}
