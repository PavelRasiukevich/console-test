using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Initial
{
    class FieldCreator
    {

        public string[][] InitField()
        {
            var _mat = new string[5][];

            for (int row = 0; row < _mat.Length; row++)
            {
                _mat[row] = new string[5];

                for (int column = 0; column < _mat[row].Length; column++)
                {
                    _mat[row][column] = "0";
                }
            }

            return _mat;
        }

        public string[][] InitField(int _size)
        {
            var _mat = new string[_size][];

            for (int row = 0; row < _mat.Length; row++)
            {
                _mat[row] = new string[_size];

                for (int column = 0; column < _mat[row].Length; column++)
                {
                    _mat[row][column] = "0";
                }
            }

            return _mat;
        }
    }
}
