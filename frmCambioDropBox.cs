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
    public partial class frmCambioDropBox : Form
    {
        double calculo = 0.0;

        public frmCambioDropBox()
        {
            InitializeComponent();
            lbl_resultado.Visible = false;
        }

        private void btn_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 0)
            {
                MessageBox.Show("Terá de introduzir um valor a calcular");
            }


            else if (box.Text is "Dollar")
            {
                lbl_resultado.Visible = true;
                lbl_resultado.Text = Convert.ToString(CalculoDollar());
            }
            else if (box.Text is "Libra")
            {
                lbl_resultado.Visible = true;
                lbl_resultado.Text = Convert.ToString(CalculoLibra());
            }
            else if (box.Text is "Iene")
            {
                lbl_resultado.Visible = true;
                lbl_resultado.Text = Convert.ToString(CalculoIene());
            }
            else if (box.Text is "Sek")
            {
                lbl_resultado.Visible = true;
                lbl_resultado.Text = Convert.ToString(CalculoSek());
            }
            else
            {
                MessageBox.Show("Terá de selecionar uma das moedas para converter.");
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
