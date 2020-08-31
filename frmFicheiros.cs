using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinApp
{
    public partial class frmFicheiros : Form
    {
        public frmFicheiros()
        {
            InitializeComponent();
        }

        private void frmFicheiros_Load(object sender, EventArgs e)
        {
        }

        private void btn_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == tabControl1.TabPages["tabPage1"])
            {
                GuardarFicheiro();
            }

            else if (tabControl1.SelectedTab == tabControl1.TabPages["tabPage2"])
            {
                AdicionarConteudoFicheiro();
            }

            else if (tabControl1.SelectedTab == tabControl1.TabPages["tabPage3"])
            {
                AbrirFicheiro();
            }
            
        }

        void GuardarFicheiro()
        {
            SaveFileDialog gravaFicheiro = new SaveFileDialog();
            gravaFicheiro.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            gravaFicheiro.Title = "Guardar escrita";
            StreamWriter myStreamWriter = null;

            try
            {
                if (gravaFicheiro.ShowDialog() == DialogResult.OK)
                {
                    myStreamWriter = new StreamWriter(gravaFicheiro.FileName, false);
                    myStreamWriter.Write(txtbox.Text);
                    myStreamWriter.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (myStreamWriter != null) myStreamWriter.Close();
                {

                }
            }
        }

        void AbrirFicheiro()
        {
            StreamReader myStreamReader = null;
            OpenFileDialog abreFicheiro = new OpenFileDialog();
            abreFicheiro.Title = "Abrir conteúdo";

            try
            {
                abreFicheiro.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
                abreFicheiro.InitialDirectory = @"c:\";
                abreFicheiro.ShowDialog();

                myStreamReader = new StreamReader(abreFicheiro.FileName);
                txtbox3.Text = myStreamReader.ReadToEnd();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (myStreamReader != null) myStreamReader.Close();
                {

                }
            }
        }

        void AdicionarConteudoFicheiro()
        {
            SaveFileDialog gravaFicheiro = new SaveFileDialog();
            gravaFicheiro.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            gravaFicheiro.Title = "Adicionar conteúdo";
            StreamWriter myStreamWriter = null;

            try
            {
                if (gravaFicheiro.ShowDialog() == DialogResult.OK)
                {
                    myStreamWriter = new StreamWriter(gravaFicheiro.FileName,true);
                    myStreamWriter.WriteLine(txtbox2.Text);
                    myStreamWriter.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (myStreamWriter != null) myStreamWriter.Close();
                {

                }
            }
        }

        private void tabControl1_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == tabControl1.TabPages["tabPage1"])
            {
                btn.Text = "Guardar";
            }

            else if (tabControl1.SelectedTab == tabControl1.TabPages["tabPage2"])
            {
                btn.Text = "Guardar";
            }

            else if (tabControl1.SelectedTab == tabControl1.TabPages["tabPage3"])
            {
                btn.Text = "Abrir";
            }
        }
    }
}
