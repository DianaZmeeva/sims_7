namespace sims_7_dice
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.second = new System.Windows.Forms.Label();
            this.win = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.first = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.second);
            this.panel1.Controls.Add(this.win);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.first);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(284, 261);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label2.Location = new System.Drawing.Point(202, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(74, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "0";
            // 
            // second
            // 
            this.second.BackColor = System.Drawing.SystemColors.Control;
            this.second.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.second.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.second.Location = new System.Drawing.Point(173, 73);
            this.second.Name = "second";
            this.second.Size = new System.Drawing.Size(75, 60);
            this.second.TabIndex = 9;
            this.second.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // win
            // 
            this.win.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.win.ForeColor = System.Drawing.Color.Red;
            this.win.Location = new System.Drawing.Point(12, 189);
            this.win.Name = "win";
            this.win.Size = new System.Drawing.Size(260, 31);
            this.win.TabIndex = 7;
            this.win.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.win.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(79, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 31);
            this.label4.TabIndex = 6;
            this.label4.Text = "Roll dices";
            // 
            // first
            // 
            this.first.BackColor = System.Drawing.SystemColors.Control;
            this.first.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.first.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.first.Location = new System.Drawing.Point(47, 73);
            this.first.Name = "first";
            this.first.Size = new System.Drawing.Size(75, 60);
            this.first.TabIndex = 2;
            this.first.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(78, 146);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 28);
            this.button1.TabIndex = 0;
            this.button1.Text = "Roll";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label second;
        private System.Windows.Forms.Label win;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label first;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

