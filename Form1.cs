using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Foreach_em_CSharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            //for each

            List<string> lista_nomes = new List<string>()
            {
                "leo", "jose", "alex", "maria", "joao", "marcia"
            };

            foreach (string ls in lista_nomes) // para cada string que estás contida em lista_nomes vai ser "jogado dentro" de ls
            {
                ListBox.Items.Add(ls);
            }

            //string frase = "Meu curso de C#.";
            //ListBox.Items.Add(frase.Lenght); //comprimento

            //foreach (char f in frase) // f é o apelido que dei para cada caracter da variável frase
            //{
            //    ListBox.Items.Add(f);   
            //}
        }
    }
}
