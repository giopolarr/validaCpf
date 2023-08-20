using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace atividade1___IMC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tx_nome_TextChanged(object sender, EventArgs e)
        {

        }

        private void tx_botao_Click(object sender, EventArgs e)
        {
           
          
            tx_nome.Clear();
            tx_cpf.Clear();
            tx_sexo.ResetText();
            tx_peso.ResetText();
            tx_altura.ResetText();
            tx_idade.ResetText();
        }

        private void tx_as_Click(object sender, EventArgs e)
        {
            

        }


        private void tx_resultado_Click(object sender, EventArgs e)
        {

        }

        private void bt_calcular_Click(object sender, EventArgs e)
        {
            string nome = tx_nome.Text;
            string cpf = tx_cpf.Text;
            double altura = Convert.ToDouble(tx_altura.Text);
            double peso = Convert.ToDouble(tx_peso.Text);
            string sexo = tx_sexo.Text;
            string idade = tx_idade.Text;
            Pessoa p = new Pessoa(nome, cpf, altura, peso, sexo, idade);
            (double a, string b, string c) = p.CalcularIMC();
            tx_resultado.Text = $"O imc é {a.ToString("0.00")} \n Classificação:{b} \n Obesidade grau:{c} + \n CPF: {Validacoes.ValidaCpf(cpf)}";
            Validacoes.ValidaCpf(cpf);

        }
    }
}
