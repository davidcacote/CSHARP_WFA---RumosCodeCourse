namespace WinApp
{
    partial class frmNomeEmail
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
            this.lbl1 = new System.Windows.Forms.Label();
            this.txtbox1 = new System.Windows.Forms.TextBox();
            this.btn1_see = new System.Windows.Forms.Button();
            this.lbl2 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_nome = new System.Windows.Forms.Label();
            this.lbl_email1 = new System.Windows.Forms.Label();
            this.lbl_email2 = new System.Windows.Forms.Label();
            this.btn_clean = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(23, 23);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(108, 17);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "Nome Completo";
            // 
            // txtbox1
            // 
            this.txtbox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox1.Location = new System.Drawing.Point(149, 19);
            this.txtbox1.Name = "txtbox1";
            this.txtbox1.Size = new System.Drawing.Size(337, 24);
            this.txtbox1.TabIndex = 1;
            // 
            // btn1_see
            // 
            this.btn1_see.Location = new System.Drawing.Point(503, 19);
            this.btn1_see.Name = "btn1_see";
            this.btn1_see.Size = new System.Drawing.Size(75, 24);
            this.btn1_see.TabIndex = 2;
            this.btn1_see.Text = "Ver";
            this.btn1_see.UseVisualStyleBackColor = true;
            this.btn1_see.Click += new System.EventHandler(this.btn1_see_Click);
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(82, 65);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(49, 17);
            this.lbl2.TabIndex = 3;
            this.lbl2.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(73, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Email 1:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(73, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Email 2:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_nome
            // 
            this.lbl_nome.AutoSize = true;
            this.lbl_nome.Location = new System.Drawing.Point(146, 65);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(40, 17);
            this.lbl_nome.TabIndex = 6;
            this.lbl_nome.Text = "____";
            this.lbl_nome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_nome.Visible = false;
            // 
            // lbl_email1
            // 
            this.lbl_email1.AutoSize = true;
            this.lbl_email1.Location = new System.Drawing.Point(146, 97);
            this.lbl_email1.Name = "lbl_email1";
            this.lbl_email1.Size = new System.Drawing.Size(40, 17);
            this.lbl_email1.TabIndex = 7;
            this.lbl_email1.Text = "____";
            this.lbl_email1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_email1.Visible = false;
            // 
            // lbl_email2
            // 
            this.lbl_email2.AutoSize = true;
            this.lbl_email2.Location = new System.Drawing.Point(146, 129);
            this.lbl_email2.Name = "lbl_email2";
            this.lbl_email2.Size = new System.Drawing.Size(40, 17);
            this.lbl_email2.TabIndex = 8;
            this.lbl_email2.Text = "____";
            this.lbl_email2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_email2.Visible = false;
            // 
            // btn_clean
            // 
            this.btn_clean.Location = new System.Drawing.Point(503, 122);
            this.btn_clean.Name = "btn_clean";
            this.btn_clean.Size = new System.Drawing.Size(75, 24);
            this.btn_clean.TabIndex = 9;
            this.btn_clean.Text = "Limpar";
            this.btn_clean.UseVisualStyleBackColor = true;
            this.btn_clean.Click += new System.EventHandler(this.btn_clean_Click);
            // 
            // frmNomeEmail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 174);
            this.Controls.Add(this.btn_clean);
            this.Controls.Add(this.lbl_email2);
            this.Controls.Add(this.lbl_email1);
            this.Controls.Add(this.lbl_nome);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.btn1_see);
            this.Controls.Add(this.txtbox1);
            this.Controls.Add(this.lbl1);
            this.Name = "frmNomeEmail";
            this.ShowIcon = false;
            this.Text = "Nome e Email";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.TextBox txtbox1;
        private System.Windows.Forms.Button btn1_see;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_nome;
        private System.Windows.Forms.Label lbl_email1;
        private System.Windows.Forms.Label lbl_email2;
        private System.Windows.Forms.Button btn_clean;
    }
}