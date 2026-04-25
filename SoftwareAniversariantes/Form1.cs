using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Runtime.Remoting;
using SQLitePCL;
using System.Linq.Expressions;

namespace SoftwareAniversariantes
{
    public partial class Form1 : Form
    {
        private readonly string _dbPath = System.IO.Path.Combine(Application.StartupPath, "bancodedados.db");
        private string DbConnectionString => "Data Source=" + _dbPath + ";Version=3;";

        public Form1()
        {
            InitializeComponent();
            ApplyVisualTheme();
        }

        private void ApplyVisualTheme()
        {
            const string fontName = "Segoe UI";
            var fontBase = new Font(fontName, 9F, FontStyle.Regular);
            var bg = Color.FromArgb(248, 250, 252);
            var surface = Color.White;
            var border = Color.FromArgb(226, 232, 240);
            var textMain = Color.FromArgb(15, 23, 42);
            var textMuted = Color.FromArgb(100, 116, 139);
            var accent = Color.FromArgb(37, 99, 235);
            var accentDark = Color.FromArgb(29, 78, 216);

            Font = fontBase;
            BackColor = bg;
            ForeColor = textMain;
            Text = "Aniversariantes";
            StartPosition = FormStartPosition.CenterScreen;
            MinimumSize = new Size(820, 520);

            tabControl1.BackColor = bg;
            foreach (TabPage tp in tabControl1.TabPages)
            {
                tp.BackColor = bg;
            }

            SetChildFontsExceptGrid(this, fontBase);

            void StylePrimary(Button b)
            {
                b.UseVisualStyleBackColor = false;
                b.FlatStyle = FlatStyle.Flat;
                b.FlatAppearance.BorderSize = 0;
                b.BackColor = accent;
                b.ForeColor = Color.White;
                b.Cursor = Cursors.Hand;
                b.FlatAppearance.MouseOverBackColor = accentDark;
                if (b.Height < 32) b.Height = 32;
            }

            void StyleSecondary(Button b)
            {
                b.UseVisualStyleBackColor = false;
                b.FlatStyle = FlatStyle.Flat;
                b.FlatAppearance.BorderSize = 1;
                b.FlatAppearance.BorderColor = border;
                b.BackColor = surface;
                b.ForeColor = Color.FromArgb(51, 65, 85);
                b.Cursor = Cursors.Hand;
                b.FlatAppearance.MouseOverBackColor = Color.FromArgb(241, 245, 249);
                if (b.Height < 30) b.Height = 30;
            }

            StylePrimary(btnSalvarComunidade);
            StylePrimary(btnFiltrarAniversariantes);
            StylePrimary(btnPgCadastro);
            StyleSecondary(btnPgRelatorios);
            StyleSecondary(btnPgInicio);
            StyleSecondary(btnPgRelatorios1);
            StyleSecondary(btnPgInicioRelatorio);

            btnAdicionarComunidade.UseVisualStyleBackColor = false;
            btnAdicionarComunidade.FlatStyle = FlatStyle.Flat;
            btnAdicionarComunidade.FlatAppearance.BorderSize = 0;
            btnAdicionarComunidade.BackColor = accent;
            btnAdicionarComunidade.ForeColor = Color.White;
            btnAdicionarComunidade.Size = new Size(40, 30);
            btnAdicionarComunidade.Font = new Font(fontName, 11F, FontStyle.Bold);
            btnAdicionarComunidade.Cursor = Cursors.Hand;
            btnAdicionarComunidade.FlatAppearance.MouseOverBackColor = accentDark;

            StyleSecondary(btn_SalvarComunidade);
            btn_SalvarComunidade.Size = new Size(168, 30);

            panelComunidade.BackColor = surface;
            panelComunidade.BorderStyle = BorderStyle.FixedSingle;
            panel1.BackColor = surface;
            panel1.BorderStyle = BorderStyle.FixedSingle;

            label2.Font = new Font(fontName, 9F, FontStyle.Bold);
            label2.ForeColor = textMain;
            lblCadastroTitulo.Font = new Font(fontName, 12F, FontStyle.Bold);
            lblCadastroTitulo.ForeColor = textMain;
            foreach (var lbl in new Control[] { label1, lblFieldComunidade, lblDataNascimento, lblDataFalecimento })
            {
                lbl.ForeColor = textMuted;
            }
            lblStatus.ForeColor = accent;
            var fontInput = new Font(fontName, 10F);
            txtNome.Font = fontInput;
            txtComunidade.Font = fontInput;
            dtpNascimento.Font = fontInput;
            dtpFalecimento.Font = fontInput;

            dgvRelatorio.BorderStyle = BorderStyle.None;
            dgvRelatorio.BackgroundColor = surface;
            dgvRelatorio.GridColor = border;
            dgvRelatorio.EnableHeadersVisualStyles = false;
            dgvRelatorio.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(241, 245, 249);
            dgvRelatorio.ColumnHeadersDefaultCellStyle.ForeColor = textMain;
            dgvRelatorio.ColumnHeadersDefaultCellStyle.Font = new Font(fontName, 9F, FontStyle.Bold);
            dgvRelatorio.ColumnHeadersHeight = 36;
            dgvRelatorio.RowHeadersVisible = false;
            dgvRelatorio.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(249, 250, 251);
            dgvRelatorio.DefaultCellStyle.SelectionBackColor = Color.FromArgb(219, 234, 254);
            dgvRelatorio.DefaultCellStyle.SelectionForeColor = textMain;
            dgvRelatorio.RowTemplate.Height = 28;
            dgvRelatorio.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;

            var lblHero = new Label
            {
                Text = "Aniversariantes",
                Font = new Font(fontName, 22F, FontStyle.Bold),
                ForeColor = textMain,
                AutoSize = true,
                Location = new Point(48, 48),
                BackColor = Color.Transparent
            };
            var lblHeroSub = new Label
            {
                Text = "Cadastro de moradores e consulta por mês de aniversário",
                Font = new Font(fontName, 10F),
                ForeColor = textMuted,
                AutoSize = true,
                Location = new Point(50, 98),
                BackColor = Color.Transparent
            };
            TabPage1Inicial.Controls.Add(lblHero);
            TabPage1Inicial.Controls.Add(lblHeroSub);
            lblHero.BringToFront();
            lblHeroSub.BringToFront();
            btnPgCadastro.BringToFront();
            btnPgRelatorios.BringToFront();
        }

