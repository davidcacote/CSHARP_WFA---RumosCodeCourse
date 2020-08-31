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
    public partial class frmMeusHobbiesLista : Form
    {
        public frmMeusHobbiesLista()
        {
            InitializeComponent();
        }

        private void frmMeusHobbiesLista_Load(object sender, EventArgs e)
        {
            foreach (var item in global.hobbies)
            {
                lista_final.Items.Add(item);
            }
        }

        private void btn_Click(object sender, EventArgs e)
        {
            frmMeusHobbiesLista.ActiveForm.Close();
        }
    }
}
