﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using POO;

namespace WinApp.ExercíciosPOO
{
    public partial class frmInserirEmpregadoV1 : Form
    {
        private Empregado empregado;
        private string nome, departamento;
        private DateTime datanascimento;
        private decimal salario;

        public frmInserirEmpregadoV1()
        {
            InitializeComponent();
            Clean();     
        }

        private void btn_inserir_Click(object sender, EventArgs e)
        {
            nome = txt_box1.Text;
            datanascimento = date_picker.Value;
            departamento = txt_box2.Text;
            salario = Convert.ToDecimal(txt_box3.Text);

            empregado = new Empregado(nome, datanascimento, departamento, salario);

            Messbox();
            Clean();
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            var lista = POO.Empregado.ImprimetodosDados();
            richTextBox1.Text = lista;
        }

        private void Clean()
        {
            txt_box1.Text = "";
            txt_box2.Text = "";
            txt_box3.Text = "";
            date_picker.Value = DateAndTime.DateValue("February 24, 1987");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var lista = POO.Empregado.ImprimeDados();
            richTextBox1.Text = lista;
        }

        private void Messbox()
        {
            MessageBox.Show("Empregado introduzido com sucesso","",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
    }

}
