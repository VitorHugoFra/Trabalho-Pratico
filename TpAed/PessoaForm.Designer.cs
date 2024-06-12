
namespace TpAed
{
  partial class PessoaForm
  {
    private System.ComponentModel.IContainer components = null;
    private System.Windows.Forms.TextBox txtID;
    private System.Windows.Forms.TextBox txtNome;
    private System.Windows.Forms.TextBox txtSobrenome;
    private System.Windows.Forms.Button btnEdit;
    private System.Windows.Forms.Button btnCancel;

    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PessoaForm));
      this.txtID = new System.Windows.Forms.TextBox();
      this.txtNome = new System.Windows.Forms.TextBox();
      this.txtSobrenome = new System.Windows.Forms.TextBox();
      this.dgvPessoa = new System.Windows.Forms.DataGridView();
      this.USERID = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.NOME = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.SOBRENOME = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.SEXO = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.EMAIL = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.CELULAR = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.DATAN = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.CARGO = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.txtEmail = new System.Windows.Forms.TextBox();
      this.cmbSexo = new System.Windows.Forms.ComboBox();
      this.cmbCargo = new System.Windows.Forms.ComboBox();
      this.btnSearch = new System.Windows.Forms.Button();
      this.btnCancel = new System.Windows.Forms.Button();
      this.btnEdit = new System.Windows.Forms.Button();
      this.btnAddPessoa = new System.Windows.Forms.Button();
      this.dtpNacimento = new System.Windows.Forms.DateTimePicker();
      this.lblId = new System.Windows.Forms.Label();
      this.lblNome = new System.Windows.Forms.Label();
      this.lblSobrenome = new System.Windows.Forms.Label();
      this.lblSex = new System.Windows.Forms.Label();
      this.lblCargo = new System.Windows.Forms.Label();
      this.lblData = new System.Windows.Forms.Label();
      this.lblCelular = new System.Windows.Forms.Label();
      this.lblEmail = new System.Windows.Forms.Label();
      this.mtxtCelular = new System.Windows.Forms.MaskedTextBox();
      this.label1 = new System.Windows.Forms.Label();
      ((System.ComponentModel.ISupportInitialize)(this.dgvPessoa)).BeginInit();
      this.SuspendLayout();
      // 
      // txtID
      // 
      this.txtID.Location = new System.Drawing.Point(84, 16);
      this.txtID.Name = "txtID";
      this.txtID.Size = new System.Drawing.Size(260, 20);
      this.txtID.TabIndex = 0;
      // 
      // txtNome
      // 
      this.txtNome.Location = new System.Drawing.Point(84, 42);
      this.txtNome.Name = "txtNome";
      this.txtNome.Size = new System.Drawing.Size(260, 20);
      this.txtNome.TabIndex = 1;
      // 
      // txtSobrenome
      // 
      this.txtSobrenome.Location = new System.Drawing.Point(84, 68);
      this.txtSobrenome.Name = "txtSobrenome";
      this.txtSobrenome.Size = new System.Drawing.Size(260, 20);
      this.txtSobrenome.TabIndex = 2;
      // 
      // dgvPessoa
      // 
      this.dgvPessoa.AllowUserToAddRows = false;
      this.dgvPessoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgvPessoa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.USERID,
            this.NOME,
            this.SOBRENOME,
            this.SEXO,
            this.EMAIL,
            this.CELULAR,
            this.DATAN,
            this.CARGO});
      this.dgvPessoa.Location = new System.Drawing.Point(12, 186);
      this.dgvPessoa.Name = "dgvPessoa";
      this.dgvPessoa.Size = new System.Drawing.Size(773, 236);
      this.dgvPessoa.TabIndex = 5;
      this.dgvPessoa.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvPessoa_ColumnHeaderMouseClick);
      // 
      // USERID
      // 
      this.USERID.HeaderText = "ID";
      this.USERID.Name = "USERID";
      this.USERID.Width = 50;
      // 
      // NOME
      // 
      this.NOME.HeaderText = "Nome";
      this.NOME.Name = "NOME";
      // 
      // SOBRENOME
      // 
      this.SOBRENOME.HeaderText = "Sobrenome";
      this.SOBRENOME.Name = "SOBRENOME";
      // 
      // SEXO
      // 
      this.SEXO.HeaderText = "Sexo";
      this.SEXO.Name = "SEXO";
      this.SEXO.Width = 80;
      // 
      // EMAIL
      // 
      this.EMAIL.HeaderText = "Email";
      this.EMAIL.Name = "EMAIL";
      // 
      // CELULAR
      // 
      this.CELULAR.HeaderText = "Celular";
      this.CELULAR.Name = "CELULAR";
      // 
      // DATAN
      // 
      this.DATAN.HeaderText = "Data Nasc.";
      this.DATAN.Name = "DATAN";
      // 
      // CARGO
      // 
      this.CARGO.HeaderText = "Cargo";
      this.CARGO.Name = "CARGO";
      // 
      // txtEmail
      // 
      this.txtEmail.Location = new System.Drawing.Point(425, 16);
      this.txtEmail.Name = "txtEmail";
      this.txtEmail.Size = new System.Drawing.Size(260, 20);
      this.txtEmail.TabIndex = 11;
      // 
      // cmbSexo
      // 
      this.cmbSexo.FormattingEnabled = true;
      this.cmbSexo.Location = new System.Drawing.Point(84, 97);
      this.cmbSexo.Name = "cmbSexo";
      this.cmbSexo.Size = new System.Drawing.Size(260, 21);
      this.cmbSexo.TabIndex = 12;
      // 
      // cmbCargo
      // 
      this.cmbCargo.FormattingEnabled = true;
      this.cmbCargo.Location = new System.Drawing.Point(425, 97);
      this.cmbCargo.Name = "cmbCargo";
      this.cmbCargo.Size = new System.Drawing.Size(260, 21);
      this.cmbCargo.TabIndex = 13;
      // 
      // btnSearch
      // 
      this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
      this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnSearch.ForeColor = System.Drawing.SystemColors.Control;
      this.btnSearch.Image = global::TpAed.Properties.Resources._1;
      this.btnSearch.Location = new System.Drawing.Point(743, 150);
      this.btnSearch.Name = "btnSearch";
      this.btnSearch.Size = new System.Drawing.Size(32, 29);
      this.btnSearch.TabIndex = 6;
      this.btnSearch.UseMnemonic = false;
      this.btnSearch.UseVisualStyleBackColor = false;
      this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
      // 
      // btnCancel
      // 
      this.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
      this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnCancel.ForeColor = System.Drawing.SystemColors.Control;
      this.btnCancel.Image = global::TpAed.Properties.Resources.lixo__1_;
      this.btnCancel.Location = new System.Drawing.Point(705, 150);
      this.btnCancel.Name = "btnCancel";
      this.btnCancel.Size = new System.Drawing.Size(32, 29);
      this.btnCancel.TabIndex = 4;
      this.btnCancel.UseMnemonic = false;
      this.btnCancel.UseVisualStyleBackColor = false;
      this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
      // 
      // btnEdit
      // 
      this.btnEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
      this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnEdit.ForeColor = System.Drawing.SystemColors.Control;
      this.btnEdit.Image = global::TpAed.Properties.Resources.editar;
      this.btnEdit.Location = new System.Drawing.Point(667, 149);
      this.btnEdit.Name = "btnEdit";
      this.btnEdit.Size = new System.Drawing.Size(32, 29);
      this.btnEdit.TabIndex = 3;
      this.btnEdit.UseMnemonic = false;
      this.btnEdit.UseVisualStyleBackColor = false;
      // 
      // btnAddPessoa
      // 
      this.btnAddPessoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
      this.btnAddPessoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnAddPessoa.ForeColor = System.Drawing.SystemColors.Control;
      this.btnAddPessoa.Image = global::TpAed.Properties.Resources.adicionar_usuario;
      this.btnAddPessoa.Location = new System.Drawing.Point(625, 149);
      this.btnAddPessoa.Name = "btnAddPessoa";
      this.btnAddPessoa.Size = new System.Drawing.Size(32, 29);
      this.btnAddPessoa.TabIndex = 7;
      this.btnAddPessoa.UseMnemonic = false;
      this.btnAddPessoa.UseVisualStyleBackColor = false;
      this.btnAddPessoa.Click += new System.EventHandler(this.btnAddPessoa_Click);
      // 
      // dtpNacimento
      // 
      this.dtpNacimento.Location = new System.Drawing.Point(425, 68);
      this.dtpNacimento.Name = "dtpNacimento";
      this.dtpNacimento.Size = new System.Drawing.Size(260, 20);
      this.dtpNacimento.TabIndex = 14;
      // 
      // lblId
      // 
      this.lblId.AutoSize = true;
      this.lblId.Location = new System.Drawing.Point(23, 19);
      this.lblId.Name = "lblId";
      this.lblId.Size = new System.Drawing.Size(18, 13);
      this.lblId.TabIndex = 15;
      this.lblId.Text = "ID";
      // 
      // lblNome
      // 
      this.lblNome.AutoSize = true;
      this.lblNome.Location = new System.Drawing.Point(23, 45);
      this.lblNome.Name = "lblNome";
      this.lblNome.Size = new System.Drawing.Size(35, 13);
      this.lblNome.TabIndex = 16;
      this.lblNome.Text = "Nome";
      // 
      // lblSobrenome
      // 
      this.lblSobrenome.AutoSize = true;
      this.lblSobrenome.Location = new System.Drawing.Point(23, 71);
      this.lblSobrenome.Name = "lblSobrenome";
      this.lblSobrenome.Size = new System.Drawing.Size(61, 13);
      this.lblSobrenome.TabIndex = 17;
      this.lblSobrenome.Text = "Sobrenome";
      // 
      // lblSex
      // 
      this.lblSex.AutoSize = true;
      this.lblSex.Location = new System.Drawing.Point(23, 100);
      this.lblSex.Name = "lblSex";
      this.lblSex.Size = new System.Drawing.Size(31, 13);
      this.lblSex.TabIndex = 18;
      this.lblSex.Text = "Sexo";
      // 
      // lblCargo
      // 
      this.lblCargo.AutoSize = true;
      this.lblCargo.Location = new System.Drawing.Point(360, 100);
      this.lblCargo.Name = "lblCargo";
      this.lblCargo.Size = new System.Drawing.Size(35, 13);
      this.lblCargo.TabIndex = 22;
      this.lblCargo.Text = "Cargo";
      // 
      // lblData
      // 
      this.lblData.AutoSize = true;
      this.lblData.Location = new System.Drawing.Point(360, 71);
      this.lblData.Name = "lblData";
      this.lblData.Size = new System.Drawing.Size(64, 13);
      this.lblData.TabIndex = 21;
      this.lblData.Text = "Data  Nasc.";
      // 
      // lblCelular
      // 
      this.lblCelular.AutoSize = true;
      this.lblCelular.Location = new System.Drawing.Point(360, 45);
      this.lblCelular.Name = "lblCelular";
      this.lblCelular.Size = new System.Drawing.Size(39, 13);
      this.lblCelular.TabIndex = 20;
      this.lblCelular.Text = "Celular";
      // 
      // lblEmail
      // 
      this.lblEmail.AutoSize = true;
      this.lblEmail.Location = new System.Drawing.Point(360, 19);
      this.lblEmail.Name = "lblEmail";
      this.lblEmail.Size = new System.Drawing.Size(32, 13);
      this.lblEmail.TabIndex = 19;
      this.lblEmail.Text = "Email";
      // 
      // mtxtCelular
      // 
      this.mtxtCelular.Location = new System.Drawing.Point(425, 42);
      this.mtxtCelular.Mask = "(99) 99999-9999";
      this.mtxtCelular.Name = "mtxtCelular";
      this.mtxtCelular.Size = new System.Drawing.Size(260, 20);
      this.mtxtCelular.TabIndex = 23;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
      this.label1.Location = new System.Drawing.Point(684, 425);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(101, 13);
      this.label1.TabIndex = 24;
      this.label1.Text = "Bene, Breno, Vitor®";
      // 
      // PessoaForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(810, 447);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.mtxtCelular);
      this.Controls.Add(this.lblCargo);
      this.Controls.Add(this.lblData);
      this.Controls.Add(this.lblCelular);
      this.Controls.Add(this.lblEmail);
      this.Controls.Add(this.lblSex);
      this.Controls.Add(this.lblSobrenome);
      this.Controls.Add(this.lblNome);
      this.Controls.Add(this.lblId);
      this.Controls.Add(this.dtpNacimento);
      this.Controls.Add(this.cmbCargo);
      this.Controls.Add(this.cmbSexo);
      this.Controls.Add(this.txtEmail);
      this.Controls.Add(this.btnAddPessoa);
      this.Controls.Add(this.btnSearch);
      this.Controls.Add(this.dgvPessoa);
      this.Controls.Add(this.btnCancel);
      this.Controls.Add(this.btnEdit);
      this.Controls.Add(this.txtSobrenome);
      this.Controls.Add(this.txtNome);
      this.Controls.Add(this.txtID);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Name = "PessoaForm";
      this.Text = "Gerenciamento de Pessoas";
      this.Load += new System.EventHandler(this.PessoaForm_Load);
      ((System.ComponentModel.ISupportInitialize)(this.dgvPessoa)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    private System.Windows.Forms.DataGridView dgvPessoa;
    private System.Windows.Forms.Button btnSearch;
    private System.Windows.Forms.TextBox txtEmail;
    private System.Windows.Forms.ComboBox cmbSexo;
    private System.Windows.Forms.ComboBox cmbCargo;
    private System.Windows.Forms.Button btnAddPessoa;
    private System.Windows.Forms.DateTimePicker dtpNacimento;
    private System.Windows.Forms.Label lblId;
    private System.Windows.Forms.Label lblNome;
    private System.Windows.Forms.Label lblSobrenome;
    private System.Windows.Forms.Label lblSex;
    private System.Windows.Forms.Label lblCargo;
    private System.Windows.Forms.Label lblData;
    private System.Windows.Forms.Label lblCelular;
    private System.Windows.Forms.Label lblEmail;
    private System.Windows.Forms.MaskedTextBox mtxtCelular;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.DataGridViewTextBoxColumn USERID;
    private System.Windows.Forms.DataGridViewTextBoxColumn NOME;
    private System.Windows.Forms.DataGridViewTextBoxColumn SOBRENOME;
    private System.Windows.Forms.DataGridViewTextBoxColumn SEXO;
    private System.Windows.Forms.DataGridViewTextBoxColumn EMAIL;
    private System.Windows.Forms.DataGridViewTextBoxColumn CELULAR;
    private System.Windows.Forms.DataGridViewTextBoxColumn DATAN;
    private System.Windows.Forms.DataGridViewTextBoxColumn CARGO;
  }
}

