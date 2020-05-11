using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using calcBianca.Lib;

namespace calcBianca
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

        classOperacoes operacoes = new classOperacoes();

        private double numero1;
        private double numero2;
        private string operacao;
        private double resultado;

        public void initialScreen()
        {
            btnSend.Text = "Adicionar";
            lblHelp.Text = "Adicione um Número";
            txtInput.Text = "";
            txtOutput.Text = "";
            txtInput.Focus();
            txtOutput.Enabled = false;
            lstOutput.Enabled = false;
        }

        private void addNumeroOutput(string n1)
        {
            if (string.IsNullOrEmpty(n1))
            {
                MessageBox.Show("Insira ao menos um número para ser adicionado", "Erro", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                int n2;
                // tenta converter caso seja valido ele adiciona no output para fazer a conta
                if(int.TryParse(n1, out n2))
                {
                    if (btnSend.Text == "Adicionar")
                    {
                        txtOutput.Text = n2.ToString();
                        txtInput.Text = "";
                        btnSend.Text = "Pressione um Operador";
                        lblHelp.Text = "Pressione um Operador";
                        numero1 = n2;
                    }
                    if(btnSend.Text == "Insira o segundo número")
                    {
                        txtOutput.Text += " " + n2;
                        numero2 = n2;
                        resultado = operacoes.pegaOperacao(numero1,numero2,operacao);
                        txtOutput.Text += " = " + resultado;
                        lstOutput.Items.Add(txtOutput.Text);
                        txtOutput.Text = resultado.ToString();
                        txtInput.Text = "";
                        btnSend.Text = "Pressione um Operador";
                        lblHelp.Text = "Pressione um Operador";
                        numero1 = resultado;
                        numero2 = 0;
                        txtInput.Focus();
                    }
                }               
            }       
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            addNumeroOutput(txtInput.Text);
            
        }

        public Boolean validaInputKeypress()
        {
            if (string.IsNullOrEmpty(txtOutput.Text))
                return false;
            else
                return true;
        }

        private void getKeyPress(object sender, KeyPressEventArgs e)
        {
                if (e.KeyChar == 43 && validaInputKeypress())
                {
                    txtOutput.Text = numero1 + " " + " + ";
                    btnSend.Text = "Insira o segundo número";
                    lblHelp.Text = "Insira o segundo número";
                    txtInput.Text = " ";
                    operacao = "+";
                }
                else if (e.KeyChar == 45 && validaInputKeypress())
                {
                    txtOutput.Text = numero1 + " " + " - ";
                    btnSend.Text = "Insira o segundo número";
                    lblHelp.Text = "Insira o segundo número";
                    txtInput.Text = " ";
                    operacao = "-";
                }
                else if (e.KeyChar == 42 && validaInputKeypress())
                {
                    txtOutput.Text = numero1 + " " + " * ";
                    btnSend.Text = "Insira o segundo número";
                    lblHelp.Text = "Insira o segundo número";
                    txtInput.Text = " ";
                    operacao = "*";
                }
                else if (e.KeyChar == 47 && validaInputKeypress())
                {
                    txtOutput.Text = numero1 + " " + " / ";
                    btnSend.Text = "Insira o segundo número";
                    lblHelp.Text = "Insira o segundo número";
                    txtInput.Text = " ";
                    operacao = "/";
                }    
            if(lblHelp.Text != "Pressione um Operador")
            {
                if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
                {
                    e.Handled = true;
                }
            }
            if(e.KeyChar == (char)Keys.Enter && lblHelp.Text != "Pressione um Operador")
            {
                addNumeroOutput(txtInput.Text);
            }
        }

        private void main_Load(object sender, EventArgs e)
        {
            initialScreen();
        }

        private void getKeyUp(object sender, KeyEventArgs e)
        {

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            btnSend.Text = "Adicionar";
            lblHelp.Text = "Adicione o primeiro número";
            txtOutput.Text = "";
        }
    }
}