        private static void SetChildFontsExceptGrid(Control parent, Font font)
        {
            foreach (Control c in parent.Controls)
            {
                if (c is DataGridView)
                    continue;
                c.Font = font;
                if (c.HasChildren)
                    SetChildFontsExceptGrid(c, font);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            EnsureDatabase();
            LoadComunidadesFromDb();
            LoadCidadesFromDb();
            LoadEstadosFromDb();
            cbMesFiltro.SelectedIndex = Math.Max(0, DateTime.Now.Month - 1);
            dtpFiltroDataAniversario.Value = DateTime.Today;
            AtualizarEstadoFiltroRelatorio();
        }

        private void AtualizarEstadoFiltroRelatorio()
        {
            bool porMes = rbFiltroPorMes.Checked;
            cbMesFiltro.Enabled = porMes;
            dtpFiltroDataAniversario.Enabled = !porMes;
        }

        private void rbFiltroRelatorio_CheckedChanged(object sender, EventArgs e)
        {
            AtualizarEstadoFiltroRelatorio();
        }

        private string NomeMesDoCombo(int mes1a12)
        {
            if (mes1a12 >= 1 && mes1a12 <= 12 && cbMesFiltro.Items.Count >= mes1a12)
                return cbMesFiltro.Items[mes1a12 - 1].ToString();
            return CultureInfo.GetCultureInfo("pt-BR").DateTimeFormat.GetMonthName(mes1a12).ToUpperInvariant();
        }

        private void EnsureDatabase()
        {
            using (var con = new SQLiteConnection(DbConnectionString))
            {
                con.Open();
                using (var cmd = con.CreateCommand())
                {
                    cmd.CommandText = @"CREATE TABLE IF NOT EXISTS Comunidade (
                                        id INTEGER PRIMARY KEY AUTOINCREMENT,
                                        txtNome TEXT,
                                        txtEstado TEXT NOT NULL,
                                        txtCidade TEXT NOT NULL,
                                        txtComunidade TEXT);";
                    cmd.ExecuteNonQuery();
                    cmd.CommandText =   @"CREATE TABLE IF NOT EXISTS Moradores (
                                        id INTEGER PRIMARY KEY AUTOINCREMENT,
                                        nome TEXT NOT NULL,
                                        comunidade TEXT NOT NULL,
                                        data_nascimento TEXT NOT NULL,
                                        ano_impreciso INTEGER NOT NULL DEFAULT 0,
                                        vivo INTEGER NOT NULL DEFAULT 1,
                                        data_falecimento TEXT,
                                        data_falecimento_desconhecida INTEGER NOT NULL DEFAULT 0);";
                    cmd.ExecuteNonQuery();
                    cmd.CommandText = @"CREATE TABLE IF NOT EXISTS Cidade (
                                        id INTEGER PRIMARY KEY AUTOINCREMENT,
                                        txtCidade TEXT);";
                    cmd.ExecuteNonQuery();
                    cmd.CommandText = @"CREATE TABLE IF NOT EXISTS Estado (
                                        id INTEGER PRIMARY KEY AUTOINCREMENT,
                                        txtEstado TEXT);";
                    cmd.ExecuteNonQuery();

                }
            }
        }

        private void LoadComunidadesFromDb()
        {
            txtComunidade.Items.Clear();
            using (var con = new SQLiteConnection(DbConnectionString))
            {
                con.Open();
                using (var cmd = con.CreateCommand())
                {
                    cmd.CommandText = "SELECT txtComunidade FROM Comunidade ORDER BY txtComunidade";
                    using (var r = cmd.ExecuteReader())
                    {
                        while (r.Read())
                        {
                            if (!r.IsDBNull(0))
                                txtComunidade.Items.Add(r.GetString(0));
                        }
                    }
                }
            }
        }

        private void LoadCidadesFromDb()
        {
            txtCidade.Items.Clear();
            using (var con = new SQLiteConnection(DbConnectionString))
            {
                con.Open();
                using (var cmd = con.CreateCommand())
                {
                    cmd.CommandText = "SELECT txtCidade FROM Cidade ORDER BY txtCidade";

                    using (var r = cmd.ExecuteReader())
                    {
                        while (r.Read())
                        {
                            if (!r.IsDBNull(0))
                            {
                                txtCidade.Items.Add(r.GetString(0));
                            }
                        }
                    }
                }

            }
            
        }

        private void LoadEstadosFromDb()
        {
            txtEstado.Items.Clear();
            using (var con = new SQLiteConnection(DbConnectionString))
                {
                con.Open();
                    using (var cmd = con.CreateCommand())
                    {
                        cmd.CommandText = "SELECT txtEstado From Estado ORDER BY txtEstado";

                        using (var r = cmd.ExecuteReader())
                        {
                            while (r.Read())
                                if (!r.IsDBNull(0))
                                {
                                    txtEstado.Items.Add(r.GetString(0));
                                }
                        }
                    }
                }
        }
               

