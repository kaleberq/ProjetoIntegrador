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
    public partial class FormVagaVeiculo : Form
    {
        EstacionamentoEntities db = new EstacionamentoEntities();
        private VagaVeiculo vagaveiculo;

        public FormVagaVeiculo()
        {
            InitializeComponent();
        }

        private void FormVagaVeiculo_Load_1(object sender, EventArgs e)
        {
            cboIdFuncionario.DataSource = db.Funcionario.ToList();
            cboIdFuncionario.DisplayMember = "IdFuncionario";
            cboIdFuncionario.ValueMember = "IdFuncionario";

            cboPlaca.DataSource = db.Veiculo.ToList();
            cboPlaca.DisplayMember = "Placa";
            cboPlaca.ValueMember = "Placa";

            dataGridVagaVeiculo.ColumnCount = 5;
            dataGridVagaVeiculo.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGridVagaVeiculo.MultiSelect = false;
            dataGridVagaVeiculo.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dataGridVagaVeiculo.Columns[0].HeaderText = "IdVaga";
            dataGridVagaVeiculo.Columns[0].DataPropertyName = "IdVaga";
            dataGridVagaVeiculo.Columns[0].Width = 50;
            dataGridVagaVeiculo.Columns[0].Name = "IdVaga";

            dataGridVagaVeiculo.Columns[1].HeaderText = "DateTimeEntrada";
            dataGridVagaVeiculo.Columns[1].DataPropertyName = "DateTimeEntrada";
            dataGridVagaVeiculo.Columns[1].Width = 100;
            dataGridVagaVeiculo.Columns[1].Name = "DateTimeEntrada";

            dataGridVagaVeiculo.Columns[2].HeaderText = "DateTimeSaida";
            dataGridVagaVeiculo.Columns[2].DataPropertyName = "DateTimeSaida";
            dataGridVagaVeiculo.Columns[2].Width = 50;
            dataGridVagaVeiculo.Columns[2].Name = "DateTimeSaida";

            dataGridVagaVeiculo.Columns[3].HeaderText = "IdFuncionario";
            dataGridVagaVeiculo.Columns[3].DataPropertyName = "IdFuncionario";
            dataGridVagaVeiculo.Columns[3].Width = 50;
            dataGridVagaVeiculo.Columns[3].Name = "IdFuncionario";

            dataGridVagaVeiculo.Columns[4].HeaderText = "Placa";
            dataGridVagaVeiculo.Columns[4].DataPropertyName = "Placa";
            dataGridVagaVeiculo.Columns[4].Width = 80;
            dataGridVagaVeiculo.Columns[4].Name = "Placa";

            CarregarGrid();

        }

        public void CarregarGrid()
        {
            var vagas = from vag in db.VagaVeiculo
                               join Funcionario in db.Funcionario
                               on vag.IdFuncionario equals Funcionario.IdFuncionario
                               join Veiculo in db.Veiculo
                               on vag.Placa equals Veiculo.Placa
                               select (new { vag.IdVaga, vag.DateTimeEntrada, vag.DateTimeSaida, Funcionario.IdFuncionario, Veiculo.Placa
                               });
            dataGridVagaVeiculo.DataSource = vagas.ToList();


        }

        private void btnSalvarVaga_Click(object sender, EventArgs e)
        {
            if (vagaveiculo == null)
                vagaveiculo = new VagaVeiculo();

            int idVagaVeiculo = vagaveiculo.IdVaga > 0 ? vagaveiculo.IdVaga : 0;

            vagaveiculo.IdVaga = idVagaVeiculo;
            vagaveiculo.DateTimeEntrada = dtmEntrada.MinDate;
            vagaveiculo.DateTimeSaida = dtmSaida.MaxDate;
            vagaveiculo.IdFuncionario = (int)cboIdFuncionario.SelectedValue;
            vagaveiculo.Placa = (string)cboPlaca.SelectedValue;

            string mensagem = "";

            if (vagaveiculo.IdVaga == 0)
            {
                db.VagaVeiculo.Add(vagaveiculo);
                mensagem = "Vaga Veiculo registrado com sucesso";
            }

            else
            {
                var obj = db.Entry(vagaveiculo);
                obj.Property(x => x.DateTimeEntrada).IsModified = true;
                mensagem = "Vaga alterada com sucesso";
            }

            db.SaveChanges();

            MessageBox.Show(mensagem);
            CarregarGrid();
            LimparCampos();

        }
        public void LimparCampos()
        {
            
            vagaveiculo = null;
        }

        private void btEditarVaga_Click(object sender, EventArgs e)
        {
            if (dataGridVagaVeiculo.SelectedRows.Count > 0)
            {

                DataGridViewRow linha = dataGridVagaVeiculo.SelectedRows[0];
                int idVaga = (int)linha.Cells["IdVaga"].Value;

                vagaveiculo = db.VagaVeiculo.Where(x => x.IdVaga == idVaga).FirstOrDefault();
                dtmEntrada.MinDate = vagaveiculo.DateTimeEntrada;
                dtmSaida.MaxDate = vagaveiculo.DateTimeSaida;
                cboIdFuncionario.SelectedValue = vagaveiculo.IdFuncionario.ToString();
                cboPlaca.SelectedValue = vagaveiculo.Placa.ToString();

            }

            else
            {
                MessageBox.Show("Selecione uma Vaga para ser alterado");
            }
        }

        private void btnExcluirVaga_Click(object sender, EventArgs e)
        {
            if (dataGridVagaVeiculo.SelectedRows.Count > 0)
            {

                DataGridViewRow linha = dataGridVagaVeiculo.SelectedRows[0];
                int idVaga = (int)linha.Cells["IdVaga"].Value;

                vagaveiculo = db.VagaVeiculo.Where(x => x.IdVaga == idVaga).FirstOrDefault();

                db.VagaVeiculo.Remove(vagaveiculo);
                db.SaveChanges();

                MessageBox.Show("vaga excluido com sucesso");
                CarregarGrid();
                LimparCampos();

            }

            else
            {
                MessageBox.Show("Selecione uma vaga para excluir!");
            }
        }
    }
}
