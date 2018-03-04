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

        public List<Object> figures = new List<Object>();
        

        private void button_draw_Click(object sender, EventArgs e) {
            int x1 = Convert.ToInt32(tb_x1.Text);
            int y1 = Convert.ToInt32(tb_y1.Text);
            int x2 = Convert.ToInt32(tb_x2.Text);
            int y2 = Convert.ToInt32(tb_y2.Text);
            
            Point P1 = new Point(x1, y1);
            Point P2 = new Point(x2, y2);

            
            foreach(Figure obj in figures) {
                if (obj.GetType().Name == comboBox1.Text)
                    obj.Draw(P1, P2);
            }


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

        private void FormDrawing_Load(object sender, EventArgs e)
        {
            figures.Add(new Line(picture));
            figures.Add(new Rectangle(picture));
            figures.Add(new Circle(picture));
        }

    }
}
