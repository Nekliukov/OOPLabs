using System;
using System.Drawing;
using System.Windows.Forms;

namespace LR1_Drawing {
    public partial class FormDrawing : Form {
        public FormDrawing() {
            InitializeComponent();         
        }
       
        public Bitmap curr_bit;     // For saving current Bitmap's state
        int x0, y0, x1, y1, x2, y2;

        private void FormDrawing_Load(object sender, EventArgs e) {
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            WindowState = FormWindowState.Maximized;
            //Saving current bitmap state for initial drawing
            curr_bit = new Bitmap(picture.Width, picture.Height);
            FigureList.LoadFigures(picture);

            foreach (Figure obj in FigureList.figures) {
                comboBox1.Items.Add(obj.GetType().Name);
            }
        }

        // Getting point's coordinates
        private void button_draw_Click(object sender, EventArgs e) {
            try {
                Convert.ToInt32(tb_x1.Text);
                Convert.ToInt32(tb_x2.Text);
            } catch (FormatException) {
                MessageBox.Show("Wrong Data.Please, check point's locations");
                return;
            }

            //Choosing of the figure, that we want to draw
            foreach (Figure obj in FigureList.figures) {
                obj.bmp = curr_bit; //getting the last bitmap state to save the last draws
                if (obj.GetType().Name == comboBox1.Text)
                    //Drawing
                    if (obj.PatNum == 2) 
                        obj.Do_Draw(new Point(x0, y0), new Point(x1, y1));
                    else // Case, if we need one more point for drawing (for ex. Triangle)
                        try { obj.Do_Draw(new Point(x0, y0), new Point(x1, y1), new Point(x2, y2)); }
                        catch { MessageBox.Show("Please, add the 3rd point!"); return; }                
            }
            tb_x1.Text = tb_x2.Text = tb_y1.Text = tb_y2.Text = tb_x3.Text = tb_y3.Text = "";
        }

        private void picture_MouseClick(object sender, MouseEventArgs e)
        {
            int X = e.Location.X , Y = e.Location.Y;
            if (tb_x1.Text == ""){
                tb_x1.Text = Convert.ToString(X);
                tb_y1.Text = Convert.ToString(Y);
                x0 = X; y0 = Y; return;
            }

            if (tb_x2.Text == ""){
                tb_x2.Text = Convert.ToString(X);
                tb_y2.Text = Convert.ToString(Y);
                x1 = X; y1 = Y; return;
            }

            foreach (Figure obj in FigureList.figures) {
                if (obj.GetType().Name == comboBox1.Text) {
                    if (obj.PatNum == 3){
                        tb_x3.Text = Convert.ToString(X);
                        tb_y3.Text = Convert.ToString(Y);
                        x2 = X; y2 = Y; break;
                    }
                }
            }
        }  
        
        // Refreshing textboxes coordinates, loading of the current figure's instructions 
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) {
            tb_x1.Text = tb_x2.Text = tb_y1.Text = tb_y2.Text = tb_x3.Text = tb_y3.Text = "";
            foreach (Figure obj in FigureList.figures){
                if (obj.GetType().Name == comboBox1.Text) {
                    obj.Instructions(rtb_info);
                }
            }           
        }

        //Wierd realisation of bitmap's clearing 
        private void button_clean_Click(object sender, EventArgs e) {
           foreach (Figure obj in FigureList.figures) {
                obj.Clear(); obj.Do_Draw(new Point(0, 0), new Point(0, 0));
                break;
           }
        }
    }
}
