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
    public partial class FormFuncionario : Form
    {
        EstacionamentoEntities db = new EstacionamentoEntities();
        private Funcionario funcionario;
        private lEstacionamento estacionamento;

        public FormFuncionario()
        {
            InitializeComponent();
        }

        private void FormFuncionario_Load(object sender, EventArgs e)
        {
            cboEstacionamento.DataSource = db.lEstacionamento.ToList();
            cboEstacionamento.DisplayMember = "IdEstacionamento";
            cboEstacionamento.ValueMember = "IdEstacionamento";

            dataGridFuncionario.ColumnCount = 5;
            dataGridFuncionario.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGridFuncionario.MultiSelect = false;
            dataGridFuncionario.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dataGridFuncionario.Columns[0].HeaderText = "IdFuncionario";
            dataGridFuncionario.Columns[0].DataPropertyName = "IdFuncionario";
            dataGridFuncionario.Columns[0].Width = 50;
            dataGridFuncionario.Columns[0].Name = "IdFuncionario";

            dataGridFuncionario.Columns[1].HeaderText = "Nome";
            dataGridFuncionario.Columns[1].DataPropertyName = "Nome";
            dataGridFuncionario.Columns[1].Width = 100;
            dataGridFuncionario.Columns[1].Name = "Nome";

            dataGridFuncionario.Columns[2].HeaderText = "CPF";
            dataGridFuncionario.Columns[2].DataPropertyName = "CPF";
            dataGridFuncionario.Columns[2].Width = 50;
            dataGridFuncionario.Columns[2].Name = "CPF";

            dataGridFuncionario.Columns[3].HeaderText = "Salario";
            dataGridFuncionario.Columns[3].DataPropertyName = "Salario";
            dataGridFuncionario.Columns[3].Width = 50;
            dataGridFuncionario.Columns[3].Name = "Salario";

            dataGridFuncionario.Columns[4].HeaderText = "IdEstacionamento";
            dataGridFuncionario.Columns[4].DataPropertyName = "IdEstacionamento";
            dataGridFuncionario.Columns[4].Width = 100;
            dataGridFuncionario.Columns[4].Name = "IdEstacionamento";

            CarregarGrid();

        }

        public void CarregarGrid()
        {
            var funcionarios = from funci in db.Funcionario
                               join lEstacionamento in db.lEstacionamento
                               on funci.IdEstacionamento equals lEstacionamento.IdEstacionamento
                               select (new { funci.IdFuncionario, funci.Nome, funci.CPF, funci.Salario, lEstacionamento.IdEstacionamento });
            dataGridFuncionario.DataSource = funcionarios.ToList();


        }

        private void btnSalvarFuncionario_Click(object sender, EventArgs e)
        {
            if (funcionario == null)
                funcionario = new Funcionario();

            int idFuncionario = funcionario.IdFuncionario > 0 ? funcionario.IdFuncionario : 0;

            funcionario.IdFuncionario = idFuncionario;
            funcionario.Salario = Convert.ToDouble(txtSalarioFuncionario.Text);
            funcionario.Nome = txtNomeFuncionario.Text;
            funcionario.CPF = Convert.ToInt64(txtCPFFuncionario.Text);
            //funcionario.IdEstacionamento = (int)txtIdEstacionamento.Text;
            funcionario.IdEstacionamento = (int)cboEstacionamento.SelectedValue;

            string mensagem = "";

            if(funcionario.IdFuncionario == 0)
            {
                db.Funcionario.Add(funcionario);
                mensagem = "Funcionario registrado com sucesso";
            }

            else
            {
                var obj = db.Entry(funcionario);
                obj.Property(x => x.Nome).IsModified = true;
                mensagem = "Funcionario alterado com sucesso";
            }

            db.SaveChanges();

            MessageBox.Show(mensagem);
            CarregarGrid();
            LimparCampos();

        }

        public void LimparCampos()
        {
            txtNomeFuncionario.Clear();
            txtCPFFuncionario.Clear();
            txtSalarioFuncionario.Clear();
            funcionario = null;
        }

        private void btEditarFuncionario_Click(object sender, EventArgs e)
        {
            if(dataGridFuncionario.SelectedRows.Count > 0)
            {

                DataGridViewRow linha = dataGridFuncionario.SelectedRows[0];
                int idFuncionario = (int)linha.Cells["IdFuncionario"].Value;

                funcionario = db.Funcionario.Where(x => x.IdFuncionario == idFuncionario).FirstOrDefault();
                txtNomeFuncionario.Text = funcionario.Nome;
                txtSalarioFuncionario.Text = funcionario.Salario.ToString();
                txtCPFFuncionario.Text = funcionario.CPF.ToString();
                cboEstacionamento.SelectedValue = funcionario.IdEstacionamento;
                
            }

            else
            {
                MessageBox.Show("Selecione um Funcionario para ser alterado");
            }
        }

        private void btnExcluirFuncionario_Click(object sender, EventArgs e)
        {

            if (dataGridFuncionario.SelectedRows.Count > 0)
            {

                DataGridViewRow linha = dataGridFuncionario.SelectedRows[0];
                int idFuncionario = (int)linha.Cells["IdFuncionario"].Value;

                funcionario = db.Funcionario.Where(x => x.IdFuncionario == idFuncionario).FirstOrDefault();

                db.Funcionario.Remove(funcionario);
                db.SaveChanges();

                MessageBox.Show("Funcionario excluido com sucesso");
                CarregarGrid();
                LimparCampos();

            }

            else
            {
                MessageBox.Show("Selecione um funcionario para excluir!");
            }
        }
    }
}
