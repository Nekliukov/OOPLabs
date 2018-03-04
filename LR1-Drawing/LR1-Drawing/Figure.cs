using System.Windows.Forms;
using System.Drawing;

namespace LR1_Drawing {
    public class Figure {
        protected PictureBox picture;
        protected Graphics graph;
        protected Pen pen;
        protected Bitmap bmp;

        public virtual void Draw(Point P1, Point P2) {}

        public virtual void Instructions(Label l) {
            l.Text = "Choose the figure's type";
        }

        public Figure(PictureBox pic) {
            picture = pic;
            bmp = new Bitmap(picture.Width, picture.Height);
            graph = Graphics.FromImage(bmp);
            pen = new Pen(Color.Black,4);
        }
    }
}
