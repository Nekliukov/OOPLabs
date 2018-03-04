using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LR1_Drawing {
    public partial class FormDrawing : Form {
        public FormDrawing() {
            InitializeComponent();
        }

        private void button_draw_Click(object sender, EventArgs e) {
            Int32 x1 = Convert.ToInt32(tb_x1.Text);
            Int32 y1 = Convert.ToInt32(tb_y1.Text);
            Int32 x2 = Convert.ToInt32(tb_x2.Text);
            Int32 y2 = Convert.ToInt32(tb_y2.Text);
            
            Point P1 = new Point(x1, y1);
            Point P2 = new Point(x2, y2);

            Figure F = new Line(picture, P1, P2);
            F.Draw();
            tb_x1.Text = tb_x2.Text = tb_y1.Text = tb_y2.Text = "";
            
        }

        private void picture_MouseClick(object sender, MouseEventArgs e)
        {
            float X = e.Location.X , Y = e.Location.Y;
            if (tb_x1.Text == ""){
                tb_x1.Text = Convert.ToString(X);
                tb_y1.Text = Convert.ToString(Y);
            }
            else{
                tb_x2.Text = Convert.ToString(X);
                tb_y2.Text = Convert.ToString(Y);
            }
        }

    }
}
