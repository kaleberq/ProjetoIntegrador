namespace PI.WindowsForms.Formularios
{
    partial class FormFuncionario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFuncionario));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNomeFuncionario = new System.Windows.Forms.TextBox();
            this.txtCPFFuncionario = new System.Windows.Forms.TextBox();
            this.txtSalarioFuncionario = new System.Windows.Forms.TextBox();
            this.dataGridFuncionario = new System.Windows.Forms.DataGridView();
            this.btnSalvarFuncionario = new System.Windows.Forms.Button();
            this.btEditarFuncionario = new System.Windows.Forms.Button();
            this.btnExcluirFuncionario = new System.Windows.Forms.Button();
            this.cboEstacionamento = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFuncionario)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(75, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "CPF:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(75, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Salário:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(75, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "IdEstacionamento:";
            // 
            // txtNomeFuncionario
            // 
            this.txtNomeFuncionario.Location = new System.Drawing.Point(176, 39);
            this.txtNomeFuncionario.Name = "txtNomeFuncionario";
            this.txtNomeFuncionario.Size = new System.Drawing.Size(295, 20);
            this.txtNomeFuncionario.TabIndex = 4;
            // 
            // txtCPFFuncionario
            // 
            this.txtCPFFuncionario.Location = new System.Drawing.Point(176, 74);
            this.txtCPFFuncionario.Name = "txtCPFFuncionario";
            this.txtCPFFuncionario.Size = new System.Drawing.Size(295, 20);
            this.txtCPFFuncionario.TabIndex = 5;
            // 
            // txtSalarioFuncionario
            // 
            this.txtSalarioFuncionario.Location = new System.Drawing.Point(176, 100);
            this.txtSalarioFuncionario.Name = "txtSalarioFuncionario";
            this.txtSalarioFuncionario.Size = new System.Drawing.Size(295, 20);
            this.txtSalarioFuncionario.TabIndex = 6;
            // 
            // dataGridFuncionario
            // 
            this.dataGridFuncionario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridFuncionario.Location = new System.Drawing.Point(78, 188);
            this.dataGridFuncionario.Name = "dataGridFuncionario";
            this.dataGridFuncionario.Size = new System.Drawing.Size(393, 150);
            this.dataGridFuncionario.TabIndex = 8;
            // 
            // btnSalvarFuncionario
            // 
            this.btnSalvarFuncionario.Location = new System.Drawing.Point(78, 159);
            this.btnSalvarFuncionario.Name = "btnSalvarFuncionario";
            this.btnSalvarFuncionario.Size = new System.Drawing.Size(75, 23);
            this.btnSalvarFuncionario.TabIndex = 9;
            this.btnSalvarFuncionario.Text = "Salvar";
            this.btnSalvarFuncionario.UseVisualStyleBackColor = true;
            this.btnSalvarFuncionario.Click += new System.EventHandler(this.btnSalvarFuncionario_Click);
            // 
            // btEditarFuncionario
            // 
            this.btEditarFuncionario.Location = new System.Drawing.Point(240, 159);
            this.btEditarFuncionario.Name = "btEditarFuncionario";
            this.btEditarFuncionario.Size = new System.Drawing.Size(75, 23);
            this.btEditarFuncionario.TabIndex = 10;
            this.btEditarFuncionario.Text = "Editar";
            this.btEditarFuncionario.UseVisualStyleBackColor = true;
            this.btEditarFuncionario.Click += new System.EventHandler(this.btEditarFuncionario_Click);
            // 
            // btnExcluirFuncionario
            // 
            this.btnExcluirFuncionario.Location = new System.Drawing.Point(396, 159);
            this.btnExcluirFuncionario.Name = "btnExcluirFuncionario";
            this.btnExcluirFuncionario.Size = new System.Drawing.Size(75, 23);
            this.btnExcluirFuncionario.TabIndex = 11;
            this.btnExcluirFuncionario.Text = "Excluir";
            this.btnExcluirFuncionario.UseVisualStyleBackColor = true;
            this.btnExcluirFuncionario.Click += new System.EventHandler(this.btnExcluirFuncionario_Click);
            // 
            // cboEstacionamento
            // 
            this.cboEstacionamento.FormattingEnabled = true;
            this.cboEstacionamento.Location = new System.Drawing.Point(176, 130);
            this.cboEstacionamento.Name = "cboEstacionamento";
            this.cboEstacionamento.Size = new System.Drawing.Size(295, 21);
            this.cboEstacionamento.TabIndex = 12;
            // 
            // FormFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 361);
            this.Controls.Add(this.cboEstacionamento);
            this.Controls.Add(this.btnExcluirFuncionario);
            this.Controls.Add(this.btEditarFuncionario);
            this.Controls.Add(this.btnSalvarFuncionario);
            this.Controls.Add(this.dataGridFuncionario);
            this.Controls.Add(this.txtSalarioFuncionario);
            this.Controls.Add(this.txtCPFFuncionario);
            this.Controls.Add(this.txtNomeFuncionario);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormFuncionario";
            this.Text = "Funcionarios";
            this.Load += new System.EventHandler(this.FormFuncionario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFuncionario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNomeFuncionario;
        private System.Windows.Forms.TextBox txtCPFFuncionario;
        private System.Windows.Forms.TextBox txtSalarioFuncionario;
        private System.Windows.Forms.DataGridView dataGridFuncionario;
        private System.Windows.Forms.Button btnSalvarFuncionario;
        private System.Windows.Forms.Button btEditarFuncionario;
        private System.Windows.Forms.Button btnExcluirFuncionario;
        private System.Windows.Forms.ComboBox cboEstacionamento;
    }
}