private void chkVivo_CheckedChanged(object sender, EventArgs e)
{
 dtpFalecimento.Enabled = !chkVivo.Checked;

 if (chkVivo.Checked) {
     lblStatus.Text = "Status: Ativo";
     chkDataFalecimentoDesconhecida.Enabled = false;
     chkDataFalecimentoDesconhecida.Checked = true;


 }
 else {
     lblStatus.Text = "Status: Falecido";
     chkDataFalecimentoDesconhecida.Enabled = true;
     chkDataFalecimentoDesconhecida.Checked = false;
            }
 }

        private void btnNovoCadastroReset(object sender, EventArgs e)
        {

            txtCodigo.Text = GetNextAvailableCode().ToString();

            LimparCampos();
            SetFieldsStatus(true);
                     
            txtNome.Focus();
            /*try
            {
                LimparCampos();
                SetFieldsStatus(true);

                int codigoSugerido = GetNextAvailableCode();

                // TESTE DE LOGICA: Isso vai abrir uma mensagem dizendo o número que ele achou
                MessageBox.Show("O sistema encontrou o código: " + codigoSugerido);

                // TESTE DE EXIBIÇÃO: Tenta enviar para a tela
                this.txtCodigo.Text = codigoSugerido.ToString();

                // Força a atualização visual do componente
                this.txtCodigo.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao gerar código: " + ex.Message);
            }
            */
        }


        
