namespace WinApp
{
    partial class frmFicheiros
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txtbox = new System.Windows.Forms.RichTextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtbox2 = new System.Windows.Forms.RichTextBox();
            this.btn = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.txtbox3 = new System.Windows.Forms.RichTextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.ImeMode = System.Windows.Forms.ImeMode.On;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(796, 383);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.Click += new System.EventHandler(this.tabControl1_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txtbox);
            this.tabPage1.Location = new System.Drawing.Point(4, 28);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(788, 351);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Escrita em Ficheiro";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // txtbox
            // 
            this.txtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox.Location = new System.Drawing.Point(1, -1);
            this.txtbox.Name = "txtbox";
            this.txtbox.Size = new System.Drawing.Size(787, 355);
            this.txtbox.TabIndex = 0;
            this.txtbox.Text = "Escreva aqui o que deseja guardar";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txtbox2);
            this.tabPage2.Location = new System.Drawing.Point(4, 28);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(788, 351);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Escrita em Ficheiro - Append";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txtbox2
            // 
            this.txtbox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox2.Location = new System.Drawing.Point(1, -2);
            this.txtbox2.Name = "txtbox2";
            this.txtbox2.Size = new System.Drawing.Size(787, 353);
            this.txtbox2.TabIndex = 1;
            this.txtbox2.Text = "Escreva o que anexar a um ficheiro existente";
            // 
            // btn
            // 
            this.btn.Location = new System.Drawing.Point(672, 389);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(120, 32);
            this.btn.TabIndex = 1;
            this.btn.Text = "Guardar";
            this.btn.UseVisualStyleBackColor = true;
            this.btn.Click += new System.EventHandler(this.btn_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.txtbox3);
            this.tabPage3.Location = new System.Drawing.Point(4, 28);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(788, 351);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Leitura de Ficheiros";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // txtbox3
            // 
            this.txtbox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox3.Location = new System.Drawing.Point(0, 0);
            this.txtbox3.Name = "txtbox3";
            this.txtbox3.Size = new System.Drawing.Size(788, 351);
            this.txtbox3.TabIndex = 0;
            this.txtbox3.Text = "";
            // 
            // frmFicheiros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 431);
            this.Controls.Add(this.btn);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmFicheiros";
            this.ShowIcon = false;
            this.Text = "Ficheiros";
            this.Load += new System.EventHandler(this.frmFicheiros_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.RichTextBox txtbox;
        private System.Windows.Forms.RichTextBox txtbox2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.RichTextBox txtbox3;
    }
}