using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinApp.Properties;

namespace WinApp
{
    public partial class frmCambioCheckedBox : Form
    {
        public frmCambioCheckedBox()
        {
            InitializeComponent();
            lbl_resultado.Visible = false;
        }
        double calculo = 0.0;

        private void btn_Click(object sender, EventArgs e)
        {
            lbl_resultado.Text = "";
            if (textBox1.Text.Length == 0)
            {
                MessageBox.Show("Terá de introduzir um valor a calcular");
            }



            if (selected1.Checked is true)
            {
                lbl_resultado.Visible = true;
                lbl_resultado.Text += Convert.ToString(CalculoDollar()) + " dollar";
            }

            if (selected2.Checked is true)
            {
                lbl_resultado.Visible = true;
                lbl_resultado.Text += "\n" + Convert.ToString(CalculoLibra()) + " libra";
            }

            if (selected3.Checked is true)
            {
                lbl_resultado.Visible = true;
                lbl_resultado.Text += "\n" + Convert.ToString(CalculoIene()) + " iene";
            }

            else if (selected4.Checked is true)
            {
                lbl_resultado.Visible = true;
                lbl_resultado.Text += "\n" + Convert.ToString(CalculoSek()) + " sek";
            }
        }

        private double CalculoDollar()
        {
            var dollar = Settings.Default.Dollar;

            calculo = Math.Round(Convert.ToDouble(textBox1.Text) * dollar, 2);
            return calculo;
        }
        private double CalculoLibra()
        {
            var libra = Settings.Default.Libra;

            calculo = Math.Round(Convert.ToDouble(textBox1.Text) * libra, 2);
            return calculo;
        }
        private double CalculoIene()
        {
            var iene = Settings.Default.Iene;

            calculo = Math.Round(Convert.ToDouble(textBox1.Text) * iene, 2);
            return calculo;
        }
        private double CalculoSek()
        {
            var sek = Settings.Default.Sek;

            calculo = Math.Round(Convert.ToDouble(textBox1.Text) * sek, 2);
            return calculo;
        }
    }
}
