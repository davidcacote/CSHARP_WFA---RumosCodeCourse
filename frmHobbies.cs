using System;
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

namespace WinApp
{
    public partial class frmHobbies : Form
    {
        private ArrayList Hobbies;
        private Dictionary<string, int> ContagemHobbies;
        public string message = "Introduza hobbies do seu gosto. \nPara fechar a janela escreva *"; //criação da mensagem da caixa input;
        public string title = "Hobbies"; //titulo da caixa inputbox;
        public string defaultValue = "apanhar sol"; //default value na linha texto;

        public frmHobbies()
        {
            InitializeComponent();
            Hobbies = new ArrayList();
            ContagemHobbies = new Dictionary<string, int>();
        }
        private void btn1_Click(object sender, EventArgs e)
        {  
            AdicionarHobbies(InputHobbies());
        }

        public string InputHobbies()
        {
            string myValue;
            do
            {
                myValue = Interaction.InputBox(message, title, defaultValue);
                return myValue;
            } while (!myValue.Equals("*"));

            
        }

        public void AdicionarHobbies(string hobbie)
        {
                Hobbies.Add(hobbie);                      
        }


        /// <summary>
        /// Verificação de hobbies após input, se já existe o mesmo é soma o contador, senão é adicionado o hobbie à lista.
        /// </summary>
        public void verificarHobbies()
        {
            foreach (string hobby in Hobbies)
            {
                //LINQ to object
                if (!ContagemHobbies.ContainsKey(hobby))
                {
                    var query = from string aux in hobby
                                where aux.Equals(hobby)
                                select aux;

                    int count = 0;

                    foreach (var c in query)
                    {
                        count ++ ;
                    }

                    ContagemHobbies.Add(hobby, count);
                }

            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            verificarHobbies();

            foreach (var item in ContagemHobbies)
            {
                lstbox.Items.Add(item.Key + " " + item.Value);
            }
        }
    }
}
