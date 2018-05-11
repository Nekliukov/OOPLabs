using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace LR1_Drawing {
    public partial class FormDrawing : Form {
        public FormDrawing() {
            InitializeComponent();
            FigureList.LoadFigures(new Pen(Color.Black, 3));
            comboBox1.Text = FigureList.figures[0].GetType().Name;
            graph = picture.CreateGraphics();
        }

        Graphics graph;
        int x0, y0, x1, y1, x2, y2;
        public static List<Figure> DisplayedFigures = new List<Figure>();

        private void FormDrawing_Load(object sender, EventArgs e)
        {
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            WindowState = FormWindowState.Maximized;
            foreach (Figure obj in FigureList.figures)
            {
                comboBox1.Items.Add(obj.GetType().Name);
            }
        }

        // Getting point's coordinates
        private void button_draw_Click(object sender, EventArgs e)
        {
            //Choosing of the figure, that we want to draw
            foreach (Figure obj in FigureList.figures)
            {
                if (obj.GetType().Name == comboBox1.Text)
                    //Drawing
                    //if (obj.PatNum == 2)
                    //obj.Do_Draw(new Point(x0, y0), new Point(x1, y1));
                    //try {  }
                    // catch { MessageBox.Show("Check points, please!"); return; }
                    //else
                    // { // Case, if we need one more point for drawing (for ex. Triangle)
                    DisplayedFigures.Add(obj);
                //try { DisplayedFigures.Do_Draw(new Point(x0, y0), new Point(x1, y1), new Point(x2, y2)); }
                //
                //}                
            }
            try { DisplayedFigures[DisplayedFigures.Count - 1].Do_Draw(graph, new Point(x0, y0), new Point(x1, y1)); }
            catch { MessageBox.Show("Check points, please!"); return; }
            tb_x1.Text = tb_x2.Text = tb_y1.Text = tb_y2.Text = tb_x3.Text = tb_y3.Text = "";
            tb_figures.Clear();
            foreach (var el in DisplayedFigures)
                tb_figures.Text += el.ToString().Substring(12) + Environment.NewLine;       
        }

        private void picture_MouseClick(object sender, MouseEventArgs e) {
            int X = e.Location.X, Y = e.Location.Y;
            if (tb_x1.Text == "") {
                tb_x1.Text = Convert.ToString(X);
                tb_y1.Text = Convert.ToString(Y);
                x0 = X; y0 = Y; return;
            }

            if (tb_x2.Text == "") {
                tb_x2.Text = Convert.ToString(X);
                tb_y2.Text = Convert.ToString(Y);
                x1 = X; y1 = Y; return;
            }

            foreach (Figure obj in FigureList.figures)
            {
                if (obj.GetType().Name == comboBox1.Text) {
                    if (obj.PatNum == 3) {
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
            foreach (Figure obj in FigureList.figures) {
                if (obj.GetType().Name == comboBox1.Text) {
                    obj.Instructions(rtb_info);
                }
            }
        }

        //Wierd realisation of bitmap's clearing 
        private void button_clean_Click(object sender, EventArgs e){
            graph.Clear(Color.White);
            DisplayedFigures.Clear();
        }
    }
}
