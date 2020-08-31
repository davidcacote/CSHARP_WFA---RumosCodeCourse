using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinApp
{
    public partial class frmQueHorasSao : Form
    {
        public frmQueHorasSao()
        {
            InitializeComponent();
        }

        private void frmQueHorasSao_Load(object sender, EventArgs e)
        {
            Automático();
        }


        private void rbtn2_Click(object sender, MouseEventArgs e)
        {
            Manual();
        }

        private void rbtn1_Click(object sender, MouseEventArgs e)
        {
            Automático();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            ApresentacaoData();
        }

        private void Manual()
        {
            timer1.Stop();
            btn.Enabled = true;
            rbtn1.Checked = false;
            rbtn2.Checked = true;
        }

        private void Automático()
        {
            btn.Enabled = false;
            rbtn1.Checked = true;
            rbtn2.Checked = false;
            timer1.Start();
        }

        private void ApresentacaoData()
        {
            var hora = DateTime.Now.Hour;
            var minuto = DateTime.Now.Minute;
            var segundo = DateTime.Now.Second;

            bar1.Value = hora;
            bar2.Value = minuto;
            bar3.Value = segundo;

            lbl1.Text = hora.ToString() + " horas";
            lbl2.Text = minuto.ToString() + " minutos";
            lbl3.Text = segundo.ToString() + " segundos";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
            ApresentacaoData();
        }
    }

}
