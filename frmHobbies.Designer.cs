namespace WinApp
{
    partial class frmHobbies
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
            this.btn2 = new System.Windows.Forms.Button();
            this.lstbox = new System.Windows.Forms.ListBox();
            this.btn1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn2
            // 
            this.btn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn2.Location = new System.Drawing.Point(12, 49);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(201, 31);
            this.btn2.TabIndex = 1;
            this.btn2.Text = "Ver Sumário";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // lstbox
            // 
            this.lstbox.FormattingEnabled = true;
            this.lstbox.ItemHeight = 16;
            this.lstbox.Location = new System.Drawing.Point(12, 86);
            this.lstbox.Name = "lstbox";
            this.lstbox.Size = new System.Drawing.Size(201, 244);
            this.lstbox.TabIndex = 3;
            // 
            // btn1
            // 
            this.btn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn1.Location = new System.Drawing.Point(12, 12);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(201, 31);
            this.btn1.TabIndex = 0;
            this.btn1.Text = "Carrega Hobbies";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // frmHobbies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(224, 352);
            this.Controls.Add(this.lstbox);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Name = "frmHobbies";
            this.ShowIcon = false;
            this.Text = "Hobbies";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.ListBox lstbox;
        private System.Windows.Forms.Button btn1;
    }
}