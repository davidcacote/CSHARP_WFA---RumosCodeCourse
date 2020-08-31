using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinApp.Properties;

namespace WinApp
{
    public partial class frmNotaFinal : Form
    {
        double notafinal;

        public frmNotaFinal()
        {
            InitializeComponent();
            this.Height = 210;
            lbl_final.Visible = false;
            btn2.Visible = false;
        }



        private void btn_Click(object sender, EventArgs e)
        {
            try
            {
                this.Height = 250;
                lbl_final.Visible = true;
                btn2.Visible = true;
                CalculoNotafinal(Settings.Default.peso1, Settings.Default.peso2, Settings.Default.peso3);
                lbl_final.Text = String.Format("A nota final é de \n {0} valores", Convert.ToString(notafinal));
            }
            catch (Exception)
            {
                MessageBox.Show("Deverá introduzir valores a todos os campos para validar");
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txt_teste1.Clear();
            txt_teste2.Clear();
            txt_trab1.Clear();
            txt_trab2.Clear();
            txt_trabfinal.Clear();
            lbl_final.Visible = false;
            btn2.Visible = false;
            this.Height = 210;

        }

        private double CalculoNotafinal(double peso1, double peso2, double peso3)
        {
            notafinal = peso1 * (Double.Parse(txt_teste1.Text) + Double.Parse(txt_teste2.Text)) / 2 
                + peso2 * (Double.Parse(txt_trab1.Text) + Double.Parse(txt_trab2.Text))/2 
                + peso3 * Double.Parse(txt_trabfinal.Text);
            return notafinal;
        }
    }
}
