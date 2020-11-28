using System.Drawing;
using System.Windows.Forms;

namespace FlappyBird_v1
{
    class Bird
    {
        int LiftingSpeed = -400;
        const int FallingSpeed = 980;

        Vector g = new Vector(0, FallingSpeed);
        public double t;
        public Vector v { get; set; }
        public Vector r0 { get; set; }
        public Vector R { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }

        public Bird(int width, int height, Point LocationOfBird)
        {
            Width = width;
            Height = height;
            R = new Vector(LocationOfBird.X, LocationOfBird.Y);
        }

        public Point Move()
        {
            R = r0 + v * t + g * t * t / 2;
            return new Point((int)R.X, (int)R.Y);
        }

        public void ChangeDirectionOfMove()
        {
            r0 = R;
            v = new Vector(0, LiftingSpeed);
            t = 0;
        }

        public bool IsCollision(PictureBox pbWall)
        {
            Rectangle bird = new Rectangle((int)this.R.X, (int)this.R.Y, this.Width, this.Height);
            Rectangle wall = new Rectangle(pbWall.Left, pbWall.Top, pbWall.Width, pbWall.Height);

            return bird.IntersectsWith(wall);
        }
    }
}
