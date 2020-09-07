namespace WinApp.ExercíciosPOO
{
    partial class frmInserirEmpregadoV1
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
            this.btn_inserir = new System.Windows.Forms.Button();
            this.txt_box1 = new System.Windows.Forms.TextBox();
            this.lbl1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_box2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_box3 = new System.Windows.Forms.TextBox();
            this.date_picker = new System.Windows.Forms.DateTimePicker();
            this.btn2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_inserir
            // 
            this.btn_inserir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_inserir.Location = new System.Drawing.Point(162, 205);
            this.btn_inserir.Name = "btn_inserir";
            this.btn_inserir.Size = new System.Drawing.Size(173, 32);
            this.btn_inserir.TabIndex = 0;
            this.btn_inserir.Text = "Inserir Empregado";
            this.btn_inserir.UseVisualStyleBackColor = true;
            this.btn_inserir.Click += new System.EventHandler(this.btn_inserir_Click);
            // 
            // txt_box1
            // 
            this.txt_box1.Location = new System.Drawing.Point(143, 25);
            this.txt_box1.Name = "txt_box1";
            this.txt_box1.Size = new System.Drawing.Size(331, 22);
            this.txt_box1.TabIndex = 1;
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(28, 26);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(45, 17);
            this.lbl1.TabIndex = 2;
            this.lbl1.Text = "Nome";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Data de Nascimento";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Departamento";
            // 
            // txt_box2
            // 
            this.txt_box2.Location = new System.Drawing.Point(199, 113);
            this.txt_box2.Name = "txt_box2";
            this.txt_box2.Size = new System.Drawing.Size(275, 22);
            this.txt_box2.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Salario";
            // 
            // txt_box3
            // 
            this.txt_box3.Location = new System.Drawing.Point(199, 157);
            this.txt_box3.Name = "txt_box3";
            this.txt_box3.Size = new System.Drawing.Size(275, 22);
            this.txt_box3.TabIndex = 7;
            // 
            // date_picker
            // 
            this.date_picker.CustomFormat = "dd/mm/yyyy";
            this.date_picker.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.date_picker.Location = new System.Drawing.Point(222, 69);
            this.date_picker.MaxDate = new System.DateTime(2002, 1, 1, 0, 0, 0, 0);
            this.date_picker.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.date_picker.Name = "date_picker";
            this.date_picker.Size = new System.Drawing.Size(252, 22);
            this.date_picker.TabIndex = 11;
            this.date_picker.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            // 
            // btn2
            // 
            this.btn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn2.Location = new System.Drawing.Point(14, 214);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(169, 32);
            this.btn2.TabIndex = 13;
            this.btn2.Text = "Total Info Empregados";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(521, 214);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(159, 32);
            this.button1.TabIndex = 15;
            this.button1.Text = "Só Nome e Salario";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(694, 282);
            this.tabControl1.TabIndex = 16;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txt_box1);
            this.tabPage1.Controls.Add(this.btn_inserir);
            this.tabPage1.Controls.Add(this.lbl1);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.date_picker);
            this.tabPage1.Controls.Add(this.txt_box2);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.txt_box3);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(686, 253);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Inserir Empregado";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.richTextBox1);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.btn2);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(686, 253);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Verificar Banco de Dados";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(3, 6);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(677, 192);
            this.richTextBox1.TabIndex = 16;
            this.richTextBox1.Text = "";
            // 
            // frmInserirEmpregadoV1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 307);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmInserirEmpregadoV1";
            this.ShowIcon = false;
            this.Text = "Listagem Empregados app";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_inserir;
        private System.Windows.Forms.TextBox txt_box1;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_box2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_box3;
        private System.Windows.Forms.DateTimePicker date_picker;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}