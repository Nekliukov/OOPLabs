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
            this.tb_x3 = new System.Windows.Forms.TextBox();
            this.tb_y3 = new System.Windows.Forms.TextBox();
            this.label_x3 = new System.Windows.Forms.Label();
            this.label_y3 = new System.Windows.Forms.Label();
            this.label_choice = new System.Windows.Forms.Label();
            this.label_instr = new System.Windows.Forms.Label();
            this.label_info = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // picture
            // 
            this.picture.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.picture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picture.Location = new System.Drawing.Point(0, 0);
            this.picture.Name = "picture";
            this.picture.Size = new System.Drawing.Size(986, 518);
            this.picture.TabIndex = 0;
            this.picture.TabStop = false;
            this.picture.MouseClick += new System.Windows.Forms.MouseEventHandler(this.picture_MouseClick);
            // 
            // button_draw
            // 
            this.button_draw.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_draw.Location = new System.Drawing.Point(777, 88);
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
            this.comboBox1.Location = new System.Drawing.Point(14, 33);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(201, 21);
            this.comboBox1.TabIndex = 2;
            // 
            // tb_x1
            // 
            this.tb_x1.Location = new System.Drawing.Point(14, 60);
            this.tb_x1.Name = "tb_x1";
            this.tb_x1.Size = new System.Drawing.Size(50, 20);
            this.tb_x1.TabIndex = 3;
            // 
            // tb_y1
            // 
            this.tb_y1.Location = new System.Drawing.Point(145, 60);
            this.tb_y1.Name = "tb_y1";
            this.tb_y1.Size = new System.Drawing.Size(47, 20);
            this.tb_y1.TabIndex = 4;
            // 
            // label_x1
            // 
            this.label_x1.AutoSize = true;
            this.label_x1.Location = new System.Drawing.Point(70, 63);
            this.label_x1.Name = "label_x1";
            this.label_x1.Size = new System.Drawing.Size(20, 13);
            this.label_x1.TabIndex = 6;
            this.label_x1.Text = "X1";
            // 
            // label_y1
            // 
            this.label_y1.AutoSize = true;
            this.label_y1.Location = new System.Drawing.Point(195, 63);
            this.label_y1.Name = "label_y1";
            this.label_y1.Size = new System.Drawing.Size(20, 13);
            this.label_y1.TabIndex = 7;
            this.label_y1.Text = "Y1";
            // 
            // tb_x2
            // 
            this.tb_x2.Location = new System.Drawing.Point(14, 89);
            this.tb_x2.Name = "tb_x2";
            this.tb_x2.Size = new System.Drawing.Size(50, 20);
            this.tb_x2.TabIndex = 8;
            // 
            // label_x2
            // 
            this.label_x2.AutoSize = true;
            this.label_x2.Location = new System.Drawing.Point(70, 92);
            this.label_x2.Name = "label_x2";
            this.label_x2.Size = new System.Drawing.Size(20, 13);
            this.label_x2.TabIndex = 9;
            this.label_x2.Text = "X2";
            // 
            // label_y2
            // 
            this.label_y2.AutoSize = true;
            this.label_y2.Location = new System.Drawing.Point(195, 92);
            this.label_y2.Name = "label_y2";
            this.label_y2.Size = new System.Drawing.Size(20, 13);
            this.label_y2.TabIndex = 10;
            this.label_y2.Text = "Y2";
            // 
            // tb_y2
            // 
            this.tb_y2.Location = new System.Drawing.Point(145, 89);
            this.tb_y2.Name = "tb_y2";
            this.tb_y2.Size = new System.Drawing.Size(47, 20);
            this.tb_y2.TabIndex = 11;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label_info);
            this.panel1.Controls.Add(this.label_instr);
            this.panel1.Controls.Add(this.label_choice);
            this.panel1.Controls.Add(this.button_draw);
            this.panel1.Controls.Add(this.label_y3);
            this.panel1.Controls.Add(this.label_x3);
            this.panel1.Controls.Add(this.tb_y3);
            this.panel1.Controls.Add(this.tb_x3);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.tb_y2);
            this.panel1.Controls.Add(this.tb_x1);
            this.panel1.Controls.Add(this.label_y2);
            this.panel1.Controls.Add(this.label_x1);
            this.panel1.Controls.Add(this.label_x2);
            this.panel1.Controls.Add(this.tb_y1);
            this.panel1.Controls.Add(this.tb_x2);
            this.panel1.Controls.Add(this.label_y1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 371);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(986, 147);
            this.panel1.TabIndex = 12;
            // 
            // tb_x3
            // 
            this.tb_x3.Location = new System.Drawing.Point(14, 115);
            this.tb_x3.Name = "tb_x3";
            this.tb_x3.Size = new System.Drawing.Size(50, 20);
            this.tb_x3.TabIndex = 12;
            // 
            // tb_y3
            // 
            this.tb_y3.Location = new System.Drawing.Point(145, 115);
            this.tb_y3.Name = "tb_y3";
            this.tb_y3.Size = new System.Drawing.Size(47, 20);
            this.tb_y3.TabIndex = 13;
            // 
            // label_x3
            // 
            this.label_x3.AutoSize = true;
            this.label_x3.Location = new System.Drawing.Point(70, 118);
            this.label_x3.Name = "label_x3";
            this.label_x3.Size = new System.Drawing.Size(20, 13);
            this.label_x3.TabIndex = 14;
            this.label_x3.Text = "X3";
            // 
            // label_y3
            // 
            this.label_y3.AutoSize = true;
            this.label_y3.Location = new System.Drawing.Point(195, 118);
            this.label_y3.Name = "label_y3";
            this.label_y3.Size = new System.Drawing.Size(20, 13);
            this.label_y3.TabIndex = 15;
            this.label_y3.Text = "Y3";
            // 
            // label_choice
            // 
            this.label_choice.AutoSize = true;
            this.label_choice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_choice.Location = new System.Drawing.Point(10, 10);
            this.label_choice.Name = "label_choice";
            this.label_choice.Size = new System.Drawing.Size(153, 20);
            this.label_choice.TabIndex = 16;
            this.label_choice.Text = "Choose figure\'s type";
            // 
            // label_instr
            // 
            this.label_instr.AutoSize = true;
            this.label_instr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_instr.Location = new System.Drawing.Point(274, 10);
            this.label_instr.Name = "label_instr";
            this.label_instr.Size = new System.Drawing.Size(96, 20);
            this.label_instr.TabIndex = 17;
            this.label_instr.Text = "Instructions:";
            // 
            // label_info
            // 
            this.label_info.AutoSize = true;
            this.label_info.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_info.Location = new System.Drawing.Point(297, 34);
            this.label_info.Name = "label_info";
            this.label_info.Size = new System.Drawing.Size(81, 20);
            this.label_info.TabIndex = 18;
            this.label_info.Text = "Some info";
            // 
            // FormDrawing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 518);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.picture);
            this.Name = "FormDrawing";
            this.Text = "Drawing";
            this.Load += new System.EventHandler(this.FormDrawing_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picture)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Label label_y3;
        private System.Windows.Forms.Label label_x3;
        private System.Windows.Forms.TextBox tb_y3;
        private System.Windows.Forms.TextBox tb_x3;
        private System.Windows.Forms.Label label_info;
        private System.Windows.Forms.Label label_instr;
    }
}

