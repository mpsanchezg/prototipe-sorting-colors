using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingColorsGame
{
    class Square
    {
        /* Attributes*/
        private int color;
        private string letter;

        /* Constructor */
        public Square(int Color, string Letter)
        {
            this.color = Color;
            this.letter = Letter;
        }

        /* Getter and Setter */
        public string Letter { get => letter; set => letter = value; }
        public int Color { get => color; set => color = value; }
    }
}
