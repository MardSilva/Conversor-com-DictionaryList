using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Teste_BancoSemar
{
    public partial class frmPrincipal : Form
    {
        string textodigitado;

        public frmPrincipal()
        {
            InitializeComponent();
        }

        public void ValidarDigitado()
        {
            if (txtcaracteres.Text == "")
            {
                MessageBox.Show("Ops! Parece que não temos nenhum valor digitado para ser convertido.", "Conversor de Comerciante da Galáxia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtcaracteres.Focus();
            }
        }

        private void BtnTabInfo_Click(object sender, EventArgs e)
        {
            tbControlesConversor.SelectTab("tbInfo");
        }

        private void BtnConverter_Click(object sender, EventArgs e)
        {
            tbControlesConversor.SelectTab("tbCaracteresNumero");
        }

        private void BtnConversaoNumCarac_Click(object sender, EventArgs e)
        {
            tbControlesConversor.SelectTab("tbNumeroCaractere");
        }

        private void Txtcaracteres_TextChanged(object sender, EventArgs e)
        {
            //criando um evento de inicialização da variável quando o texto for digitando e assinalando-o para a variável textodigitado;
           
            textodigitado = txtcaracteres.ToString();
        }

        private void BtnConversor_Click(object sender, EventArgs e)
        {
            string textoconverter = textodigitado;

            ValidarDigitado();

            //criando e inicializando um dicionário de valores e itens com o nome de ListaSubstituicao

            Dictionary<string, int> ListaSubstituicao = new Dictionary<string, int>();

            ListaSubstituicao.Add("I", 1);
            ListaSubstituicao.Add("V", 5);
            ListaSubstituicao.Add("X", 10);
            ListaSubstituicao.Add("L", 50);
            ListaSubstituicao.Add("C", 100);
            ListaSubstituicao.Add("D", 500);
            ListaSubstituicao.Add("M", 1000);

            int soma = 0;
            bool textovalido = true;

            foreach (var ch in textoconverter.ToArray())
            {
                if(ListaSubstituicao.TryGetValue(ch.ToString(), out var value))
                {

                    soma += value;
                    txtconversaocaracteres.Text = "G$ " + soma.ToString();

                    lblmsg.ForeColor = Color.DarkGreen;
                    lblmsg.Text = "Yeah Houston, we made it! O valor informado foi encontrado e convertido com sucesso.";
                }

                else if (textovalido == false)
                {
                    textovalido = false;
                    lblmsg.ForeColor = Color.DarkRed;
                    lblmsg.Text = "Houston we have a problem!Houve um erro ao tentar converter esta cadeia de caracteres.";
                    break;

                }
            }

        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            if (txtcaracteres.Text == "" && txtconversaocaracteres.Text == "")
            {
                MessageBox.Show("As caixas de textos já estão vazias. \nNão há informações para serem removidas por aqui.","Conversor de Comerciante da Galáxia", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //definindo a mensagem que irá aparecer no lblmsg ao tentar limpar e não encontrar nada

                lblmsg.ForeColor = Color.DarkRed;
                lblmsg.Text = "Houston we have a problem! Não conseguimos encontrar nada para limpar por aqui.";

            }
            else
            {
                txtcaracteres.Clear();
                txtconversaocaracteres.Clear();
                lblmsg.Text = "";
            }
        }

        private void BtnSobre_Click(object sender, EventArgs e)
        {
            sobre novosobre = new sobre();
            novosobre.ShowDialog();
        }
    }
}
