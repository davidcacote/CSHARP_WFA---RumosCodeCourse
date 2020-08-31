namespace WinApp
{
    partial class frmMeusHobbiesLista
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
            this.btn = new System.Windows.Forms.Button();
            this.lista_final = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btn
            // 
            this.btn.Location = new System.Drawing.Point(12, 166);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(148, 23);
            this.btn.TabIndex = 0;
            this.btn.Text = "Confirmar e Sair";
            this.btn.UseVisualStyleBackColor = true;
            this.btn.Click += new System.EventHandler(this.btn_Click);
            // 
            // lista_final
            // 
            this.lista_final.FormattingEnabled = true;
            this.lista_final.ItemHeight = 16;
            this.lista_final.Location = new System.Drawing.Point(12, 12);
            this.lista_final.Name = "lista_final";
            this.lista_final.Size = new System.Drawing.Size(148, 148);
            this.lista_final.TabIndex = 1;
            // 
            // frmMeusHobbiesLista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(173, 201);
            this.ControlBox = false;
            this.Controls.Add(this.lista_final);
            this.Controls.Add(this.btn);
            this.Name = "frmMeusHobbiesLista";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "frmMeusHobbiesLista";
            this.Load += new System.EventHandler(this.frmMeusHobbiesLista_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.ListBox lista_final;
    }
}