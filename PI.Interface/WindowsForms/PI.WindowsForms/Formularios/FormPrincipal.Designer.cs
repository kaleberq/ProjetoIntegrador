namespace PI.WindowsForms.Formularios
{
    partial class FormPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gerenciadorFuncionarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.funcionariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estacionamentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estacionamentoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.vagaVeiculoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gerenciadorFuncionarioToolStripMenuItem,
            this.estacionamentoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(676, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // gerenciadorFuncionarioToolStripMenuItem
            // 
            this.gerenciadorFuncionarioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.funcionariosToolStripMenuItem});
            this.gerenciadorFuncionarioToolStripMenuItem.Name = "gerenciadorFuncionarioToolStripMenuItem";
            this.gerenciadorFuncionarioToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.gerenciadorFuncionarioToolStripMenuItem.Text = "Funcionario";
            // 
            // funcionariosToolStripMenuItem
            // 
            this.funcionariosToolStripMenuItem.Name = "funcionariosToolStripMenuItem";
            this.funcionariosToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.funcionariosToolStripMenuItem.Text = "Funcionarios";
            this.funcionariosToolStripMenuItem.Click += new System.EventHandler(this.funcionariosToolStripMenuItem_Click);
            // 
            // estacionamentoToolStripMenuItem
            // 
            this.estacionamentoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.estacionamentoToolStripMenuItem1,
            this.vagaVeiculoToolStripMenuItem1});
            this.estacionamentoToolStripMenuItem.Name = "estacionamentoToolStripMenuItem";
            this.estacionamentoToolStripMenuItem.Size = new System.Drawing.Size(104, 20);
            this.estacionamentoToolStripMenuItem.Text = "Estacionamento";
            // 
            // estacionamentoToolStripMenuItem1
            // 
            this.estacionamentoToolStripMenuItem1.Name = "estacionamentoToolStripMenuItem1";
            this.estacionamentoToolStripMenuItem1.Size = new System.Drawing.Size(159, 22);
            this.estacionamentoToolStripMenuItem1.Text = "Estacionamento";
            this.estacionamentoToolStripMenuItem1.Click += new System.EventHandler(this.estacionamentoToolStripMenuItem1_Click);
            // 
            // vagaVeiculoToolStripMenuItem1
            // 
            this.vagaVeiculoToolStripMenuItem1.Name = "vagaVeiculoToolStripMenuItem1";
            this.vagaVeiculoToolStripMenuItem1.Size = new System.Drawing.Size(159, 22);
            this.vagaVeiculoToolStripMenuItem1.Text = "Vaga Veiculo";
            this.vagaVeiculoToolStripMenuItem1.Click += new System.EventHandler(this.vagaVeiculoToolStripMenuItem1_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 405);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormPrincipal";
            this.Text = "Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gerenciadorFuncionarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem funcionariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estacionamentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estacionamentoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem vagaVeiculoToolStripMenuItem1;
    }
}