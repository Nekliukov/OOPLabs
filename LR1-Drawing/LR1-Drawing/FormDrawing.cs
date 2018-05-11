using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;

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

        //List that contain all displayed figures !!!
        public List<Figure> DisplayedFigures = new List<Figure>();

        private void button_save_Click(object sender, EventArgs e) {
            using (var stream = new FileStream("objects.xml", FileMode.Create)) {
                XmlSerializer XML = new XmlSerializer(typeof(List<Figure>));
                XML.Serialize(stream, DisplayedFigures);            
            }
        }

        private void button_load_Click(object sender, EventArgs e) {
            DisplayedFigures.Clear();
            DisplayedFigures = LoadFile();
            foreach (Figure el in DisplayedFigures)
                el.DoDraw(graph, el.firstp, el.secondp);
        }

        public List<Figure> LoadFile() {
            using (var stream = new FileStream("objects.xml", FileMode.Open)) {
                XmlSerializer XML = new XmlSerializer(typeof(List<Figure>));
                return (List<Figure>)XML.Deserialize(stream);
            }
        }

        private void FormDrawing_Load(object sender, EventArgs e)
        {
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            WindowState = FormWindowState.Maximized;
            foreach (Figure obj in FigureList.figures){
                comboBox1.Items.Add(obj.GetType().Name);
            }
        }

        // Getting point's coordinates
        private void button_draw_Click(object sender, EventArgs e){
            try {
                Convert.ToInt32(tb_x1.Text);
                Convert.ToInt32(tb_x2.Text);
                if (comboBox1.Text=="Triangle")
                    Convert.ToInt32(tb_x3.Text);
            }
            catch (FormatException) {
                MessageBox.Show("Wrong Data.Please, check point's locations");
                return;
            }
            //Choosing of the figure, that we want to draw
            foreach (Figure obj in FigureList.figures){
                if (obj.GetType().Name == comboBox1.Text) {
                    int last = DisplayedFigures.Count;
                    DisplayedFigures.Add(obj);
                    //Drawing
                    if (DisplayedFigures[last].PatNum == 2)
                        DisplayedFigures[last].DoDraw(graph, new Point(x0, y0), new Point(x1, y1));
                    else
                        DisplayedFigures[last].DoDraw(graph, new Point(x0, y0), new Point(x1, y1), new Point(x2, y2));                    
                    break;
                }
            }
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) {
            tb_x1.Text = tb_x2.Text = tb_y1.Text = tb_y2.Text = tb_x3.Text = tb_y3.Text = "";
        }

        //Canvas and current figures list clearing
        private void button_clean_Click(object sender, EventArgs e){
            graph.Clear(Color.White);
            tb_figures.Clear();
            DisplayedFigures.Clear();
        }
    }
}
