using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace LR1_Drawing
{
    [Serializable]
    public class Configuration {
        public int language;
        public int backgroundcolor;
        public int menucolor;

        [NonSerialized]
        private String[,] dict = {   { "View", "Вид" },
                                     { "Language", "Язык" },
                                     { "Background color", "Цвет фона" },
                                     { "Menu color", "Цвет меню" },
                                     { "Save", "Сохранить" },
                                     { "Draw!", "Рисовать" },
                                     { "Load last work", "Загрузить из файла" },
                                     { "Clean", "Очистить" },
                                     { "Choose figure's type", "Выберите тип фигуры" },
                                     { "Brush color:", "Цвет кисти" },
                                     { "Figures:", "Фигуры" },
                                     { "Circle", "Круг" },
                                     { "Rectangle", "Прямоугольник" },
                                     { "Ellipse", "Элипс" },
                                     { "Line", "Линия" },
                                     { "Rhombus", "Ромб" },
                                     { "Triangle", "Треугольник" },


                                 };


        public void ChangeLanguge(MenuStrip ms, Control menu, ComboBox cb,
                                   ToolStripItemCollection menuEl, int toLang) {
            language = toLang;
            foreach (ToolStripItem el in ms.Items)        
                for (int i = 0; i < 16; i++)
                        if (el.Text == dict[i, toLang^1])
                            el.Text = dict[i, toLang];

                foreach (ToolStripMenuItem el in ms.Items)
                {
                    foreach (ToolStripItem menuItem in el.DropDownItems)
                    {
                        for (int i = 0; i < 16; i++)
                            if (menuItem.Text == dict[i, toLang ^ 1])
                                menuItem.Text = dict[i, toLang];
                    }
                }

                foreach (Control el in menu.Controls)        
                if (el is Label || el is Button || el is ComboBox)
                for (int i = 0; i < 16; i++)
                        if (el.Text == dict[i, toLang ^ 1])
                            el.Text = dict[i, toLang];

                for (int i = 0; i < cb.Items.Count; i++)
                    for (int j = 0; j < 16; j++)
                        if (cb.GetItemText(cb.Items[i]) == dict[j, toLang ^ 1])
                            cb.Items[i] = dict[j, toLang];
        }
   }

}
