namespace PI.WindowsForms.Formularios
{
    partial class FormVagaVeiculo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormVagaVeiculo));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cboPlaca = new System.Windows.Forms.ComboBox();
            this.dataGridVagaVeiculo = new System.Windows.Forms.DataGridView();
            this.btnSalvarVaga = new System.Windows.Forms.Button();
            this.btEditarVaga = new System.Windows.Forms.Button();
            this.btnExcluirVaga = new System.Windows.Forms.Button();
            this.dtmEntrada = new System.Windows.Forms.DateTimePicker();
            this.cboIdFuncionario = new System.Windows.Forms.ComboBox();
            this.dtmSaida = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridVagaVeiculo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Horário entrada:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(72, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Horário Saída:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(72, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "IdFuncionario:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(72, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Placa:";
            // 
            // cboPlaca
            // 
            this.cboPlaca.FormattingEnabled = true;
            this.cboPlaca.Location = new System.Drawing.Point(156, 143);
            this.cboPlaca.Name = "cboPlaca";
            this.cboPlaca.Size = new System.Drawing.Size(326, 21);
            this.cboPlaca.TabIndex = 14;
            // 
            // dataGridVagaVeiculo
            // 
            this.dataGridVagaVeiculo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridVagaVeiculo.Location = new System.Drawing.Point(67, 185);
            this.dataGridVagaVeiculo.Name = "dataGridVagaVeiculo";
            this.dataGridVagaVeiculo.Size = new System.Drawing.Size(374, 150);
            this.dataGridVagaVeiculo.TabIndex = 15;
            // 
            // btnSalvarVaga
            // 
            this.btnSalvarVaga.Location = new System.Drawing.Point(447, 185);
            this.btnSalvarVaga.Name = "btnSalvarVaga";
            this.btnSalvarVaga.Size = new System.Drawing.Size(75, 23);
            this.btnSalvarVaga.TabIndex = 16;
            this.btnSalvarVaga.Text = "Salvar";
            this.btnSalvarVaga.UseVisualStyleBackColor = true;
            this.btnSalvarVaga.Click += new System.EventHandler(this.btnSalvarVaga_Click);
            // 
            // btEditarVaga
            // 
            this.btEditarVaga.Location = new System.Drawing.Point(447, 246);
            this.btEditarVaga.Name = "btEditarVaga";
            this.btEditarVaga.Size = new System.Drawing.Size(75, 23);
            this.btEditarVaga.TabIndex = 17;
            this.btEditarVaga.Text = "Editar";
            this.btEditarVaga.UseVisualStyleBackColor = true;
            this.btEditarVaga.Click += new System.EventHandler(this.btEditarVaga_Click);
            // 
            // btnExcluirVaga
            // 
            this.btnExcluirVaga.Location = new System.Drawing.Point(447, 312);
            this.btnExcluirVaga.Name = "btnExcluirVaga";
            this.btnExcluirVaga.Size = new System.Drawing.Size(75, 23);
            this.btnExcluirVaga.TabIndex = 18;
            this.btnExcluirVaga.Text = "Excluir";
            this.btnExcluirVaga.UseVisualStyleBackColor = true;
            this.btnExcluirVaga.Click += new System.EventHandler(this.btnExcluirVaga_Click);
            // 
            // dtmEntrada
            // 
            this.dtmEntrada.Location = new System.Drawing.Point(156, 39);
            this.dtmEntrada.Name = "dtmEntrada";
            this.dtmEntrada.Size = new System.Drawing.Size(326, 20);
            this.dtmEntrada.TabIndex = 19;
            // 
            // cboIdFuncionario
            // 
            this.cboIdFuncionario.FormattingEnabled = true;
            this.cboIdFuncionario.Location = new System.Drawing.Point(156, 110);
            this.cboIdFuncionario.Name = "cboIdFuncionario";
            this.cboIdFuncionario.Size = new System.Drawing.Size(326, 21);
            this.cboIdFuncionario.TabIndex = 13;
            // 
            // dtmSaida
            // 
            this.dtmSaida.Location = new System.Drawing.Point(156, 74);
            this.dtmSaida.Name = "dtmSaida";
            this.dtmSaida.Size = new System.Drawing.Size(326, 20);
            this.dtmSaida.TabIndex = 20;
            // 
            // FormVagaVeiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 361);
            this.Controls.Add(this.dtmSaida);
            this.Controls.Add(this.dtmEntrada);
            this.Controls.Add(this.btnExcluirVaga);
            this.Controls.Add(this.btEditarVaga);
            this.Controls.Add(this.btnSalvarVaga);
            this.Controls.Add(this.dataGridVagaVeiculo);
            this.Controls.Add(this.cboPlaca);
            this.Controls.Add(this.cboIdFuncionario);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormVagaVeiculo";
            this.Text = "VagaVeiculo";
            this.Load += new System.EventHandler(this.FormVagaVeiculo_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridVagaVeiculo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboPlaca;
        private System.Windows.Forms.DataGridView dataGridVagaVeiculo;
        private System.Windows.Forms.Button btnSalvarVaga;
        private System.Windows.Forms.Button btEditarVaga;
        private System.Windows.Forms.Button btnExcluirVaga;
        private System.Windows.Forms.DateTimePicker dtmEntrada;
        private System.Windows.Forms.ComboBox cboIdFuncionario;
        private System.Windows.Forms.DateTimePicker dtmSaida;
    }
}