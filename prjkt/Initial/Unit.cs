using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Initial
{
    class Unit
    {
        private int travelDistance;

        public int posX { get; set; }
        public int posY { get; set; }

        public string FieldRepresentation { get => fieldRepresentation; set => fieldRepresentation = value; }
        public float TravelDistance { get => travelDistance;}

        string fieldRepresentation;

        public Unit()
        {
            fieldRepresentation = "X";
            travelDistance = 3;
        }
    }
}
