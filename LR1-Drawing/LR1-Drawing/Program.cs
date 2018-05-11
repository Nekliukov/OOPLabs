using System;
using System.Windows.Forms;

namespace LR1_Drawing {
    static class Program {
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormDrawing());
        }
    }
}
