using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinApp
{
    public partial class frmQuantoTempoPassou : Form
    {
        public frmQuantoTempoPassou()
        {
            InitializeComponent();
            calendar1.MaxDate = DateTime.Now;
            calendar2.MinDate = DateTime.Now.AddDays(1);
        }

        private void calendar2_DateChanged(object sender, DateRangeEventArgs e)
        {
            CalculoDiferencaData();
        }

        private void calendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            CalculoDiferencaData();
        }

        private void CalculoDiferencaData()
        {
            var data1 = calendar1.SelectionEnd;
            var data2 = calendar2.SelectionStart;
            var dias = (data2 - data1).Days;
            var anos = dias / 365;
            var meses =(((dias - (anos * 365)) / 30));


            label1.Text = Convert.ToString(dias) + " dias \n"
                + Convert.ToString(meses) + " meses\n"
                + Convert.ToString(anos) + " anos";

            label1.Visible = true;
        }
    }
}
