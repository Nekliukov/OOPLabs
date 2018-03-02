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
            ((System.ComponentModel.ISupportInitialize)(this.picture)).BeginInit();
            this.SuspendLayout();
            // 
            // picture
            // 
            this.picture.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.picture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picture.Location = new System.Drawing.Point(0, 0);
            this.picture.Name = "picture";
            this.picture.Size = new System.Drawing.Size(677, 449);
            this.picture.TabIndex = 0;
            this.picture.TabStop = false;
            // 
            // button_draw
            // 
            this.button_draw.Location = new System.Drawing.Point(477, 390);
            this.button_draw.Name = "button_draw";
            this.button_draw.Size = new System.Drawing.Size(188, 47);
            this.button_draw.TabIndex = 1;
            this.button_draw.Text = "Draw!";
            this.button_draw.UseVisualStyleBackColor = true;
            this.button_draw.Click += new System.EventHandler(this.button_draw_Click);
            // 
            // FormDrawing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 449);
            this.Controls.Add(this.button_draw);
            this.Controls.Add(this.picture);
            this.Name = "FormDrawing";
            this.Text = "Drawing";
            ((System.ComponentModel.ISupportInitialize)(this.picture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picture;
        private System.Windows.Forms.Button button_draw;
    }
}

