using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace PI.WindowsForms.Formularios
{
    public partial class FormPrincipal : Form
    {
        

        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void funcionariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormFuncionario formFuncionario = new FormFuncionario();
            
            formFuncionario.ShowDialog();

        }

        private void estacionamentoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormEstacionamento formEstacionamento = new FormEstacionamento();
            
            formEstacionamento.ShowDialog();

        }

        private void vagaVeiculoToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void vagaVeiculoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormVagaVeiculo formVagaVeiculo = new FormVagaVeiculo();
            
            formVagaVeiculo.ShowDialog();
        }
    }
}
