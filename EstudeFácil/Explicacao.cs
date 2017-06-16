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
    public partial class Explicacao : Form
    {
        public bool topicos = false;
        public int nTopico = 0;
        public int topMax = 0; //armazenar o ultimo valor para parar no último tópico selecionado.
        public Explicacao()
        {
            InitializeComponent();
        }
        public void proximoTopico()
        {
            this.label1.Text = "Explique tópico " + Form1.topicos[++nTopico] + ".";
            this.txtTexto.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (topicos)
            {
                Form1.explicacaoTopico[nTopico] = txtTexto.Text;
                if (nTopico < topMax - 1)
                    proximoTopico();
                else { 
                MessageBox.Show("Parabéns!! Você terminou os seus estudos!");
                this.Hide();
            }
            }
            else
            {
                Topicos t = new Topicos();
                this.Hide();
                t.Show();
            }
        }

        private void Explicacao_Load(object sender, EventArgs e)
        {
            if (topicos)
            {
                this.label1.Text = "Explique tópico " + Form1.topicos[nTopico]+".";
            }
        }
    }
}
