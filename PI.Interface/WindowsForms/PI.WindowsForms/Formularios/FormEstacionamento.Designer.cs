namespace PI.WindowsForms.Formularios
{
    partial class FormEstacionamento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEstacionamento));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtVagaLivreEstacionamento = new System.Windows.Forms.TextBox();
            this.txtNumeroVagasEstacionamento = new System.Windows.Forms.TextBox();
            this.txtVagasOcupadasEstacionamento = new System.Windows.Forms.TextBox();
            this.btnSalvarEstacionamento = new System.Windows.Forms.Button();
            this.btnEditarEstacionamento = new System.Windows.Forms.Button();
            this.btnExcluirEstacionamento = new System.Windows.Forms.Button();
            this.dataGridEstacionamento = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEstacionamento)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vaga Livres:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Numero Vagas:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Vagas Ocupadas:";
            // 
            // txtVagaLivreEstacionamento
            // 
            this.txtVagaLivreEstacionamento.Location = new System.Drawing.Point(156, 39);
            this.txtVagaLivreEstacionamento.Name = "txtVagaLivreEstacionamento";
            this.txtVagaLivreEstacionamento.Size = new System.Drawing.Size(326, 20);
            this.txtVagaLivreEstacionamento.TabIndex = 3;
            this.txtVagaLivreEstacionamento.TextChanged += new System.EventHandler(this.txtVagaLivreEstacionamento_TextChanged);
            // 
            // txtNumeroVagasEstacionamento
            // 
            this.txtNumeroVagasEstacionamento.Location = new System.Drawing.Point(156, 74);
            this.txtNumeroVagasEstacionamento.Name = "txtNumeroVagasEstacionamento";
            this.txtNumeroVagasEstacionamento.Size = new System.Drawing.Size(326, 20);
            this.txtNumeroVagasEstacionamento.TabIndex = 4;
            // 
            // txtVagasOcupadasEstacionamento
            // 
            this.txtVagasOcupadasEstacionamento.Location = new System.Drawing.Point(156, 110);
            this.txtVagasOcupadasEstacionamento.Name = "txtVagasOcupadasEstacionamento";
            this.txtVagasOcupadasEstacionamento.Size = new System.Drawing.Size(326, 20);
            this.txtVagasOcupadasEstacionamento.TabIndex = 5;
            // 
            // btnSalvarEstacionamento
            // 
            this.btnSalvarEstacionamento.Location = new System.Drawing.Point(67, 156);
            this.btnSalvarEstacionamento.Name = "btnSalvarEstacionamento";
            this.btnSalvarEstacionamento.Size = new System.Drawing.Size(75, 23);
            this.btnSalvarEstacionamento.TabIndex = 6;
            this.btnSalvarEstacionamento.Text = "Salvar";
            this.btnSalvarEstacionamento.UseVisualStyleBackColor = true;
            this.btnSalvarEstacionamento.Click += new System.EventHandler(this.btnSalvarEstacionamento_Click);
            // 
            // btnEditarEstacionamento
            // 
            this.btnEditarEstacionamento.Location = new System.Drawing.Point(234, 156);
            this.btnEditarEstacionamento.Name = "btnEditarEstacionamento";
            this.btnEditarEstacionamento.Size = new System.Drawing.Size(75, 23);
            this.btnEditarEstacionamento.TabIndex = 7;
            this.btnEditarEstacionamento.Text = "Editar";
            this.btnEditarEstacionamento.UseVisualStyleBackColor = true;
            this.btnEditarEstacionamento.Click += new System.EventHandler(this.btnEditarEstacionamento_Click);
            // 
            // btnExcluirEstacionamento
            // 
            this.btnExcluirEstacionamento.Location = new System.Drawing.Point(407, 156);
            this.btnExcluirEstacionamento.Name = "btnExcluirEstacionamento";
            this.btnExcluirEstacionamento.Size = new System.Drawing.Size(75, 23);
            this.btnExcluirEstacionamento.TabIndex = 8;
            this.btnExcluirEstacionamento.Text = "Excluir";
            this.btnExcluirEstacionamento.UseVisualStyleBackColor = true;
            this.btnExcluirEstacionamento.Click += new System.EventHandler(this.btnExcluirEstacionamento_Click);
            // 
            // dataGridEstacionamento
            // 
            this.dataGridEstacionamento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridEstacionamento.Location = new System.Drawing.Point(67, 185);
            this.dataGridEstacionamento.Name = "dataGridEstacionamento";
            this.dataGridEstacionamento.Size = new System.Drawing.Size(415, 150);
            this.dataGridEstacionamento.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(326, 156);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Excluir";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // FormEstacionamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 361);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridEstacionamento);
            this.Controls.Add(this.btnExcluirEstacionamento);
            this.Controls.Add(this.btnEditarEstacionamento);
            this.Controls.Add(this.btnSalvarEstacionamento);
            this.Controls.Add(this.txtVagasOcupadasEstacionamento);
            this.Controls.Add(this.txtNumeroVagasEstacionamento);
            this.Controls.Add(this.txtVagaLivreEstacionamento);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormEstacionamento";
            this.Text = "Estacionamento";
            this.Load += new System.EventHandler(this.FormEstacionamento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEstacionamento)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtVagaLivreEstacionamento;
        private System.Windows.Forms.TextBox txtNumeroVagasEstacionamento;
        private System.Windows.Forms.TextBox txtVagasOcupadasEstacionamento;
        private System.Windows.Forms.Button btnSalvarEstacionamento;
        private System.Windows.Forms.Button btnEditarEstacionamento;
        private System.Windows.Forms.Button btnExcluirEstacionamento;
        private System.Windows.Forms.DataGridView dataGridEstacionamento;
        private System.Windows.Forms.Button button1;
    }
}