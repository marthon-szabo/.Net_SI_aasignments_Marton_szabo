using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace SnakeGame
{
    class SnakePart
    {
        public UIElement UIElement { get; set; }
        public double PositionX { get; set; }
        public double PositionY { get; set; }
        public bool IsHead { get; set; }
    }
}
