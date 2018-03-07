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
            this.button_clean = new System.Windows.Forms.Button();
            this.tb_y3 = new System.Windows.Forms.TextBox();
            this.label_y3 = new System.Windows.Forms.Label();
            this.label_x3 = new System.Windows.Forms.Label();
            this.tb_x3 = new System.Windows.Forms.TextBox();
            this.rtb_info = new System.Windows.Forms.RichTextBox();
            this.label_instr = new System.Windows.Forms.Label();
            this.label_choice = new System.Windows.Forms.Label();
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
            this.picture.Size = new System.Drawing.Size(1370, 749);
            this.picture.TabIndex = 0;
            this.picture.TabStop = false;
            this.picture.MouseClick += new System.Windows.Forms.MouseEventHandler(this.picture_MouseClick);
            // 
            // button_draw
            // 
            this.button_draw.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_draw.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_draw.Location = new System.Drawing.Point(1149, 121);
            this.button_draw.Name = "button_draw";
            this.button_draw.Size = new System.Drawing.Size(188, 47);
            this.button_draw.TabIndex = 1;
            this.button_draw.Text = "Draw!";
            this.button_draw.UseVisualStyleBackColor = true;
            this.button_draw.Click += new System.EventHandler(this.button_draw_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(14, 39);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(201, 28);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.Text = "Line";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // tb_x1
            // 
            this.tb_x1.Location = new System.Drawing.Point(14, 80);
            this.tb_x1.Name = "tb_x1";
            this.tb_x1.Size = new System.Drawing.Size(50, 26);
            this.tb_x1.TabIndex = 3;
            // 
            // tb_y1
            // 
            this.tb_y1.Location = new System.Drawing.Point(142, 81);
            this.tb_y1.Name = "tb_y1";
            this.tb_y1.Size = new System.Drawing.Size(47, 26);
            this.tb_y1.TabIndex = 4;
            // 
            // label_x1
            // 
            this.label_x1.AutoSize = true;
            this.label_x1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_x1.Location = new System.Drawing.Point(70, 83);
            this.label_x1.Name = "label_x1";
            this.label_x1.Size = new System.Drawing.Size(29, 20);
            this.label_x1.TabIndex = 6;
            this.label_x1.Text = "X1";
            // 
            // label_y1
            // 
            this.label_y1.AutoSize = true;
            this.label_y1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_y1.Location = new System.Drawing.Point(195, 83);
            this.label_y1.Name = "label_y1";
            this.label_y1.Size = new System.Drawing.Size(29, 20);
            this.label_y1.TabIndex = 7;
            this.label_y1.Text = "Y1";
            // 
            // tb_x2
            // 
            this.tb_x2.Location = new System.Drawing.Point(14, 113);
            this.tb_x2.Name = "tb_x2";
            this.tb_x2.Size = new System.Drawing.Size(50, 26);
            this.tb_x2.TabIndex = 8;
            // 
            // label_x2
            // 
            this.label_x2.AutoSize = true;
            this.label_x2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_x2.Location = new System.Drawing.Point(70, 116);
            this.label_x2.Name = "label_x2";
            this.label_x2.Size = new System.Drawing.Size(29, 20);
            this.label_x2.TabIndex = 9;
            this.label_x2.Text = "X2";
            // 
            // label_y2
            // 
            this.label_y2.AutoSize = true;
            this.label_y2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_y2.Location = new System.Drawing.Point(195, 116);
            this.label_y2.Name = "label_y2";
            this.label_y2.Size = new System.Drawing.Size(29, 20);
            this.label_y2.TabIndex = 10;
            this.label_y2.Text = "Y2";
            // 
            // tb_y2
            // 
            this.tb_y2.Location = new System.Drawing.Point(142, 113);
            this.tb_y2.Name = "tb_y2";
            this.tb_y2.Size = new System.Drawing.Size(47, 26);
            this.tb_y2.TabIndex = 11;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button_clean);
            this.panel1.Controls.Add(this.tb_y3);
            this.panel1.Controls.Add(this.label_y3);
            this.panel1.Controls.Add(this.label_x3);
            this.panel1.Controls.Add(this.tb_x3);
            this.panel1.Controls.Add(this.rtb_info);
            this.panel1.Controls.Add(this.label_instr);
            this.panel1.Controls.Add(this.label_choice);
            this.panel1.Controls.Add(this.button_draw);
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
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel1.Location = new System.Drawing.Point(0, 573);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1370, 176);
            this.panel1.TabIndex = 12;
            // 
            // button_clean
            // 
            this.button_clean.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_clean.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_clean.Location = new System.Drawing.Point(1149, 34);
            this.button_clean.Name = "button_clean";
            this.button_clean.Size = new System.Drawing.Size(188, 47);
            this.button_clean.TabIndex = 24;
            this.button_clean.Text = "Clean";
            this.button_clean.UseVisualStyleBackColor = true;
            this.button_clean.Click += new System.EventHandler(this.button_clean_Click);
            // 
            // tb_y3
            // 
            this.tb_y3.Location = new System.Drawing.Point(142, 145);
            this.tb_y3.Name = "tb_y3";
            this.tb_y3.Size = new System.Drawing.Size(47, 26);
            this.tb_y3.TabIndex = 23;
            // 
            // label_y3
            // 
            this.label_y3.AutoSize = true;
            this.label_y3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_y3.Location = new System.Drawing.Point(195, 148);
            this.label_y3.Name = "label_y3";
            this.label_y3.Size = new System.Drawing.Size(29, 20);
            this.label_y3.TabIndex = 22;
            this.label_y3.Text = "Y3";
            // 
            // label_x3
            // 
            this.label_x3.AutoSize = true;
            this.label_x3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_x3.Location = new System.Drawing.Point(70, 148);
            this.label_x3.Name = "label_x3";
            this.label_x3.Size = new System.Drawing.Size(29, 20);
            this.label_x3.TabIndex = 21;
            this.label_x3.Text = "X3";
            // 
            // tb_x3
            // 
            this.tb_x3.Location = new System.Drawing.Point(14, 145);
            this.tb_x3.Name = "tb_x3";
            this.tb_x3.Size = new System.Drawing.Size(50, 26);
            this.tb_x3.TabIndex = 20;
            // 
            // rtb_info
            // 
            this.rtb_info.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rtb_info.Location = new System.Drawing.Point(278, 34);
            this.rtb_info.Name = "rtb_info";
            this.rtb_info.Size = new System.Drawing.Size(841, 137);
            this.rtb_info.TabIndex = 19;
            this.rtb_info.Text = "Just choose two points :) A line will appear between their.";
            // 
            // label_instr
            // 
            this.label_instr.AutoSize = true;
            this.label_instr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_instr.Location = new System.Drawing.Point(274, 7);
            this.label_instr.Name = "label_instr";
            this.label_instr.Size = new System.Drawing.Size(96, 20);
            this.label_instr.TabIndex = 17;
            this.label_instr.Text = "Instructions:";
            // 
            // label_choice
            // 
            this.label_choice.AutoSize = true;
            this.label_choice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_choice.Location = new System.Drawing.Point(10, 7);
            this.label_choice.Name = "label_choice";
            this.label_choice.Size = new System.Drawing.Size(153, 20);
            this.label_choice.TabIndex = 16;
            this.label_choice.Text = "Choose figure\'s type";
            // 
            // FormDrawing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.picture);
            this.Name = "FormDrawing";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
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
        private System.Windows.Forms.Label label_instr;
        private System.Windows.Forms.RichTextBox rtb_info;
        private System.Windows.Forms.TextBox tb_y3;
        private System.Windows.Forms.Label label_y3;
        private System.Windows.Forms.Label label_x3;
        private System.Windows.Forms.TextBox tb_x3;
        private System.Windows.Forms.Button button_clean;
    }
}

