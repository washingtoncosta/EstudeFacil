namespace EstudeFácil
{
    partial class Topicos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Topicos));
            this.label1 = new System.Windows.Forms.Label();
            this.btnSim = new System.Windows.Forms.Button();
            this.btnNao = new System.Windows.Forms.Button();
            this.txtTopico = new System.Windows.Forms.TextBox();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(130, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(349, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ficou com dúvida em algum tópico?";
            // 
            // btnSim
            // 
            this.btnSim.FlatAppearance.BorderColor = System.Drawing.Color.MediumAquamarine;
            this.btnSim.FlatAppearance.BorderSize = 3;
            this.btnSim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSim.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSim.Location = new System.Drawing.Point(204, 60);
            this.btnSim.Name = "btnSim";
            this.btnSim.Size = new System.Drawing.Size(84, 33);
            this.btnSim.TabIndex = 1;
            this.btnSim.Text = "Sim";
            this.btnSim.UseVisualStyleBackColor = true;
            this.btnSim.Click += new System.EventHandler(this.btnSim_Click);
            // 
            // btnNao
            // 
            this.btnNao.FlatAppearance.BorderColor = System.Drawing.Color.MediumAquamarine;
            this.btnNao.FlatAppearance.BorderSize = 3;
            this.btnNao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNao.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNao.Location = new System.Drawing.Point(325, 60);
            this.btnNao.Name = "btnNao";
            this.btnNao.Size = new System.Drawing.Size(84, 33);
            this.btnNao.TabIndex = 2;
            this.btnNao.Text = "Não";
            this.btnNao.UseVisualStyleBackColor = true;
            this.btnNao.Click += new System.EventHandler(this.btnNao_Click);
            // 
            // txtTopico
            // 
            this.txtTopico.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTopico.Location = new System.Drawing.Point(12, 111);
            this.txtTopico.Name = "txtTopico";
            this.txtTopico.Size = new System.Drawing.Size(252, 29);
            this.txtTopico.TabIndex = 3;
            this.txtTopico.Visible = false;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.FlatAppearance.BorderColor = System.Drawing.Color.MediumAquamarine;
            this.btnAdicionar.FlatAppearance.BorderSize = 3;
            this.btnAdicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdicionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionar.Location = new System.Drawing.Point(286, 107);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(123, 33);
            this.btnAdicionar.TabIndex = 4;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Visible = false;
            this.btnAdicionar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.FlatAppearance.BorderColor = System.Drawing.Color.MediumAquamarine;
            this.btnFinalizar.FlatAppearance.BorderSize = 3;
            this.btnFinalizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinalizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinalizar.Location = new System.Drawing.Point(421, 107);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(106, 33);
            this.btnFinalizar.TabIndex = 5;
            this.btnFinalizar.Text = "Finalizar";
            this.btnFinalizar.UseVisualStyleBackColor = true;
            this.btnFinalizar.Visible = false;
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
            // 
            // Topicos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(637, 213);
            this.Controls.Add(this.btnFinalizar);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.txtTopico);
            this.Controls.Add(this.btnNao);
            this.Controls.Add(this.btnSim);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Topicos";
            this.Text = "Topicos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSim;
        private System.Windows.Forms.Button btnNao;
        private System.Windows.Forms.TextBox txtTopico;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Button btnFinalizar;
    }
}