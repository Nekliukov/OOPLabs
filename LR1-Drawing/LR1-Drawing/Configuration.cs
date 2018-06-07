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
                                     { "Thikness:", "Толщина:" },
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
            foreach (ToolStripItem el in ms.Items)
                el.Text = Translate(el.Text, toLang);

            foreach (ToolStripMenuItem el in ms.Items)
                foreach (ToolStripItem menuItem in el.DropDownItems)
                    menuItem.Text = Translate(menuItem.Text, toLang);

            foreach (Control el in menu.Controls)
                if (el is Label || el is Button || el is ComboBox)
                    el.Text = Translate(el.Text, toLang);

            for (int i = 0; i < cb.Items.Count; i++)
                for (int j = 0; j < dict.GetLength(0); j++)
                    if (cb.GetItemText(cb.Items[i]) == dict[j, toLang ^ 1])
                        cb.Items[i] = dict[j, toLang];

           cb.Text = Translate(cb.Text, toLang);
        }

        public string Translate(string word, int toLang) {
            for (int i = 0; i < dict.GetLength(0); i++)
                if (word == dict[i, toLang ^ 1])
                    return dict[i, toLang];
            return word;

        }
    }

}
