using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System;
using System.Data;

namespace TpAed
{
  static class Program
  {
    /// <summary>
    /// The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);
      Application.Run(new PessoaForm());
    }

  }
  class ListaDuplaPessoa
  {
    CelulaDupla primeiro, ultimo;
    private int _tamanho;
    public int tamanho { get { return _tamanho; } }

    public ListaDuplaPessoa()
    {
      primeiro = ultimo = new CelulaDupla();
      _tamanho = 0;
    }

    public void InserirFinal(Pessoa x)
    {
      _tamanho++;
      CelulaDupla aux = new CelulaDupla(x);

      if (primeiro.prox == null)
      {
        primeiro.prox = aux;
        ultimo = aux;
        return;
      }

      ultimo.prox = aux;
      aux.ant = ultimo;
      ultimo = ultimo.prox;
    }

    public void InserirInicio(Pessoa x)
    {
      _tamanho++;
      CelulaDupla aux = new CelulaDupla(x);

      aux.prox = primeiro.prox;

      if (primeiro.prox == null) ultimo = aux;
      else primeiro.prox.ant = aux;
      primeiro.prox = aux;
    }

    public Pessoa RemoveFinal()
    {
      if (primeiro.prox == null)
        throw new Exception("Impossivel remover");
      _tamanho--;

      Pessoa elemento = ultimo.elemento;

      if (primeiro.prox == ultimo)
      {
        ultimo = primeiro.prox = null;
        return elemento;
      }

      ultimo = ultimo.ant;
      ultimo.prox = null;
      return elemento;
    }

    public Pessoa RemoveInicio()
    {
      if (primeiro.prox == null)
        throw new Exception("Impossivel remover");

      Pessoa elemento = primeiro.prox.elemento;
      primeiro.prox = primeiro.prox.prox;
      primeiro.ant = null;

      _tamanho--;
      return elemento;
    }

    public void InserirAt(int index, Pessoa x)
    {
      if (index < 0 || index > _tamanho)
        throw new Exception("Tamanho inválido");

      if (index == 0)
      {
        InserirInicio(x);
        return;
      }
      if (index == tamanho)
      {
        InserirFinal(x);
        return;
      }

      CelulaDupla aux1;
      int count;

      if (index <= _tamanho / 2)
      {
        count = 0;
        aux1 = primeiro.prox;
        while (count++ < index - 1)
          aux1 = aux1.prox;
      }
      else
      {
        count = _tamanho - 2;
        aux1 = ultimo.ant;
        while (count-- > index - 1)
          aux1 = aux1.ant;
      }

      CelulaDupla aux2 = aux1.prox;
      aux1.prox = new CelulaDupla(x);
      aux1.prox.ant = aux1;
      aux1.prox.prox = aux2;
      aux2.ant = aux1.prox;
      _tamanho++;
    }

    public Pessoa RemoveAt(int index)
    {
      if (index < 0 || index >= _tamanho)
        throw new Exception("Tamanho inválido");

      if (index == 0) return RemoveInicio();
      if (index == tamanho - 1) return RemoveFinal();

      CelulaDupla aux;
      int count;

      if (index <= _tamanho / 2)
      {
        count = 0;
        aux = primeiro.prox;
        while (count++ < index - 1)
          aux = aux.prox;
      }
      else
      {
        count = _tamanho - 2;
        aux = ultimo.ant;
        while (count-- > index - 1)
          aux = aux.ant;
      }

      Pessoa elemento = aux.prox.elemento;
      aux.prox = aux.prox.prox;
      aux.prox.ant = aux;

      _tamanho--;
      return elemento;
    }

    public void Imprime()
    {
      Console.Write("[ ");
      for (CelulaDupla i = primeiro.prox; i != null; i = i.prox)
        Console.Write(i.elemento.ToString() + ",\n");
      Console.Write("]\n\n");
    }

    public void ImprimeInverso()
    {
      Console.Write("[ ");
      for (CelulaDupla i = ultimo; i != primeiro; i = i.ant)
        Console.Write(i.elemento.ToString() + ",\n");
      Console.Write("]\n\n");
    }
  }

  class CelulaDupla
  {
    public Pessoa elemento;
    public CelulaDupla prox, ant;

    public CelulaDupla() : this(new Pessoa()) { }
    public CelulaDupla(Pessoa x)
    {
      elemento = x;
      ant = prox = null;
    }
  }

  class Pessoa
  {
    public string UserID { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Sex { get; set; }
    public string Email { get; set; }
    public string Phone { get; set; }
    public string DateOfBirth { get; set; }
    public string JobTitle { get; set; }

    public Pessoa() { }
    public Pessoa(
        string userID,
        string firstName,
        string lastName,
        string sex,
        string email,
        string phone,
        string dateOfBirth,
        string jobTitle
        )
    {
      userID = userID;
      firstName = FirstName;
      lastName = LastName;
      sex = Sex;
      email = Email;
      phone = Phone;
      dateOfBirth = DateOfBirth;
      jobTitle = JobTitle;
    }

    public override string ToString()
    {
      return $"{UserID} ## {FirstName} ## {LastName} ## {Sex} ## {Email} ## {Phone} ## {DateOfBirth} ## {JobTitle} ##";
    }
  }

  public class Database
  {
    private MySqlConnection connection;

    // Construtor
    public Database(string server, string database, string username, string password)
    {
      string connectionString = $"Server={server};Database={database};Uid={username};Pwd={password};";
      connection = new MySqlConnection(connectionString);
    }

    // Abrir a conexão
    public void OpenConnection()
    {
      if (connection.State == ConnectionState.Closed)
      {
        connection.Open();
      }
    }

    // Fechar a conexão
    public void CloseConnection()
    {
      if (connection.State == ConnectionState.Open)
      {
        connection.Close();
      }
    }

    // Executar comandos de leitura
    public DataTable ExecuteQuery(string query)
    {
      DataTable dt = new DataTable();
      try
      {
        OpenConnection();
        MySqlCommand cmd = new MySqlCommand(query, connection);
        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
        da.Fill(dt);
      }
      catch (Exception ex)
      {
        Console.WriteLine(ex.Message);
      }
      finally
      {
        CloseConnection();
      }
      return dt;
    }

    // Executar comandos de escrita
    public void ExecuteNonQuery(string query)
    {
      try
      {
        OpenConnection();
        MySqlCommand cmd = new MySqlCommand(query, connection);
        cmd.ExecuteNonQuery();
      }
      catch (Exception ex)
      {
        Console.WriteLine(ex.Message);
      }
      finally
      {
        CloseConnection();
      }
    }
  }

}
