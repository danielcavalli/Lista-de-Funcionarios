using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListaTrab
{
    public partial class Form1 : Form
    {
        List<Funcionario> funcionarios = new List<Funcionario>();

        public Form1()
        {
            InitializeComponent();

            CarregarDados();
            
        }

        private void CarregarDados()
        {
            for(int i = 1; i <= 130; i++)
            {
                comboBoxIdades.Items.Add(i);
            }
        }

        private void Cadastrar(object sender, EventArgs e)
        {
            string nome = txtBoxNome.Text;
            int idade = int.Parse(comboBoxIdades.Text);

            Funcionario f = new Funcionario(idade, nome);

            funcionarios.Add(f);
            listBox1.Items.Add(f.nome);
        }

        private void comboBoxIdades_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Salvar_Click(object sender, EventArgs e)
        {
            f.asString();
        }
    }
}
