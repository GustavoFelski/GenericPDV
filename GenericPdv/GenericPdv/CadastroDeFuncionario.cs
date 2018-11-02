using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace GenericPdv
{
    public partial class CadastroDeFuncionario : Form
    {
        SqlConnection sqlCon = null;
        private string strCon = @"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=GNPDVBD;Data Source=DOKAHVIIN-NOTE\SQLEXPRESS";
        private string strSql = String.Empty;
        private string strSql1 = String.Empty;
        SqlDataAdapter adaptadorFuncionario;
        SqlDataAdapter adaptadorCargo;
        DataSet Dados;

        public CadastroDeFuncionario()
        {
            InitializeComponent();
        }

        private void CadastroDeFuncionario_Load(object sender, EventArgs e)
        {
            //Design
            btSalvar.Enabled = false;
            btDeletar.Enabled = false;
            BtAlterar.Enabled = false;
            BtPesquisar.Enabled = true;
            btNovo.Enabled = true;
            BtCancelar.Enabled = false;

            textBusca.Enabled = true;
            textId.Enabled = false;
            textNome.Enabled = false;
            textEmail.Enabled = false;
            mkbTelefone.Enabled = false;
            cbbCargo.Enabled = false;
            textAcesso.Enabled = false;
            cbbStatus.Enabled = false;
            ckbReset.Enabled = false;

            // Design
            strSql = "INSERT INTO Funcionario (idFuncionario, funcNome, funcTelefone, funcEmail, funcStatus, funcReset, idCargo, funcAliase) VALUES (@id, @Nome, @Telefone, @Email, @Status, @Reset, @Cargo, @Acesso)";

            sqlCon = new SqlConnection(strCon);
            adaptadorFuncionario = new SqlDataAdapter();
            adaptadorCargo = new SqlDataAdapter();

            SqlParameter Parametro;
            Dados = new DataSet();

            SqlCommand CmdLoadFunc = new SqlCommand();
            //CmdLoadFunc.CommandText = "SELECT * FROM Funcionario AS F INNER JOIN Cargo AS C ON F.idCargo = C.id";
            CmdLoadFunc.CommandText = "SELECT * FROM Funcionario";
            CmdLoadFunc.Connection = sqlCon;
            adaptadorFuncionario.SelectCommand = CmdLoadFunc;
            adaptadorFuncionario.Fill(Dados, "Funcionario");

            SqlCommand CmdLoadCargo = new SqlCommand();
            CmdLoadCargo.CommandText = "SELECT * FROM Cargo";
            CmdLoadCargo.Connection = sqlCon;
            adaptadorCargo.SelectCommand = CmdLoadCargo;
            adaptadorCargo.Fill(Dados, "Cargo");

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = strSql;
            cmd.Connection = sqlCon;

            Parametro = new SqlParameter("@id", SqlDbType.Int, 8, "idFuncionario");
            cmd.Parameters.Add(Parametro);
            Parametro = new SqlParameter("@Nome", SqlDbType.VarChar, 100, "funcNome");
            cmd.Parameters.Add(Parametro);
            Parametro = new SqlParameter("@Telefone", SqlDbType.VarChar, 15, "funcTelefone");
            cmd.Parameters.Add(Parametro);
            Parametro = new SqlParameter("@Email", SqlDbType.VarChar, 100, "funcEmail");
            cmd.Parameters.Add(Parametro);
            Parametro = new SqlParameter("@Status", SqlDbType.Bit, 1, "funcStatus");
            cmd.Parameters.Add(Parametro);
            Parametro = new SqlParameter("@Reset", SqlDbType.Bit, 1, "funcReset");
            cmd.Parameters.Add(Parametro);
            Parametro = new SqlParameter("@Cargo", SqlDbType.Int, 1, "idCargo");
            cmd.Parameters.Add(Parametro);
            Parametro = new SqlParameter("@Acesso", SqlDbType.VarChar, 20, "funcAliase");
            cmd.Parameters.Add(Parametro);
            adaptadorFuncionario.InsertCommand = cmd;

            // Alterar 
            SqlCommand cmdAlterarFunc = new SqlCommand();
            cmdAlterarFunc.CommandText = "UPDATE funcionario SET idFuncionario = @id, funcNome = @Nome, funcTelefone = @Telefone, funcEmail = @Email, funcStatus = @Status, funcReset = @Reset, idCargo = @Cargo, funcAliase = @Acesso WHERE idFuncionario = @id";
            cmdAlterarFunc.Connection = sqlCon;

            Parametro = new SqlParameter("@id", SqlDbType.Int, 8, "idFuncionario");
            Parametro.SourceVersion = DataRowVersion.Current;
            cmdAlterarFunc.Parameters.Add(Parametro);
            Parametro = new SqlParameter("@Nome", SqlDbType.VarChar, 100, "funcNome");
            Parametro.SourceVersion = DataRowVersion.Current;
            cmdAlterarFunc.Parameters.Add(Parametro);
            Parametro = new SqlParameter("@Telefone", SqlDbType.VarChar, 15, "funcTelefone");
            Parametro.SourceVersion = DataRowVersion.Current;
            cmdAlterarFunc.Parameters.Add(Parametro);
            Parametro = new SqlParameter("@Email", SqlDbType.VarChar, 100, "funcEmail");
            Parametro.SourceVersion = DataRowVersion.Current;
            cmdAlterarFunc.Parameters.Add(Parametro);
            Parametro = new SqlParameter("@Status", SqlDbType.Bit, 1, "funcStatus");
            Parametro.SourceVersion = DataRowVersion.Current;
            cmdAlterarFunc.Parameters.Add(Parametro);
            Parametro = new SqlParameter("@Reset", SqlDbType.Bit, 1, "funcReset");
            Parametro.SourceVersion = DataRowVersion.Current;
            cmdAlterarFunc.Parameters.Add(Parametro);
            Parametro = new SqlParameter("@Cargo", SqlDbType.Int, 1, "idCargo");
            Parametro.SourceVersion = DataRowVersion.Current;
            cmdAlterarFunc.Parameters.Add(Parametro);
            Parametro = new SqlParameter("@Acesso", SqlDbType.VarChar, 20, "funcAliase");
            Parametro.SourceVersion = DataRowVersion.Current;
            cmdAlterarFunc.Parameters.Add(Parametro);

            adaptadorFuncionario.UpdateCommand = cmdAlterarFunc;
            //Deletar
            SqlCommand cmdDeletarFunc = new SqlCommand();
            cmdDeletarFunc.CommandText = "DELETE FROM Funcionario WHERE idFuncionario = @id";
            cmdDeletarFunc.Connection = sqlCon;

            Parametro = new SqlParameter("@id", SqlDbType.Int, 8, "idFuncionario");
            Parametro.SourceVersion = DataRowVersion.Original;
            cmdDeletarFunc.Parameters.Add(Parametro);

            adaptadorFuncionario.DeleteCommand = cmdDeletarFunc;
        }

        private void btNovo_Click(object sender, EventArgs e)
        {
            //design
            btSalvar.Enabled = true;
            btDeletar.Enabled = false;
            BtAlterar.Enabled = false;
            BtPesquisar.Enabled = false;
            btNovo.Enabled = false;
            BtCancelar.Enabled = true;

            textBusca.Enabled = false;
            textId.Enabled = true;
            textNome.Enabled = true;
            textEmail.Enabled = true;
            mkbTelefone.Enabled = true;
            cbbCargo.Enabled = true;
            textAcesso.Enabled = true;
            cbbStatus.Enabled = true;
            ckbReset.Enabled = false;
            ckbReset.Checked = true;
        }

        private void BtCancelar_Click(object sender, EventArgs e)
        {
            //Design
            btSalvar.Enabled = false;
            btDeletar.Enabled = false;
            BtAlterar.Enabled = false;
            BtPesquisar.Enabled = true;
            btNovo.Enabled = true;
            BtCancelar.Enabled = false;

            textBusca.Enabled = true;
            textId.Enabled = false;
            textNome.Enabled = false;
            textEmail.Enabled = false;
            mkbTelefone.Enabled = false;
            cbbCargo.Enabled = false;
            textAcesso.Enabled = false;
            cbbStatus.Enabled = false;
            ckbReset.Enabled = false;


            textId.Text = "";
            textNome.Text = "";
            textEmail.Text = "";
            mkbTelefone.Text = "";
            cbbCargo.Text = "";
            ckbReset.Checked = false;


        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            //Design
            btSalvar.Enabled = false;
            btDeletar.Enabled = false;
            BtAlterar.Enabled = false;
            BtPesquisar.Enabled = true;
            btNovo.Enabled = true;
            BtCancelar.Enabled = false;

            textBusca.Enabled = true;
            textId.Enabled = false;
            textNome.Enabled = false;
            textEmail.Enabled = false;
            mkbTelefone.Enabled = false;
            cbbCargo.Enabled = false;
            textAcesso.Enabled = false;
            cbbStatus.Enabled = false;
            ckbReset.Enabled = false;

            //Logica
            try
            {
                DataRow rowFuncionario = Dados.Tables["Funcionario"].NewRow();

                rowFuncionario["idFuncionario"] = textId.Text;
                rowFuncionario["funcTelefone"] = mkbTelefone.Text;
                rowFuncionario["funcNome"] = textNome.Text;
                rowFuncionario["funcEmail"] = textEmail.Text;
                rowFuncionario["funcStatus"] = cbbStatus.SelectedIndex;
                rowFuncionario["funcReset"] = ckbReset.Checked;
                rowFuncionario["idCargo"] = cbbCargo.SelectedIndex;
                //verificar se não existe um nome de acesso siminar cadastrado
                rowFuncionario["funcAliase"] = textAcesso.Text.ToUpper();

                Dados.Tables["Funcionario"].Rows.Add(rowFuncionario);
                adaptadorFuncionario.Update(Dados, "Funcionario");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            //Design

            textId.Text = "";
            textNome.Text = "";
            textEmail.Text = "";
            mkbTelefone.Text = "";
            cbbCargo.Text = "";
            ckbReset.Checked = false;
            textAcesso.Text = "";
        }

        private void btDeletar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Realmente Deletar os dados deste Usuario?\nVocê pode apenas Desabilita-lo", "Cuidado", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                //Logica
                DataRow[] rowFuncionarios = Dados.Tables["Funcionario"].Select("idFuncionario = '" + textBusca + "'");
                rowFuncionarios[0].Delete();
                adaptadorFuncionario.Update(Dados, "Funcionario");
                MessageBox.Show("Funcionario removido com sucesso.");
                //Design
                btSalvar.Enabled = false;
                btDeletar.Enabled = false;
                BtAlterar.Enabled = false;
                BtPesquisar.Enabled = true;
                btNovo.Enabled = true;
                BtCancelar.Enabled = false;

                textBusca.Enabled = true;
                textId.Enabled = false;
                textNome.Enabled = false;
                textEmail.Enabled = false;
                mkbTelefone.Enabled = false;
                cbbCargo.Enabled = false;
                textAcesso.Enabled = false;
                cbbStatus.Enabled = false;
                ckbReset.Enabled = false;

                textId.Text = "";
                textNome.Text = "";
                textEmail.Text = "";
                mkbTelefone.Text = "";
                cbbCargo.Text = "";
                ckbReset.Checked = false;
            }
            else
            {
                MessageBox.Show("Operação cancelada com sucesso.");
            }
        }

        private void BtAlterar_Click(object sender, EventArgs e)
        {
            //Design
            btSalvar.Enabled = false;
            btDeletar.Enabled = false;
            BtAlterar.Enabled = false;
            BtPesquisar.Enabled = true;
            btNovo.Enabled = true;
            BtCancelar.Enabled = false;

            textBusca.Enabled = true;
            textId.Enabled = false;
            textNome.Enabled = false;
            textEmail.Enabled = false;
            mkbTelefone.Enabled = false;
            cbbCargo.Enabled = false;
            textAcesso.Enabled = false;
            cbbStatus.Enabled = false;
            ckbReset.Enabled = false;

            //logica
            try
            {
                DataRow[] rowFuncionario = Dados.Tables["Funcionario"].Select("idFuncionario = '" + textId.Text + "'");

                rowFuncionario[0]["idFuncionario"] = textId.Text;
                rowFuncionario[0]["funcTelefone"] = mkbTelefone.Text;
                rowFuncionario[0]["funcNome"] = textNome.Text;
                rowFuncionario[0]["funcEmail"] = textEmail.Text;
                rowFuncionario[0]["funcStatus"] = cbbStatus.SelectedIndex;
                rowFuncionario[0]["funcReset"] = ckbReset.Checked;
                rowFuncionario[0]["idCargo"] = cbbCargo.SelectedIndex;
                rowFuncionario[0]["funcAliase"] = textAcesso.Text;

                adaptadorFuncionario.Update(Dados, "Funcionario");

            }
            catch (Exception ex)
            {
                MessageBox.Show("erro ao tentar alterar" + ex.Message);
            }
            MessageBox.Show("Dados do funcionario alterado com sucesso.");
            //Design

            textId.Text = "";
            textNome.Text = "";
            textEmail.Text = "";
            mkbTelefone.Text = "";
            cbbCargo.Text = "";
            ckbReset.Checked = false;
            cbbStatus.Text = "";

        }

        private void BtPesquisar_Click(object sender, EventArgs e)
        {
            //design
            btSalvar.Enabled = false;
            btDeletar.Enabled = true;
            BtAlterar.Enabled = true;
            BtPesquisar.Enabled = false;
            btNovo.Enabled = false;
            BtCancelar.Enabled = true;

            textBusca.Enabled = false;
            textId.Enabled = true;
            textNome.Enabled = true;
            textEmail.Enabled = true;
            mkbTelefone.Enabled = true;
            cbbCargo.Enabled = true;
            textAcesso.Enabled = true;
            cbbStatus.Enabled = true;
            ckbReset.Enabled = false;
            ckbReset.Checked = true;

            //Lógica
            string aux;

            try
            {
                //logica
                DataRow[] rowFuncionario = Dados.Tables["Funcionario"].Select("idFuncionario ='" + textBusca.Text + "'");

                textId.Text = rowFuncionario[0]["idFuncionario"].ToString();
                mkbTelefone.Text = rowFuncionario[0]["funcTelefone"].ToString();
                textNome.Text = rowFuncionario[0]["funcNome"].ToString();
                textEmail.Text = rowFuncionario[0]["funcEmail"].ToString();
                aux = rowFuncionario[0]["funcStatus"].ToString();
                if (aux == "0") { cbbStatus.SelectedValue = cbbStatus.SelectedIndex = 0; } else { cbbStatus.SelectedValue = cbbStatus.SelectedIndex = 1; }
                rowFuncionario[0]["funcReset"] = ckbReset.Checked;
                rowFuncionario[0]["idCargo"] = cbbCargo.SelectedIndex;
                aux = "";
                aux = rowFuncionario[0]["idCargo"].ToString();
                if (aux == "0") { cbbCargo.SelectedValue = cbbCargo.SelectedIndex = 0; }
                if (aux == "1") { cbbCargo.SelectedValue = cbbCargo.SelectedIndex = 1; }
                if (aux == "2") { cbbCargo.SelectedValue = cbbCargo.SelectedIndex = 2; }
                //MessageBox.Show(cbbCargo.SelectedValue +","+cbbCargo.SelectedIndex);
                textAcesso.Text = rowFuncionario[0]["funcAliase"].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Funcionario não encontrado.");
            }
        }

        private void btClouse_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
