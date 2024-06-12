using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace TpAed
{

  public partial class PessoaForm : Form
  {
    private Database db;
    ListaDuplaPessoa pessoas = new ListaDuplaPessoa();
    private bool isAscending = true;


    public PessoaForm()
    {
      InitializeComponent();
      db = new Database("localhost", "pessoa", "root", "M@rtins30750010");
      // Testar a conexão
      try
      {
        db.OpenConnection();
        MessageBox.Show("Conexão bem-sucedida!");
        db.CloseConnection();
      }
      catch (Exception ex)
      {
        MessageBox.Show($"Erro: {ex.Message}");
      }
    }

    private void CarregaGrid()
    {
      // Carregar dados de uma tabela
      string query = @"SELECT 
                      us.Indice,
                      us.UserId as USERID,
                      us.FirstName as NOME, 
                      us.LastName as SOBRENOME,
                      S.Sex as SEXO, 
                      us.Email as EMAIL,
                      us.Phone as CELULAR, 
                      us.Datebirth as DATAN,
                      JT.JobTitle as CARGO
                    FROM users us
                    INNER JOIN Sex S ON S.SexId = us.sex
                    INNER JOIN JobTitle JT ON JT.JobTitleId = us.JobTitle";
      DataTable dt = db.ExecuteQuery(query);
      for (int i = 0; i < dt.Rows.Count; i++)
      {
        //Coloca na tela
        dgvPessoa.Rows.Add();

        dgvPessoa.Rows[i].Cells["USERID"].Value = dt.Rows[i]["USERID"].ToString();
        dgvPessoa.Rows[i].Cells["NOME"].Value = dt.Rows[i]["NOME"].ToString();
        dgvPessoa.Rows[i].Cells["SOBRENOME"].Value = dt.Rows[i]["SOBRENOME"].ToString();
        dgvPessoa.Rows[i].Cells["SEXO"].Value = dt.Rows[i]["SEXO"].ToString();
        dgvPessoa.Rows[i].Cells["EMAIL"].Value = dt.Rows[i]["EMAIL"].ToString();
        dgvPessoa.Rows[i].Cells["CELULAR"].Value = dt.Rows[i]["CELULAR"].ToString();
        dgvPessoa.Rows[i].Cells["DATAN"].Value = Convert.ToDateTime(dt.Rows[i]["DATAN"]).ToString("dd/MM/yyyy");
        dgvPessoa.Rows[i].Cells["CARGO"].Value = dt.Rows[i]["CARGO"].ToString();

        //coloca na lista
        pessoas.InserirFinal(new Pessoa
        {
          UserID = dt.Rows[i]["USERID"].ToString(),
          FirstName = dt.Rows[i]["NOME"].ToString(),
          LastName = dt.Rows[i]["SOBRENOME"].ToString(),
          Sex = dt.Rows[i]["SEXO"].ToString(),
          Email = dt.Rows[i]["EMAIL"].ToString(),
          Phone = dt.Rows[i]["CELULAR"].ToString(),
          DateOfBirth = Convert.ToDateTime(dt.Rows[i]["DATAN"]).ToString("dd/MM/yyyy"),
          JobTitle = dt.Rows[i]["CARGO"].ToString(),
        });
      }
    }
    private void btnCancel_Click(object sender, EventArgs e)
    {
      // Cancelar e fechar o formulário
      this.Close();
    }

    private void PessoaForm_Load(object sender, EventArgs e)
    {
      // Inicialização do formulário
      dgvPessoa.Rows.Clear();
      CarregaGrid();
      // Configurar SortMode para cada coluna
      foreach (DataGridViewColumn column in dgvPessoa.Columns)
      {
        column.SortMode = DataGridViewColumnSortMode.Automatic;
      }
      LoadComboBoxData();

    }
    private void LoadComboBoxData()
    {
      try
      {

        // Load Sex data
        string sexQuery = "SELECT SexId, Sex FROM Sex";

        cmbSexo.DisplayMember = "Sex";
        cmbSexo.ValueMember = "SexId";
        cmbSexo.DataSource = db.ExecuteQuery(sexQuery);

        // Load JobTitle data
        string jobQuery = "SELECT JobTitleId, JobTitle FROM JobTitle";
        
        cmbCargo.DisplayMember = "JobTitle";
        cmbCargo.ValueMember = "JobTitleId";
        cmbCargo.DataSource = db.ExecuteQuery(jobQuery);
      }
      catch (Exception ex)
      {
        MessageBox.Show("Erro: " + ex.Message);
      }

    }
    private void btnAddPessoa_Click(object sender, EventArgs e)
    {

      // Verificar se todos os campos estão preenchidos
      if (string.IsNullOrWhiteSpace(txtID.Text) ||
          string.IsNullOrWhiteSpace(txtNome.Text) ||
          string.IsNullOrWhiteSpace(txtSobrenome.Text) ||
          string.IsNullOrWhiteSpace(cmbSexo.Text) ||
          string.IsNullOrWhiteSpace(txtEmail.Text) ||
          string.IsNullOrWhiteSpace(mtxtCelular.Text) ||
          string.IsNullOrWhiteSpace(dtpNacimento.Text) ||
          string.IsNullOrWhiteSpace(cmbCargo.Text))
      {
        MessageBox.Show("Por favor, preencha todos os campos", "Campos obrigatórios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        return;
      }


      // Adicionar à lista
      pessoas.InserirFinal(new Pessoa
      {
        UserID = txtID.Text,
        FirstName = txtNome.Text,
        LastName = txtSobrenome.Text,
        Sex = cmbSexo.Text,
        Email = txtEmail.Text,
        Phone = mtxtCelular.Text,
        DateOfBirth = Convert.ToDateTime(dtpNacimento.Text).ToString("dd/MM/yyyy"),
        JobTitle = cmbCargo.Text,
      });

      // Adicionar ao DataGridView
      dgvPessoa.Rows.Add(txtID.Text, txtNome.Text, txtSobrenome.Text, cmbSexo.Text, txtEmail.Text, mtxtCelular.Text, Convert.ToDateTime(dtpNacimento.Text).ToString("dd/MM/yyyy"), cmbCargo.Text);

      // Inserir dados em uma tabela
      string query = $@"
        INSERT INTO Users (UserId, FirstName, LastName, Sex, Email, Phone, Datebirth, JobTitle) VALUES (
            '{txtID.Text}', 
            '{txtNome.Text}', 
            '{txtSobrenome.Text}', 
            (SELECT SexId FROM Sex WHERE Sex='{cmbSexo.Text}'), 
            '{txtEmail.Text}', 
            '{mtxtCelular.Text}', 
            '{Convert.ToDateTime(dtpNacimento.Text).ToString("yyyy-MM-dd")}', 
            (SELECT JobTitleId FROM JobTitle WHERE JobTitle='{cmbCargo.Text}')
        )";
      db.ExecuteNonQuery(query);

      // Limpar os campos
      txtID.Clear();
      txtNome.Clear();
      txtSobrenome.Clear();
      cmbSexo.SelectedIndex = -1;
      txtEmail.Clear();
      mtxtCelular.Clear();
      dtpNacimento.Value = DateTime.Now;
      cmbCargo.SelectedIndex = -1;

      

      MessageBox.Show("Dados inseridos com sucesso!");

      
     }

    private void btnSearch_Click(object sender, EventArgs e)
    {
      SearchForm formPop = new SearchForm();
      formPop.ShowDialog();

    }

    private void dgvPessoa_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
    {
      string columnName = dgvPessoa.Columns[e.ColumnIndex].Name;
      DataTable table = dgvPessoa.DataSource as DataTable;

      if (table != null)
      {
        if (isAscending)
        {
          table.DefaultView.Sort = columnName + " ASC";
        }
        else
        {
          table.DefaultView.Sort = columnName + " DESC";
        }
        isAscending = !isAscending;
      }
    }
  }
  }

}
