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
            ((System.ComponentModel.ISupportInitialize)(this.picture)).BeginInit();
            this.SuspendLayout();
            // 
            // picture
            // 
            this.picture.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.picture.Dock = System.Windows.Forms.DockStyle.Top;
            this.picture.Location = new System.Drawing.Point(0, 0);
            this.picture.Name = "picture";
            this.picture.Size = new System.Drawing.Size(986, 394);
            this.picture.TabIndex = 0;
            this.picture.TabStop = false;
            this.picture.MouseClick += new System.Windows.Forms.MouseEventHandler(this.picture_MouseClick);
            // 
            // button_draw
            // 
            this.button_draw.Location = new System.Drawing.Point(786, 455);
            this.button_draw.Name = "button_draw";
            this.button_draw.Size = new System.Drawing.Size(188, 47);
            this.button_draw.TabIndex = 1;
            this.button_draw.Text = "Draw!";
            this.button_draw.UseVisualStyleBackColor = true;
            this.button_draw.Click += new System.EventHandler(this.button_draw_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Line",
            "Rectangle",
            "Triangle",
            "Circle",
            "Rhomb"});
            this.comboBox1.Location = new System.Drawing.Point(3, 400);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(201, 21);
            this.comboBox1.TabIndex = 2;
            // 
            // tb_x1
            // 
            this.tb_x1.Location = new System.Drawing.Point(6, 440);
            this.tb_x1.Name = "tb_x1";
            this.tb_x1.Size = new System.Drawing.Size(50, 20);
            this.tb_x1.TabIndex = 3;
            // 
            // tb_y1
            // 
            this.tb_y1.Location = new System.Drawing.Point(75, 439);
            this.tb_y1.Name = "tb_y1";
            this.tb_y1.Size = new System.Drawing.Size(47, 20);
            this.tb_y1.TabIndex = 4;
            // 
            // label_x1
            // 
            this.label_x1.AutoSize = true;
            this.label_x1.Location = new System.Drawing.Point(21, 424);
            this.label_x1.Name = "label_x1";
            this.label_x1.Size = new System.Drawing.Size(20, 13);
            this.label_x1.TabIndex = 6;
            this.label_x1.Text = "X1";
            // 
            // label_y1
            // 
            this.label_y1.AutoSize = true;
            this.label_y1.Location = new System.Drawing.Point(88, 424);
            this.label_y1.Name = "label_y1";
            this.label_y1.Size = new System.Drawing.Size(20, 13);
            this.label_y1.TabIndex = 7;
            this.label_y1.Text = "Y1";
            // 
            // tb_x2
            // 
            this.tb_x2.Location = new System.Drawing.Point(6, 488);
            this.tb_x2.Name = "tb_x2";
            this.tb_x2.Size = new System.Drawing.Size(50, 20);
            this.tb_x2.TabIndex = 8;
            // 
            // label_x2
            // 
            this.label_x2.AutoSize = true;
            this.label_x2.Location = new System.Drawing.Point(21, 472);
            this.label_x2.Name = "label_x2";
            this.label_x2.Size = new System.Drawing.Size(20, 13);
            this.label_x2.TabIndex = 9;
            this.label_x2.Text = "X2";
            // 
            // label_y2
            // 
            this.label_y2.AutoSize = true;
            this.label_y2.Location = new System.Drawing.Point(88, 472);
            this.label_y2.Name = "label_y2";
            this.label_y2.Size = new System.Drawing.Size(20, 13);
            this.label_y2.TabIndex = 10;
            this.label_y2.Text = "Y2";
            // 
            // tb_y2
            // 
            this.tb_y2.Location = new System.Drawing.Point(75, 488);
            this.tb_y2.Name = "tb_y2";
            this.tb_y2.Size = new System.Drawing.Size(47, 20);
            this.tb_y2.TabIndex = 11;
            // 
            // FormDrawing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 518);
            this.Controls.Add(this.tb_y2);
            this.Controls.Add(this.label_y2);
            this.Controls.Add(this.label_x2);
            this.Controls.Add(this.tb_x2);
            this.Controls.Add(this.label_y1);
            this.Controls.Add(this.label_x1);
            this.Controls.Add(this.tb_y1);
            this.Controls.Add(this.tb_x1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button_draw);
            this.Controls.Add(this.picture);
            this.Name = "FormDrawing";
            this.Text = "Drawing";
            ((System.ComponentModel.ISupportInitialize)(this.picture)).EndInit();
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
    }
}

