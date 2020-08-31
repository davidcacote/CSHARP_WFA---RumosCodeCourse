namespace WinApp
{
    partial class frmQueHorasSao
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.bar1 = new System.Windows.Forms.ProgressBar();
            this.bar2 = new System.Windows.Forms.ProgressBar();
            this.bar3 = new System.Windows.Forms.ProgressBar();
            this.rbtn1 = new System.Windows.Forms.RadioButton();
            this.rbtn2 = new System.Windows.Forms.RadioButton();
            this.btn = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(583, 62);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(46, 17);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "label1";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(583, 127);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(46, 17);
            this.lbl2.TabIndex = 1;
            this.lbl2.Text = "label2";
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Location = new System.Drawing.Point(583, 196);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(46, 17);
            this.lbl3.TabIndex = 2;
            this.lbl3.Text = "label3";
            // 
            // bar1
            // 
            this.bar1.Location = new System.Drawing.Point(39, 47);
            this.bar1.Maximum = 23;
            this.bar1.Name = "bar1";
            this.bar1.Size = new System.Drawing.Size(250, 45);
            this.bar1.TabIndex = 3;
            // 
            // bar2
            // 
            this.bar2.Location = new System.Drawing.Point(39, 115);
            this.bar2.Maximum = 59;
            this.bar2.Name = "bar2";
            this.bar2.Size = new System.Drawing.Size(524, 45);
            this.bar2.TabIndex = 4;
            // 
            // bar3
            // 
            this.bar3.Location = new System.Drawing.Point(39, 183);
            this.bar3.Maximum = 59;
            this.bar3.Name = "bar3";
            this.bar3.Size = new System.Drawing.Size(524, 45);
            this.bar3.TabIndex = 5;
            // 
            // rbtn1
            // 
            this.rbtn1.AutoSize = true;
            this.rbtn1.Location = new System.Drawing.Point(39, 247);
            this.rbtn1.Name = "rbtn1";
            this.rbtn1.Size = new System.Drawing.Size(99, 21);
            this.rbtn1.TabIndex = 6;
            this.rbtn1.TabStop = true;
            this.rbtn1.Text = "Automático";
            this.rbtn1.UseVisualStyleBackColor = true;
            this.rbtn1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.rbtn1_Click);
            // 
            // rbtn2
            // 
            this.rbtn2.AutoSize = true;
            this.rbtn2.Location = new System.Drawing.Point(39, 274);
            this.rbtn2.Name = "rbtn2";
            this.rbtn2.Size = new System.Drawing.Size(75, 21);
            this.rbtn2.TabIndex = 7;
            this.rbtn2.TabStop = true;
            this.rbtn2.Text = "Manual";
            this.rbtn2.UseVisualStyleBackColor = true;
            this.rbtn2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.rbtn2_Click);
            // 
            // btn
            // 
            this.btn.Location = new System.Drawing.Point(445, 254);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(118, 37);
            this.btn.TabIndex = 8;
            this.btn.Text = "Actualizar";
            this.btn.UseVisualStyleBackColor = true;
            this.btn.Click += new System.EventHandler(this.btn_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmQueHorasSao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 314);
            this.Controls.Add(this.btn);
            this.Controls.Add(this.rbtn2);
            this.Controls.Add(this.rbtn1);
            this.Controls.Add(this.bar3);
            this.Controls.Add(this.bar2);
            this.Controls.Add(this.bar1);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl1);
            this.Name = "frmQueHorasSao";
            this.ShowIcon = false;
            this.Text = "Que Horas Sao?";
            this.Load += new System.EventHandler(this.frmQueHorasSao_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.ProgressBar bar1;
        private System.Windows.Forms.ProgressBar bar2;
        private System.Windows.Forms.ProgressBar bar3;
        private System.Windows.Forms.RadioButton rbtn1;
        private System.Windows.Forms.RadioButton rbtn2;
        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.Timer timer1;
    }
}