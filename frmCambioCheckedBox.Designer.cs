namespace WinApp
{
    partial class frmCambioCheckedBox
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
            this.lbl_resultado = new System.Windows.Forms.Label();
            this.Moeda = new System.Windows.Forms.GroupBox();
            this.selected4 = new System.Windows.Forms.CheckBox();
            this.selected3 = new System.Windows.Forms.CheckBox();
            this.selected2 = new System.Windows.Forms.CheckBox();
            this.selected1 = new System.Windows.Forms.CheckBox();
            this.btn = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Moeda.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_resultado
            // 
            this.lbl_resultado.AutoSize = true;
            this.lbl_resultado.Location = new System.Drawing.Point(35, 126);
            this.lbl_resultado.Name = "lbl_resultado";
            this.lbl_resultado.Size = new System.Drawing.Size(34, 17);
            this.lbl_resultado.TabIndex = 15;
            this.lbl_resultado.Text = "final";
            this.lbl_resultado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Moeda
            // 
            this.Moeda.Controls.Add(this.selected4);
            this.Moeda.Controls.Add(this.selected3);
            this.Moeda.Controls.Add(this.selected2);
            this.Moeda.Controls.Add(this.selected1);
            this.Moeda.Location = new System.Drawing.Point(141, 21);
            this.Moeda.Name = "Moeda";
            this.Moeda.Size = new System.Drawing.Size(110, 137);
            this.Moeda.TabIndex = 14;
            this.Moeda.TabStop = false;
            this.Moeda.Text = "Moeda";
            // 
            // selected4
            // 
            this.selected4.AutoSize = true;
            this.selected4.Location = new System.Drawing.Point(10, 105);
            this.selected4.Name = "selected4";
            this.selected4.Size = new System.Drawing.Size(54, 21);
            this.selected4.TabIndex = 3;
            this.selected4.Text = "Sek";
            this.selected4.UseVisualStyleBackColor = true;
            // 
            // selected3
            // 
            this.selected3.AutoSize = true;
            this.selected3.Location = new System.Drawing.Point(10, 78);
            this.selected3.Name = "selected3";
            this.selected3.Size = new System.Drawing.Size(57, 21);
            this.selected3.TabIndex = 2;
            this.selected3.Text = "Iene";
            this.selected3.UseVisualStyleBackColor = true;
            // 
            // selected2
            // 
            this.selected2.AutoSize = true;
            this.selected2.Location = new System.Drawing.Point(10, 51);
            this.selected2.Name = "selected2";
            this.selected2.Size = new System.Drawing.Size(62, 21);
            this.selected2.TabIndex = 1;
            this.selected2.Text = "Libra";
            this.selected2.UseVisualStyleBackColor = true;
            // 
            // selected1
            // 
            this.selected1.AutoSize = true;
            this.selected1.Location = new System.Drawing.Point(10, 24);
            this.selected1.Name = "selected1";
            this.selected1.Size = new System.Drawing.Size(67, 21);
            this.selected1.TabIndex = 0;
            this.selected1.Text = "Dollar";
            this.selected1.UseVisualStyleBackColor = true;
            // 
            // btn
            // 
            this.btn.Location = new System.Drawing.Point(23, 84);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(100, 23);
            this.btn.TabIndex = 13;
            this.btn.Text = "Converter";
            this.btn.UseVisualStyleBackColor = true;
            this.btn.Click += new System.EventHandler(this.btn_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(23, 50);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 12;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Valor em €";
            // 
            // frmCambioCheckedBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(266, 196);
            this.Controls.Add(this.lbl_resultado);
            this.Controls.Add(this.Moeda);
            this.Controls.Add(this.btn);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "frmCambioCheckedBox";
            this.ShowIcon = false;
            this.Text = "Cambio";
            this.Moeda.ResumeLayout(false);
            this.Moeda.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_resultado;
        private System.Windows.Forms.GroupBox Moeda;
        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox selected1;
        private System.Windows.Forms.CheckBox selected4;
        private System.Windows.Forms.CheckBox selected3;
        private System.Windows.Forms.CheckBox selected2;
    }
}