private void btnSalvar_Click(object sender, EventArgs e)
{
         if (txtComunidade.SelectedIndex == -1)
         {
             MessageBox.Show("Por Favor, Selecione uma comunidade!", "Campo Obrigatorio");
             txtComunidade.Focus();
             return;
         }
 string comunidadeSelecionada = txtComunidade.SelectedItem.ToString();

         if (!chkVivo.Checked && !chkDataFalecimentoDesconhecida.Checked)
         {
             if (dtpFalecimento.Value > DateTime.Now)
             {
                 MessageBox.Show("A data de falecimento não pode ser no futuro!");
                 return;
             }
         }

         if (string.IsNullOrWhiteSpace(txtNome.Text))
         {
             MessageBox.Show("O campo Nome é obrigatorio!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
             txtNome.Focus();
             return;
         }

         if (!chkVivo.Checked && !chkDataFalecimentoDesconhecida.Checked)
         {
             if (dtpFalecimento.Value < dtpNascimento.Value)
             {
                 MessageBox.Show("A data de falecimento não pode ser antes da data de nascimento!", "Erro de Lógica");
                 return;
             }
         }

         try
         {
             InsertMorador(comunidadeSelecionada);
             string status = chkVivo.Checked ? "Vivo" : "Falecido";
             MessageBox.Show("Cadastro salvo no banco de dados! Status: " + status + ".", "Cadastro");
             EnabledButtons();
             SetFieldsStatus(false);
          }
 catch (Exception ex)
 {
     MessageBox.Show("Erro ao salvar: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
 }
}


private void InsertMorador(string comunidadeSelecionada)
{
    string dataNasc = dtpNascimento.Value.ToString("yyyy-MM-dd");
    int anoImpreciso = chkAnoImpreciso.Checked ? 1 : 0;
    int vivo = chkVivo.Checked ? 1 : 0;
    int falecDesconhecida = chkDataFalecimentoDesconhecida.Checked ? 1 : 0;
    object dataFalec = DBNull.Value;

            int idManual = int.Parse(txtCodigo.Text);// Pega o código que o sistema sugeriu
            /*if (!int.TryParse(txtCodigo.Text,out idManual))
                {
                MessageBox.Show("O codigo do morador é invalido ou está vazio", "Erro de formato");
                    return;
                }
            */


            if (!chkVivo.Checked && !chkDataFalecimentoDesconhecida.Checked)
        dataFalec = dtpFalecimento.Value.ToString("yyyy-MM-dd");

    using (var con = new SQLiteConnection(DbConnectionString))
    {
        con.Open();
        using (var cmd = con.CreateCommand())
        {
            cmd.CommandText = @"INSERT INTO Moradores (id, nome, comunidade, data_nascimento, ano_impreciso, vivo, data_falecimento, data_falecimento_desconhecida)
VALUES (@id, @nome, @comunidade, @data_nasc, @ano_impreciso, @vivo, @data_falec, @falec_desc)";
            
            cmd.Parameters.AddWithValue("@id", idManual); // Enviamos o ID escolhido
            cmd.Parameters.AddWithValue("@nome", txtNome.Text.Trim());
            cmd.Parameters.AddWithValue("@comunidade", comunidadeSelecionada);
            cmd.Parameters.AddWithValue("@data_nasc", dataNasc);
            cmd.Parameters.AddWithValue("@ano_impreciso", anoImpreciso);
            cmd.Parameters.AddWithValue("@vivo", vivo);
            cmd.Parameters.AddWithValue("@data_falec", dataFalec);
            cmd.Parameters.AddWithValue("@falec_desc", falecDesconhecida);
            cmd.ExecuteNonQuery();
        }
    }
}

private int GetNextAvailableCode()
        {
            using (var con = new SQLiteConnection(DbConnectionString))
            {
                con.Open();
                using (var cmd = con.CreateCommand())
                {
                    // Busca o menor ID vago. Se não houver moradores, começa do 1.
                    cmd.CommandText = @"
                SELECT CASE 
                    WHEN NOT EXISTS (SELECT 1 FROM Moradores) THEN 1
                    ELSE (SELECT MIN(id + 1) FROM Moradores t1 
                          WHERE NOT EXISTS (SELECT 1 FROM Moradores t2 WHERE t2.id = t1.id + 1))
                END";

                    object result = cmd.ExecuteScalar();
                    return (result == null || result == DBNull.Value) ? 1 : Convert.ToInt32(result);
                }
            }

            /* using (var con = new SQLiteConnection(DbConnectionString))
            { 
                con.Open();
                using (var cmd = con.CreateCommand())
                {// Esta lógica SQL procura o menor ID onde o (ID + 1) não existe.
                    // Se a tabela estiver vazia, retorna 1.
                cmd.CommandText = @"
                    SELECT CASE
                       WHEN NOT EXISTS (SELECT 1 FROM Moradores) THEN 1
                    ELSE (SELECT MIN(id + 1) FROM Moradores t1 
                          WHERE NOT EXISTS (SELECT 1 FROM Moradores t2 WHERE t2.id = t1.id + 1))
                        END";

                    object result = cmd.ExecuteScalar();
                    return (result == null || result == DBNull.Value) ? 1 : Convert.ToInt32(result);

                }                          
            }*/
        }

private void SetFieldsStatus(bool status)
        {
            txtNome.Enabled = status;
            txtComunidade.Enabled = status;
            dtpFalecimento.Enabled = status;
            dtpNascimento.Enabled = status;
            chkVivo.Enabled = status;
            chkDataFalecimentoDesconhecida.Enabled = status;
            chkAnoImpreciso.Enabled = status;
            
            //Disable the save button

            btnSalvarComunidade.Enabled = status;
            btnSalvarComunidade.Text = status ? "Salvar Cadastro" : "Já Salvo";
            btnSalvarComunidade.BackColor = status ? Color.Green : Color.Gray;

            btnAdicionarComunidade.Enabled = status;
            btnAdicionarComunidade.BackColor = status ? Color.Green : Color.Gray;

            btnCancelar.Enabled = status;
            btnCancelar.Visible = status;

        }


private void EnabledButtons()
        {
            btnNovoCadastro.Enabled = true;
            btnEditarCadastro.Enabled = true;    
            btnNovoCadastro.Visible = true;
            btnEditarCadastro.Visible = true;
        
        }
private void LimparCampos()
        {
         txtNome.Clear();
         txtComunidade.SelectedIndex= -1;// Reseta a seleção
         dtpNascimento.Value = DateTime.Now;
         chkVivo.Checked = true; //Volta para o padrão Vivo
         chkAnoImpreciso.Checked = false;
         chkDataFalecimentoDesconhecida.Checked = false;
         dtpFalecimento.Value = DateTime.Now;
         txtNome.Focus(); //Deixa o cursor pronto para o próximo nome
        }





private void chkDataFalecimentoDesconhecida_CheckedChanged(object sender, EventArgs e)
{
 //Se a data é desconhecida, desabilita o seletor de data
 //Se não e desconhecida , Habilita (desde que a pessoa esteja marcada como 'Morta')
 
 if (chkDataFalecimentoDesconhecida.Checked)
 {
     dtpFalecimento.Enabled = false;
 }
 else if(!chkVivo.Checked) // Só reabilita se a pessoa estiver marcada como falecida
 {
     dtpFalecimento.Enabled = true;
     
 }
}



private void btnPgCadastro_Click(object sender, EventArgs e)
{
 // O número 1 é a segunda aba (o C# começa a contar do 0)
            tabControl1.SelectedIndex = 1;
            txtCodigo.Text = GetNextAvailableCode().ToString();
            LimparCampos();
            SetFieldsStatus(true);
            txtNome.Focus();
}

private void btnPgRelatorios_Click(object sender, EventArgs e)
{
 tabControl1.SelectedIndex = 2;
 AplicarFiltroRelatorio(false);
}

private void btnPgRelatorio1_Click(object sender, EventArgs e)
{
 tabControl1.SelectedIndex = 2;
 AplicarFiltroRelatorio(false);
}

private void btnPgInicio_Click(object sender, EventArgs e)
{
 tabControl1.SelectedIndex = 0;
}

private void btnFiltrarAniversariantes_Click(object sender, EventArgs e)
{
 AplicarFiltroRelatorio(true);
}

private void AplicarFiltroRelatorio(bool mostrarResumo)
{
 dgvRelatorio.Columns.Clear();
 dgvRelatorio.Rows.Clear();

 dgvRelatorio.Columns.Add("colNome", "Nome");
 dgvRelatorio.Columns.Add("colDia", "Dia");
 dgvRelatorio.Columns.Add("colComunidade", "Comunidade");

 bool porMes = rbFiltroPorMes.Checked;
 int mesNumero;
 int? diaFiltro = null;
 string mesRotuloLista;

 if (porMes)
 {
     if (cbMesFiltro.SelectedIndex == -1)
     {
         MessageBox.Show("Por favor, selecione um mês para filtrar.");
         return;
     }
     mesRotuloLista = cbMesFiltro.SelectedItem.ToString();
     mesNumero = cbMesFiltro.SelectedIndex + 1;
 }
 else
 {
     var dRef = dtpFiltroDataAniversario.Value.Date;
     mesNumero = dRef.Month;
     diaFiltro = dRef.Day;
     mesRotuloLista = NomeMesDoCombo(mesNumero);
 }

 try
 {
     using (var con = new SQLiteConnection(DbConnectionString))
     {
         con.Open();
         using (var cmd = con.CreateCommand())
         {
             if (diaFiltro.HasValue)
             {
                 cmd.CommandText = @"SELECT nome, comunidade, data_nascimento FROM Moradores
WHERE CAST(strftime('%m', data_nascimento) AS INTEGER) = @mes
  AND CAST(strftime('%d', data_nascimento) AS INTEGER) = @dia
ORDER BY nome";
                 cmd.Parameters.AddWithValue("@mes", mesNumero);
                 cmd.Parameters.AddWithValue("@dia", diaFiltro.Value);
             }
             else
             {
                 cmd.CommandText = @"SELECT nome, comunidade, data_nascimento FROM Moradores
WHERE CAST(strftime('%m', data_nascimento) AS INTEGER) = @mes
ORDER BY CAST(strftime('%d', data_nascimento) AS INTEGER), nome";
                 cmd.Parameters.AddWithValue("@mes", mesNumero);
             }
             using (var r = cmd.ExecuteReader())
             {
                 while (r.Read())
                 {
                     string nome = r.GetString(0);
                     string comunidade = r.GetString(1);
                     string dataNascStr = r.GetString(2);
                     DateTime dn;
                     if (!DateTime.TryParse(dataNascStr, out dn))
                         continue;
                     int dia = dn.Day;
                     string nomeMesLinha = NomeMesDoCombo(dn.Month);
                     string colDia = dia + " de " + nomeMesLinha;
                     dgvRelatorio.Rows.Add(nome, colDia, comunidade);
                 }
             }
         }
     }
     if (mostrarResumo)
     {
         int n = dgvRelatorio.Rows.Count;
         if (diaFiltro.HasValue)
         {
             var d = dtpFiltroDataAniversario.Value.Date;
             MessageBox.Show("Aniversariantes em " + d.Day.ToString("00") + "/" + d.Month.ToString("00") + " (" + mesRotuloLista + "): " + n + " registro(s).");
         }
         else
             MessageBox.Show("Relatório de " + mesRotuloLista + ": " + n + " registro(s).");
     }
 }
 catch (Exception ex)
 {
     MessageBox.Show("Erro ao carregar relatório: " + ex.Message);
 }
}

        private void chkRural_CheckedChanged_1(object sender, EventArgs e)
        {
            if (chkRural.Checked)
            {
                chkUrbana.Checked = false; //se marcou rural desmarca urbana
            }
        }

        private void btn_SalvarComunidade_Click_1(object sender, EventArgs e)
        {                    
            {
            string novatxtComunidade = txtNovaComunidade.Text.Trim();

            if (string.IsNullOrWhiteSpace(novatxtComunidade))
            {
                MessageBox.Show("Digite o nome da nova comunidade!");
                return;
            }
            //variavel para guardar o tipo de zona]
            string tipoZona = "";
            if (chkRural.Checked) tipoZona = " (Rural)";
            else if (chkUrbana.Checked) tipoZona = " (Urbana)";

            //Verifica se NENHUM dos dois checkboxes foi marcado
            if (chkRural.Checked == false && chkUrbana.Checked == false)
            {
                MessageBox.Show("Selecione se é Zona Rural ou Urbana!", "Atenção");
                return;
            }

            // 3. Verifica se Cidade e Estado foram preenchidos
            //if (string.IsNullOrWhiteSpace(txtCidade.Text) || string.IsNullOrWhiteSpace(txtEstado.Text))

            string novatxtCidade = txtCidade.Text;

            if (string.IsNullOrWhiteSpace(txtCidade.Text))
            {
                MessageBox.Show("Preencha a Cidade", "Atenção");
                return;
            }
            string novatxtEstado = txtEstado.Text;

            if (string.IsNullOrWhiteSpace(txtEstado.Text))
            {
                MessageBox.Show("Preencha o Estado", "Atenção");
                return;
            }

            // Adiciona o nome + o tipó no ComboBox principal
            //txtComunidade.Items.Add(nomeNova + tipoZona);

            //string Localidade = txtNovaComunidade.Text + tipoZona + txtCidade.Text + txtEstado.Text;
            //Adiciona esse texto ao seu ComboBox principal (o txtComunidade)
            //txtComunidade.Items.Add(Localidade);
            //Deixa a nova comunidade já selecionada para você não ter que procurar
            //txtComunidade.SelectedItem = Localidade;
            // 1. Montamos a frase SQL para inserir os dados
            // Note que os nomes @nome, @estado, etc, são 'apelidos' para segurança
            string sql = "INSERT INTO Comunidade (txtNome, txtEstado, txtCidade, txtComunidade) " +
                         "VALUES (@nome, @estado, @cidade, @comunidade)";
            SQLiteConnection sqlcon = new SQLiteConnection(DbConnectionString);
            try
            {
                // 2. Abrimos a conexão
                sqlcon.Open();

                // 3. Preparamos o comando
                using (SQLiteCommand comando = new SQLiteCommand(sql, sqlcon))
                {
                    // 4. Trocamos os 'apelidos' pelos valores reais das suas caixas de texto
                    comando.Parameters.AddWithValue("@nome", novatxtComunidade);
                    comando.Parameters.AddWithValue("@estado", novatxtEstado);
                    comando.Parameters.AddWithValue("@cidade", novatxtCidade);
                    comando.Parameters.AddWithValue("@comunidade", novatxtComunidade + tipoZona);

                    // 5. Executamos a gravação
                    comando.ExecuteNonQuery();
                }

                // ... (dentro do try, após o ExecuteNonQuery)
                txtComunidade.Items.Add(novatxtComunidade + tipoZona);
                txtComunidade.SelectedItem = novatxtComunidade + tipoZona;

                MessageBox.Show("Comunidade adicionada com sucesso!");
                panelComunidade.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar no banco: " + ex.Message);
            }
            finally
            {
                sqlcon.Close();

                // Limpa os campos DEPOIS de fechar a conexão, independente de erro ou não
                txtNovaComunidade.Clear();
                txtCidade.Text = ""; // Se for TextBox, use .Clear() ou .Text = ""
                txtEstado.Text = "";
                chkRural.Checked = false;
                chkUrbana.Checked = false;
            }
           
            } 
        }

        private void btnAdicionarComunidade_Click_1(object sender, EventArgs e)
        {
            panelComunidade.Visible = true; // Faz o quadro aparecer na frente de tudo
            panelComunidade.BringToFront(); // Garante que ele fique por cima dos outros campos
            txtNovaComunidade.Focus();      // Já coloca o cursor pronto para digitar
        }

        private void chkUrbana_CheckedChanged(object sender, EventArgs e)
        {
            if (chkUrbana.Checked)
            {
                chkRural.Checked = false;// Se marcou Urbana, desmarca Rural
            }
        }

        private void btnFecharPnlComunidade_Click(object sender, EventArgs e)
        {
            panelComunidade.Visible = false;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            SetFieldsStatus(true);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            SetFieldsStatus(false);
            //btnNovoCadastroReset.Visible = true;
            btnNovoCadastro.Visible = true;
        }

        
    }
}
