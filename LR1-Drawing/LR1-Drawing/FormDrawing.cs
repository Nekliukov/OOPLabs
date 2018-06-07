using FigureClassLibrary;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace LR1_Drawing {
    public partial class FormDrawing : Form {
        public FormDrawing() {
            InitializeComponent();
            AddPlugins();
            comboBox1.Text = FigureList.figures[0].GetType().Name;
            graph = picture.CreateGraphics();

            cb_thikness.Items.Add(1);
            cb_thikness.Items.Add(2);
            cb_thikness.Items.Add(4);
            cb_thikness.Items.Add(6);
            cb_thikness.Items.Add(8);
            cb_thikness.Items.Add(10);
            cb_thikness.Items.Add(12);

            using (var stream = new FileStream("config.xml", FileMode.Open)){
                XmlSerializer XML = new XmlSerializer(typeof(Configuration));
                confSt = (Configuration)XML.Deserialize(stream);
                panel1.BackColor = System.Drawing.Color.FromArgb(confSt.menucolor);
                Configuration langConf = new Configuration();
                langConf.ChangeLanguge(menuStrip1, panel1, comboBox1,
                                    menuStrip1.Items, confSt.language);
            }

        }

        Graphics graph;
        Configuration confSt = new Configuration();
        int x0, y0, x1, y1, x2, y2;

        //List that contains all displayed figures !!!
        public List<Figure> DisplayedFigures = new List<Figure>();

        private void button_save_Click(object sender, EventArgs e) {
            using (var stream = new FileStream("objects.xml", FileMode.Create)) {
                XmlSerializer XML = new XmlSerializer(typeof(List<Figure>));
                XML.Serialize(stream, DisplayedFigures);            
            }
        }

        private void button_load_Click(object sender, EventArgs e) {
            DisplayedFigures.Clear();
            graph.Clear(picture.BackColor);
            lb_figures.Items.Clear();
            try {
                DisplayedFigures = LoadFile();
                foreach (Figure el in DisplayedFigures) {
                    el.DoDraw(graph);
                    lb_figures.Items.Add(el.GetType().Name);
                }
            }
            catch { MessageBox.Show("Error. Cannot read the file"); }
        }

        public List<Figure> LoadFile() {
            using (var stream = new FileStream("objects.xml", FileMode.Open)) {
                XmlSerializer XML = new XmlSerializer(typeof(List<Figure>));
                return (List<Figure>)XML.Deserialize(stream);             
            }
        }

        private void lb_figures_KeyPress(object sender, KeyPressEventArgs e) {
            if (lb_figures.SelectedIndex != -1) {
                if (e.KeyChar == (Char)Keys.Back) {
                    DisplayedFigures.RemoveAt(lb_figures.SelectedIndex);
                    lb_figures.Items.Remove(lb_figures.SelectedItem);
                    //Refresh canvas after deleting
                    graph.Clear(picture.BackColor);
                    foreach (Figure el in DisplayedFigures)
                        el.DoDraw(graph);
                }
            }
        }

        private void button_color_Click(object sender, EventArgs e) {
            ColorDialog cd = new ColorDialog();
            cd.AllowFullOpen = false;
            if (cd.ShowDialog() == DialogResult.OK) {
                button_color.BackColor = cd.Color;
                if (lb_figures.SelectedIndex != -1) {
                    DisplayedFigures[lb_figures.SelectedIndex].BrushColor = cd.Color.ToArgb();
                    graph.Clear(picture.BackColor);
                    foreach (Figure el in DisplayedFigures)
                        el.DoDraw(graph);
                }
            }
        }

        private void cb_thikness_SelectedIndexChanged(object sender, EventArgs e) {
                if (lb_figures.SelectedIndex != -1) {
                    DisplayedFigures[lb_figures.SelectedIndex].BrushThikness =
                        Convert.ToInt32(cb_thikness.Text);
                    graph.Clear(picture.BackColor);
                    foreach (Figure el in DisplayedFigures)
                        el.DoDraw(graph);
                }
        }
        
        private void FormDrawing_Load(object sender, EventArgs e)
        {
            foreach (Figure obj in FigureList.figures){
                comboBox1.Items.Add(confSt.Translate(obj.GetType().Name, confSt.language));
            }
            cb_thikness.Text = "1";
        }

        Configuration cnflang = new Configuration();
        private void englishToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cnflang.ChangeLanguge(menuStrip1, panel1, comboBox1,
                                menuStrip1.Items, 0);
            cnflang.language = 0;
        }

        private void germanyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cnflang.ChangeLanguge(menuStrip1, panel1, comboBox1,
                                menuStrip1.Items, 1);
            cnflang.language = 1;
        }

        private void FormDrawing_FormClosing(object sender, FormClosingEventArgs e) {
            Configuration conf = new Configuration();
            conf.menucolor = panel1.BackColor.ToArgb();
            conf.language = cnflang.language;
            using (var stream = new FileStream("config.xml", FileMode.Create)) {
                XmlSerializer XML = new XmlSerializer(typeof(Configuration));
                XML.Serialize(stream, conf);
            }
        }

        private void menuColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            cd.AllowFullOpen = false;
            if (cd.ShowDialog() == DialogResult.OK)
                panel1.BackColor = cd.Color;
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
                if (obj.GetType().Name == confSt.Translate(comboBox1.Text, 0)) {
                    int last = DisplayedFigures.Count;
                    DisplayedFigures.Add((Figure)obj.Clone(
                        button_color.BackColor.ToArgb(),
                        Convert.ToInt32(cb_thikness.Text)));
                    //Drawing
                    if (DisplayedFigures[last].PatNum == 2)
                        DisplayedFigures[last].DoDraw(graph, new Point(x0, y0), new Point(x1, y1));
                    else
                        DisplayedFigures[last].DoDraw(graph, new Point(x0, y0), new Point(x1, y1), new Point(x2, y2));                    
                    break;
                }
            }
            tb_x1.Text = tb_x2.Text = tb_y1.Text = tb_y2.Text = tb_x3.Text = tb_y3.Text = "";
            lb_figures.Items.Clear();
            foreach (var el in DisplayedFigures)
                lb_figures.Items.Add(el.GetType().Name);
        }

        //Getting mouse coodrdinates
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
            lb_figures.Items.Clear();
            DisplayedFigures.Clear();
        }

        public void AddPlugins() {
            String AddInDir = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);
            var AddInAssemblies = Directory.EnumerateFiles(AddInDir, "*Library.dll");

            foreach (var ass in AddInAssemblies) {
                try {
                    Assembly assembly = Assembly.LoadFrom(ass);
                    Type[] types = assembly.GetExportedTypes();
                    foreach (var type in types){
                        if (type.IsClass && type.GetTypeInfo().BaseType == typeof(
                            Figure) && !type.IsAbstract) {
                            var plugin = Activator.CreateInstance(type);
                            FigureList.figures.Add((Figure)plugin);
                        }
                    }
                }
                catch (Exception ex) {
                    MessageBoxButtons button = MessageBoxButtons.OK;
                    string caption = "Error";
                    MessageBox.Show(ex.Message, caption, button);
                }
            }
        }
    }
}
