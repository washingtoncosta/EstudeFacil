using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EstudeFácil
{
    public partial class Topicos : Form
    {
        public int nTopico =0;
        public Topicos()
        {
            InitializeComponent();
        }
        public void trocaTela()
        {
            this.txtTopico.Visible = true;
            this.btnAdicionar.Visible = true;
            this.btnFinalizar.Visible = true;

            this.btnSim.Visible = false;
            this.btnNao.Visible = false;
            this.label1.Text = "Adicione os tópicos que ficou com dúvidas.";
        }

        private void btnNao_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Parabéns você finalizou os seus estudos sobre " + Form1.assunto + ".");
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1.topicos[nTopico] = txtTopico.Text;
            MessageBox.Show("Tópico " + ++nTopico + " adicionado");
            this.txtTopico.Text = "";
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            Explicacao ex = new Explicacao();
            ex.topicos = true;
            ex.topMax = nTopico;
            this.Hide();
            ex.Show();
        }

        private void btnSim_Click(object sender, EventArgs e)
        {
            trocaTela();
        }
    }
}
