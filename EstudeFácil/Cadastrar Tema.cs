﻿using System;
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
    public partial class Form1 : Form
    {
        public static string assunto;
        public static string[] topicos = new string[100];
        public static string[] explicacaoTopico = new string[100];
        public static string explicacaoAssunto;
        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            assunto = txtAssunto.Text;
            MessageBox.Show("Estude sobre "+ assunto +" e clique em 'Ok' quando estiver pronto para dar sua explicação.");
            Explicacao ex = new Explicacao();
            this.Hide();
            ex.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
