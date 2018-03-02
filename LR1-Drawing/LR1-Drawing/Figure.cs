using System.Windows.Forms;
using System.Drawing;

namespace LR1_Drawing {
    public class Figure {
        protected PictureBox picture;
        protected Graphics graph;
        protected Pen pen;
        protected Bitmap bmp;

        public virtual void Draw() {
        }

        public Figure(PictureBox pic) {
            picture = pic;
            bmp = new Bitmap(picture.Width, picture.Height);
            graph = Graphics.FromImage(bmp);
            pen = new Pen(Color.Black);
        }
    }
}
