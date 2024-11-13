using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ordem_crescente
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Deseja realmente sair?", "Sair", MessageBoxButtons.YesNo) == DialogResult.Yes)
                Close();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtValor1.Clear();
            txtValor2.Clear();
            txtValor3.Clear();
            txtValor1.Focus();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int valor1, valor2, valor3;

            valor1 = int.Parse(txtValor1.Text); 
            valor2 = int.Parse(txtValor2.Text);
            valor3 = int.Parse(txtValor3.Text);


            if (valor1 > valor2 && valor1 > valor3)
            {
                if(valor2 > valor3)
                {
                    MessageBox.Show("Os números em ordem crescente são: " + valor3 + ", " + valor2 + ", " + valor1);
                }
                else 
                {
                    MessageBox.Show("Os números em ordem crescente são: " + valor2 + ", " + valor3 + ", " + valor1);
                }
            }

            else if (valor2> valor3 && valor2 > valor1)
            {
                if(valor3 > valor1)
                {
                    MessageBox.Show("Os números em ordem crescente são: " + valor1 + ", " + valor3 + ", " + valor2);
                }
                else
                {
                    MessageBox.Show("Os números em ordem crescente são: " + valor3 + ", " + valor1 + ", " + valor2);
                }
            }

            else if (valor3> valor2 && valor3 > valor1)
            {
                if(valor2 > valor1)
                {
                    MessageBox.Show("Os números em ordem crescente são: " + valor1 + ", " + valor2 + ", " + valor3);
                }
                else
                {
                    MessageBox.Show("Os números em ordem crescente são: " + valor2 + ", " + valor1 + ", " + valor3);
                }
            }
        }

    }
}
