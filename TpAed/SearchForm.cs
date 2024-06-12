using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TpAed
{
  public partial class SearchForm : Form
  {
    public SearchForm()
    {
      InitializeComponent();
    }
    private void btnSearch_Click(object sender, EventArgs e)
    {
      // Implementar lógica de pesquisa
     // string searchQuery = txtSearch.Text;

      // Código para realizar a pesquisa
      //MessageBox.Show("Resultado da pesquisa para: " + searchQuery);
    }

    private void btnCancel_Click(object sender, EventArgs e)
    {
      // Cancelar e fechar o formulário
      this.Close();
    }

    private void SearchForm_Load(object sender, EventArgs e)
    {
      // Inicialização do formulário
      // Qualquer inicialização específica para o formulário pode ser adicionada aqui.
    }

    private void label1_Click(object sender, EventArgs e)
    {

    }

    private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
    {

    }
  }
}
