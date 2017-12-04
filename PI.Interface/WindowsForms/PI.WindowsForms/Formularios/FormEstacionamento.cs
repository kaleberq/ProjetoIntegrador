using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using PI.Modelo;
using System.Data.Entity;

namespace PI.WindowsForms.Formularios
{
    public partial class FormEstacionamento : Form
    {
        EstacionamentoEntities db = new EstacionamentoEntities();
        private lEstacionamento estacionamento;

        public FormEstacionamento()
        {
            InitializeComponent();
        }

        private void FormEstacionamento_Load(object sender, EventArgs e)
        {

            dataGridEstacionamento.ColumnCount = 4;
            dataGridEstacionamento.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGridEstacionamento.MultiSelect = false;
            dataGridEstacionamento.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dataGridEstacionamento.Columns[0].HeaderText = "IdEstacionamento";
            dataGridEstacionamento.Columns[0].DataPropertyName = "IdEstacionamento";
            dataGridEstacionamento.Columns[0].Width = 100;
            dataGridEstacionamento.Columns[0].Name = "IdEstacionamento";

            dataGridEstacionamento.Columns[1].HeaderText = "VagasLivres";
            dataGridEstacionamento.Columns[1].DataPropertyName = "VagasLivres";
            dataGridEstacionamento.Columns[1].Width = 90;
            dataGridEstacionamento.Columns[1].Name = "VagasLivres";

            dataGridEstacionamento.Columns[2].HeaderText = "NumeroVagas";
            dataGridEstacionamento.Columns[2].DataPropertyName = "NumeroVagas";
            dataGridEstacionamento.Columns[2].Width = 90;
            dataGridEstacionamento.Columns[2].Name = "NumeroVagas";

            dataGridEstacionamento.Columns[3].HeaderText = "VagasOcupadas";
            dataGridEstacionamento.Columns[3].DataPropertyName = "VagasOcupadas";
            dataGridEstacionamento.Columns[3].Width = 90;
            dataGridEstacionamento.Columns[3].Name = "VagasOcupadas";

            CarregarGrid();
        }

        public void CarregarGrid()
        {
            var estacionamentos = from estaci in db.lEstacionamento
                               select (new { estaci.IdEstacionamento, estaci.VagasLivres, estaci.NumeroVagas, estaci.VagasOcupadas });
            dataGridEstacionamento.DataSource = estacionamentos.ToList();


        }

        private void txtVagaLivreEstacionamento_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSalvarEstacionamento_Click(object sender, EventArgs e)
        {
            if (estacionamento == null)
                estacionamento = new lEstacionamento();

            int idEstacionamento = estacionamento.IdEstacionamento > 0 ? estacionamento.IdEstacionamento : 0;

            estacionamento.IdEstacionamento = idEstacionamento;
            estacionamento.VagasLivres = Convert.ToInt16(txtVagaLivreEstacionamento.Text);
            estacionamento.NumeroVagas = Convert.ToInt16(txtNumeroVagasEstacionamento.Text);
            estacionamento.VagasOcupadas = Convert.ToInt16(txtNumeroVagasEstacionamento.Text);
            

            string mensagem = "";

            if (estacionamento.IdEstacionamento == 0)
            {
                db.lEstacionamento.Add(estacionamento);
                mensagem = "estacionamento registrado com sucesso";
            }

            else
            {
                var obj = db.Entry(estacionamento);
                obj.Property(x => x.VagasLivres).IsModified = true;
                mensagem = "estacionamento alterado com sucesso";
            }

            db.SaveChanges();

            MessageBox.Show(mensagem);
            CarregarGrid();
            LimparCampos();

        }
        public void LimparCampos()
        {
            txtNumeroVagasEstacionamento.Clear();
            txtVagaLivreEstacionamento.Clear();
            txtVagasOcupadasEstacionamento.Clear();

            estacionamento = null;
        }

        private void btnEditarEstacionamento_Click(object sender, EventArgs e)
        {
            if (dataGridEstacionamento.SelectedRows.Count > 0)
            {

                DataGridViewRow linha = dataGridEstacionamento.SelectedRows[0];
                int idEstscionamento = (int)linha.Cells["IdEstacionamento"].Value;

                estacionamento = db.lEstacionamento.Where(x => x.IdEstacionamento == idEstscionamento).FirstOrDefault();
                txtVagaLivreEstacionamento.Text = estacionamento.VagasLivres.ToString();
                txtNumeroVagasEstacionamento.Text = estacionamento.NumeroVagas.ToString();
                txtVagasOcupadasEstacionamento.Text = estacionamento.VagasOcupadas.ToString();


            }

            else
            {
                MessageBox.Show("Selecione um Estacionamento para ser alterado");
            }
        }

        private void btnExcluirEstacionamento_Click(object sender, EventArgs e)
        {
            if (dataGridEstacionamento.SelectedRows.Count > 0)
            {

                DataGridViewRow linha = dataGridEstacionamento.SelectedRows[0];
                int idEstacionamento = (int)linha.Cells["IdEstacionamento"].Value;

                estacionamento = db.lEstacionamento.Where(x => x.IdEstacionamento == idEstacionamento).FirstOrDefault();


                db.lEstacionamento.Remove(estacionamento);
                db.SaveChanges();

                MessageBox.Show("Estacionamento excluido com sucesso");
                CarregarGrid();
                LimparCampos();

            }

            else
            {
                MessageBox.Show("Selecione um festacionamento para excluir!");
            }
        }
    }
}
