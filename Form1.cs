using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TEP_Revisao_Manhã
{
    public partial class Form1 : Form
    {
        int contador = 1;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if(textBoxSenha.Text.Equals("123") && textBoxUsuario.Text.Equals("admin"))
            {
                MessageBox.Show("Acesso permitido");
                this.Close();

            }
            else
            {
                MessageBox.Show("Acesso negado");
                contador++;
                textBoxUsuario.Clear();
                textBoxSenha.Text = "";
            }

            if(contador==4)
            {
                this.Close();

            }

        }
    }
}
