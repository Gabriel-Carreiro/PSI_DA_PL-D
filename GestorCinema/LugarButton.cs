using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestorCinema
{
    internal class LugarButton : Button
    {
        public int X { get; }
        public int Y { get; }
        public LugarButton(int x, int y)
        {
            X = x;
            Y = y;
        }
    }
}
