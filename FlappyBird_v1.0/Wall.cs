using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlappyBird_v1
{
    class Wall
    {
        public const int SpeedOFWallMove = -10;

        public Wall(Size size, Vector r) : this(size.Width,size.Height, r)
        {
            Size = size;
        }
        public Wall(int width, int height, Vector r)
        {
            Width = width;
            Height = height;
            R = r;
        }

        public Size Size { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public Vector R { get; set; }


        public void Move(Vector direction)
        {
            R = R + direction;
        }
    }
}
