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
        public bool IsFirst = true;
        public Bitmap bit;

        public Point Get3rdPoint() {
            int x3 = Convert.ToInt32(tb_x3.Text);
            int y3 = Convert.ToInt32(tb_y3.Text);
            Point P3 = new Point(x3, y3);
            return P3;
        }

        private void FormDrawing_Load(object sender, EventArgs e) {
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            WindowState = FormWindowState.Maximized;
            bit = new Bitmap(picture.Width, picture.Height);

            figures.Add(new Line(picture));
            figures.Add(new Rectangle(picture));
            figures.Add(new Circle(picture));
            figures.Add(new Ellipse(picture));
            figures.Add(new Triangle(picture));
        }

        private void button_draw_Click(object sender, EventArgs e) {
            try {
                Convert.ToInt32(tb_x1.Text);
                Convert.ToInt32(tb_x2.Text);
            } catch (FormatException) {
                MessageBox.Show("Wrong Data.Please, check point's locations");
                return;
            }

            int x1 = Convert.ToInt32(tb_x1.Text); int y1 = Convert.ToInt32(tb_y1.Text);
            int x2 = Convert.ToInt32(tb_x2.Text); int y2 = Convert.ToInt32(tb_y2.Text);
            
            Point P1 = new Point(x1, y1);
            Point P2 = new Point(x2, y2);

            foreach (Figure obj in figures) {
                obj.bmp = bit;
                if (obj.GetType().Name == comboBox1.Text)
                    if (obj.GetParNum() == 2)
                        obj.Draw(P1, P2);
                    else
                        try { obj.Draw(P1, P2, Get3rdPoint()); }
                        catch { MessageBox.Show("Please, add the 3rd point!"); return; }
                if (IsFirst) bit = obj.bmp;                   
            }

            tb_x1.Text = tb_x2.Text = tb_y1.Text = tb_y2.Text = tb_x3.Text = tb_y3.Text = "";

        }

        private void picture_MouseClick(object sender, MouseEventArgs e)
        {
            float X = e.Location.X , Y = e.Location.Y;
            if (tb_x1.Text == ""){
                tb_x1.Text = Convert.ToString(X);
                tb_y1.Text = Convert.ToString(Y);
                return;
            }

            if (tb_x2.Text == ""){
                tb_x2.Text = Convert.ToString(X);
                tb_y2.Text = Convert.ToString(Y);
                return;
            }

            foreach (Figure obj in figures){
                if (obj.GetType().Name == comboBox1.Text) {
                    if (obj.GetParNum() == 3){
                        tb_x3.ReadOnly = false; tb_y3.ReadOnly = false;
                        tb_x3.Text = Convert.ToString(X);
                        tb_y3.Text = Convert.ToString(Y);
                        break;
                    }
                }
            }
            tb_x3.ReadOnly = true; tb_y3.ReadOnly = true;
        }  

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) {
            tb_x1.Text = tb_x2.Text = tb_y1.Text = tb_y2.Text = tb_x3.Text = tb_y3.Text = "";
            foreach (Figure obj in figures){
                if (obj.GetType().Name == comboBox1.Text) {
                    obj.Instructions(rtb_info);
                }
            }           
        }

        private void button_clean_Click(object sender, EventArgs e)
        {
           foreach (Figure obj in figures) {
                if (obj.GetType().Name == comboBox1.Text) {
                    obj.Clear(); obj.Draw(new Point(0, 0), new Point(0, 0));
                }
           }
        }
    }
}
