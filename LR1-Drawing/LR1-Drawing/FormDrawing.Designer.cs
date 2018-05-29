namespace LR1_Drawing {
    partial class FormDrawing {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && ( components != null )) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent() {
            this.picture = new System.Windows.Forms.PictureBox();
            this.button_draw = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.tb_x1 = new System.Windows.Forms.TextBox();
            this.tb_y1 = new System.Windows.Forms.TextBox();
            this.label_x1 = new System.Windows.Forms.Label();
            this.label_y1 = new System.Windows.Forms.Label();
            this.tb_x2 = new System.Windows.Forms.TextBox();
            this.label_x2 = new System.Windows.Forms.Label();
            this.label_y2 = new System.Windows.Forms.Label();
            this.tb_y2 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_save = new System.Windows.Forms.Button();
            this.cb_thikness = new System.Windows.Forms.ComboBox();
            this.button_color = new System.Windows.Forms.Button();
            this.label_thikness = new System.Windows.Forms.Label();
            this.label_brush = new System.Windows.Forms.Label();
            this.lb_figures = new System.Windows.Forms.ListBox();
            this.button_load = new System.Windows.Forms.Button();
            this.button_clean = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_y3 = new System.Windows.Forms.TextBox();
            this.label_y3 = new System.Windows.Forms.Label();
            this.label_x3 = new System.Windows.Forms.Label();
            this.tb_x3 = new System.Windows.Forms.TextBox();
            this.label_choice = new System.Windows.Forms.Label();
            this.colorDialog_brush = new System.Windows.Forms.ColorDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.languageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.englishToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.germanyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).BeginInit();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // picture
            // 
            this.picture.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.picture.Location = new System.Drawing.Point(0, 24);
            this.picture.Name = "picture";
            this.picture.Size = new System.Drawing.Size(1208, 689);
            this.picture.TabIndex = 0;
            this.picture.TabStop = false;
            this.picture.MouseClick += new System.Windows.Forms.MouseEventHandler(this.picture_MouseClick);
            // 
            // button_draw
            // 
            this.button_draw.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_draw.Location = new System.Drawing.Point(20, 612);
            this.button_draw.Name = "button_draw";
            this.button_draw.Size = new System.Drawing.Size(209, 37);
            this.button_draw.TabIndex = 1;
            this.button_draw.Text = "Draw!";
            this.button_draw.UseVisualStyleBackColor = true;
            this.button_draw.Click += new System.EventHandler(this.button_draw_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(15, 49);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(201, 28);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // tb_x1
            // 
            this.tb_x1.Location = new System.Drawing.Point(15, 90);
            this.tb_x1.Name = "tb_x1";
            this.tb_x1.Size = new System.Drawing.Size(50, 26);
            this.tb_x1.TabIndex = 3;
            // 
            // tb_y1
            // 
            this.tb_y1.Location = new System.Drawing.Point(143, 91);
            this.tb_y1.Name = "tb_y1";
            this.tb_y1.Size = new System.Drawing.Size(47, 26);
            this.tb_y1.TabIndex = 4;
            // 
            // label_x1
            // 
            this.label_x1.AutoSize = true;
            this.label_x1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_x1.Location = new System.Drawing.Point(71, 93);
            this.label_x1.Name = "label_x1";
            this.label_x1.Size = new System.Drawing.Size(29, 20);
            this.label_x1.TabIndex = 6;
            this.label_x1.Text = "X1";
            // 
            // label_y1
            // 
            this.label_y1.AutoSize = true;
            this.label_y1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_y1.Location = new System.Drawing.Point(196, 93);
            this.label_y1.Name = "label_y1";
            this.label_y1.Size = new System.Drawing.Size(29, 20);
            this.label_y1.TabIndex = 7;
            this.label_y1.Text = "Y1";
            // 
            // tb_x2
            // 
            this.tb_x2.Location = new System.Drawing.Point(15, 123);
            this.tb_x2.Name = "tb_x2";
            this.tb_x2.Size = new System.Drawing.Size(50, 26);
            this.tb_x2.TabIndex = 8;
            // 
            // label_x2
            // 
            this.label_x2.AutoSize = true;
            this.label_x2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_x2.Location = new System.Drawing.Point(71, 126);
            this.label_x2.Name = "label_x2";
            this.label_x2.Size = new System.Drawing.Size(29, 20);
            this.label_x2.TabIndex = 9;
            this.label_x2.Text = "X2";
            // 
            // label_y2
            // 
            this.label_y2.AutoSize = true;
            this.label_y2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_y2.Location = new System.Drawing.Point(196, 126);
            this.label_y2.Name = "label_y2";
            this.label_y2.Size = new System.Drawing.Size(29, 20);
            this.label_y2.TabIndex = 10;
            this.label_y2.Text = "Y2";
            // 
            // tb_y2
            // 
            this.tb_y2.Location = new System.Drawing.Point(143, 123);
            this.tb_y2.Name = "tb_y2";
            this.tb_y2.Size = new System.Drawing.Size(47, 26);
            this.tb_y2.TabIndex = 11;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button_save);
            this.panel1.Controls.Add(this.cb_thikness);
            this.panel1.Controls.Add(this.button_color);
            this.panel1.Controls.Add(this.label_thikness);
            this.panel1.Controls.Add(this.label_brush);
            this.panel1.Controls.Add(this.lb_figures);
            this.panel1.Controls.Add(this.button_load);
            this.panel1.Controls.Add(this.button_clean);
            this.panel1.Controls.Add(this.button_draw);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.tb_y3);
            this.panel1.Controls.Add(this.label_y3);
            this.panel1.Controls.Add(this.label_x3);
            this.panel1.Controls.Add(this.tb_x3);
            this.panel1.Controls.Add(this.label_choice);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.tb_y2);
            this.panel1.Controls.Add(this.tb_x1);
            this.panel1.Controls.Add(this.label_y2);
            this.panel1.Controls.Add(this.label_x1);
            this.panel1.Controls.Add(this.label_x2);
            this.panel1.Controls.Add(this.tb_y1);
            this.panel1.Controls.Add(this.tb_x2);
            this.panel1.Controls.Add(this.label_y1);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(274, 689);
            this.panel1.TabIndex = 12;
            // 
            // button_save
            // 
            this.button_save.Enabled = false;
            this.button_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_save.Location = new System.Drawing.Point(20, 449);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(209, 37);
            this.button_save.TabIndex = 27;
            this.button_save.Text = "Save";
            this.button_save.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.button_save.UseVisualStyleBackColor = true;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // cb_thikness
            // 
            this.cb_thikness.FormattingEnabled = true;
            this.cb_thikness.Location = new System.Drawing.Point(143, 231);
            this.cb_thikness.Name = "cb_thikness";
            this.cb_thikness.Size = new System.Drawing.Size(73, 28);
            this.cb_thikness.TabIndex = 32;
            this.cb_thikness.SelectedIndexChanged += new System.EventHandler(this.cb_thikness_SelectedIndexChanged);
            // 
            // button_color
            // 
            this.button_color.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_color.Location = new System.Drawing.Point(141, 193);
            this.button_color.Name = "button_color";
            this.button_color.Size = new System.Drawing.Size(75, 32);
            this.button_color.TabIndex = 31;
            this.button_color.UseVisualStyleBackColor = false;
            this.button_color.Click += new System.EventHandler(this.button_color_Click);
            // 
            // label_thikness
            // 
            this.label_thikness.AutoSize = true;
            this.label_thikness.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_thikness.Location = new System.Drawing.Point(15, 234);
            this.label_thikness.Name = "label_thikness";
            this.label_thikness.Size = new System.Drawing.Size(76, 20);
            this.label_thikness.TabIndex = 30;
            this.label_thikness.Text = "Thikness:";
            // 
            // label_brush
            // 
            this.label_brush.AutoSize = true;
            this.label_brush.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_brush.Location = new System.Drawing.Point(15, 197);
            this.label_brush.Name = "label_brush";
            this.label_brush.Size = new System.Drawing.Size(93, 20);
            this.label_brush.TabIndex = 29;
            this.label_brush.Text = "Brush color:";
            // 
            // lb_figures
            // 
            this.lb_figures.FormattingEnabled = true;
            this.lb_figures.ItemHeight = 20;
            this.lb_figures.Location = new System.Drawing.Point(17, 324);
            this.lb_figures.Name = "lb_figures";
            this.lb_figures.Size = new System.Drawing.Size(211, 104);
            this.lb_figures.TabIndex = 13;
            this.lb_figures.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.lb_figures_KeyPress);
            // 
            // button_load
            // 
            this.button_load.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_load.Location = new System.Drawing.Point(20, 492);
            this.button_load.Name = "button_load";
            this.button_load.Size = new System.Drawing.Size(209, 37);
            this.button_load.TabIndex = 28;
            this.button_load.Text = "Load last work";
            this.button_load.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.button_load.UseVisualStyleBackColor = true;
            this.button_load.Click += new System.EventHandler(this.button_load_Click);
            // 
            // button_clean
            // 
            this.button_clean.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_clean.Location = new System.Drawing.Point(20, 567);
            this.button_clean.Name = "button_clean";
            this.button_clean.Size = new System.Drawing.Size(210, 39);
            this.button_clean.TabIndex = 24;
            this.button_clean.Text = "Clean";
            this.button_clean.UseVisualStyleBackColor = true;
            this.button_clean.Click += new System.EventHandler(this.button_clean_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(14, 286);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 20);
            this.label1.TabIndex = 26;
            this.label1.Text = "Figures:";
            // 
            // tb_y3
            // 
            this.tb_y3.Location = new System.Drawing.Point(143, 155);
            this.tb_y3.Name = "tb_y3";
            this.tb_y3.Size = new System.Drawing.Size(47, 26);
            this.tb_y3.TabIndex = 23;
            // 
            // label_y3
            // 
            this.label_y3.AutoSize = true;
            this.label_y3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_y3.Location = new System.Drawing.Point(196, 158);
            this.label_y3.Name = "label_y3";
            this.label_y3.Size = new System.Drawing.Size(29, 20);
            this.label_y3.TabIndex = 22;
            this.label_y3.Text = "Y3";
            // 
            // label_x3
            // 
            this.label_x3.AutoSize = true;
            this.label_x3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_x3.Location = new System.Drawing.Point(71, 158);
            this.label_x3.Name = "label_x3";
            this.label_x3.Size = new System.Drawing.Size(29, 20);
            this.label_x3.TabIndex = 21;
            this.label_x3.Text = "X3";
            // 
            // tb_x3
            // 
            this.tb_x3.Location = new System.Drawing.Point(15, 155);
            this.tb_x3.Name = "tb_x3";
            this.tb_x3.Size = new System.Drawing.Size(50, 26);
            this.tb_x3.TabIndex = 20;
            // 
            // label_choice
            // 
            this.label_choice.AutoSize = true;
            this.label_choice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_choice.Location = new System.Drawing.Point(11, 17);
            this.label_choice.Name = "label_choice";
            this.label_choice.Size = new System.Drawing.Size(153, 20);
            this.label_choice.TabIndex = 16;
            this.label_choice.Text = "Choose figure\'s type";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewToolStripMenuItem,
            this.languageToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1089, 24);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backgroundColorToolStripMenuItem,
            this.menuColorToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // backgroundColorToolStripMenuItem
            // 
            this.backgroundColorToolStripMenuItem.Name = "backgroundColorToolStripMenuItem";
            this.backgroundColorToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.backgroundColorToolStripMenuItem.Text = "Background color";
            this.backgroundColorToolStripMenuItem.Click += new System.EventHandler(this.backgroundColorToolStripMenuItem_Click);
            // 
            // menuColorToolStripMenuItem
            // 
            this.menuColorToolStripMenuItem.Name = "menuColorToolStripMenuItem";
            this.menuColorToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.menuColorToolStripMenuItem.Text = "Menu color";
            this.menuColorToolStripMenuItem.Click += new System.EventHandler(this.menuColorToolStripMenuItem_Click);
            // 
            // languageToolStripMenuItem
            // 
            this.languageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.englishToolStripMenuItem,
            this.germanyToolStripMenuItem});
            this.languageToolStripMenuItem.Name = "languageToolStripMenuItem";
            this.languageToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.languageToolStripMenuItem.Text = "Language";
            // 
            // englishToolStripMenuItem
            // 
            this.englishToolStripMenuItem.Checked = true;
            this.englishToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.englishToolStripMenuItem.Name = "englishToolStripMenuItem";
            this.englishToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.englishToolStripMenuItem.Text = "English";
            this.englishToolStripMenuItem.Click += new System.EventHandler(this.englishToolStripMenuItem_Click);
            // 
            // germanyToolStripMenuItem
            // 
            this.germanyToolStripMenuItem.Name = "germanyToolStripMenuItem";
            this.germanyToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.germanyToolStripMenuItem.Text = "Русский";
            this.germanyToolStripMenuItem.Click += new System.EventHandler(this.germanyToolStripMenuItem_Click);
            // 
            // FormDrawing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1089, 685);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.picture);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormDrawing";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Drawing";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormDrawing_FormClosing);
            this.Load += new System.EventHandler(this.FormDrawing_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picture)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picture;
        private System.Windows.Forms.Button button_draw;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox tb_x1;
        private System.Windows.Forms.TextBox tb_y1;
        private System.Windows.Forms.Label label_x1;
        private System.Windows.Forms.Label label_y1;
        private System.Windows.Forms.TextBox tb_x2;
        private System.Windows.Forms.Label label_x2;
        private System.Windows.Forms.Label label_y2;
        private System.Windows.Forms.TextBox tb_y2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label_choice;
        private System.Windows.Forms.TextBox tb_y3;
        private System.Windows.Forms.Label label_y3;
        private System.Windows.Forms.Label label_x3;
        private System.Windows.Forms.TextBox tb_x3;
        private System.Windows.Forms.Button button_clean;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.Button button_load;
        private System.Windows.Forms.ListBox lb_figures;
        private System.Windows.Forms.Label label_thikness;
        private System.Windows.Forms.Label label_brush;
        private System.Windows.Forms.ColorDialog colorDialog_brush;
        private System.Windows.Forms.ComboBox cb_thikness;
        private System.Windows.Forms.Button button_color;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backgroundColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem languageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem englishToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem germanyToolStripMenuItem;
    }
}

