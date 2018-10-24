using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingColorsGame
{
    class SquareBox
    {
        /* Attributes */
        private int id;
        private int color;
        private List<Square> box;

        /* Constructor */
        public SquareBox(int id, int color, List<Square> box)
        {
            this.id = id;
            this.color = color;
            this.box = box;
        }

        /* Getter and Setter */
        public int Color { get => color; set => color = value; }
        public int Id { get => id; set => id = value; }
        internal List<Square> Box { get => box; set => box = value; }

        /* Append square in a box */
        public void AppendSquare(Square square)
        {
            if(square.Color != this.color)
            {
                Console.WriteLine("Invalid square color.");
                return;
            }
            box.Add(square);
            return;
        }
    }
}
