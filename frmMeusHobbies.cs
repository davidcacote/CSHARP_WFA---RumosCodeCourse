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
    public partial class frmMeusHobbies : Form
    {
        public frmMeusHobbies()
        {
            InitializeComponent();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            foreach (var item in checkedListBox1.CheckedItems)
            {
                global.hobbies.Add(item);
            }

            frmMeusHobbiesLista lista = new frmMeusHobbiesLista();
            lista.Show();
        }
    }
}
