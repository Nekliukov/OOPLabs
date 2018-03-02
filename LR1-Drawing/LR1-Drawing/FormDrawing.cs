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
            Figure F = new Rectangle(picture, 10, 10, 100, 700);
            F.Draw();
        }
    }
}
