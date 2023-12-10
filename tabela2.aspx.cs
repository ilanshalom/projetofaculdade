using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Policy;
using System.Web;
using System.Web.Script.Serialization;
using System.Web.UI;
using System.Web.UI.WebControls;
using static ProjetoInter.WebForm3;

namespace ProjetoInter
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        private MySqlConnection conexao = new MySqlConnection("server = localhost; port = 3306; user id=root; password=12345; database = faculdade;");
        private MySqlCommand command = null;
        private MySqlCommand stm;
        private MySqlDataReader rs;

        protected void Page_Load(object sender, EventArgs e)
        {
            populaDataGrid();
        }

        public void populaDataGrid()
        {
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM curso", conexao);
            DataTable dataTable = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dataTable);
            GridView1.DataSource = dataTable;
            GridView1.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("home.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("tabela1.aspx");
        }
        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("geraJSON.aspx");
        }

        protected void BtnInserir_Click(object sender, EventArgs e)
        { //INSERIR UM CURSO

            String paramCod = "";
            String paramNome = "";
            String paramDescricao = "";
            String paramDuracao = "";
            try
            {
                paramCod = Request["txtcod"];
                paramNome = Request["txtnome"];
                paramDescricao = Request["txtdescricao"];
                paramDuracao = Request["txtduracao"];
                if (paramCod == null) paramCod = "";
                if (paramNome == null) paramNome = "";
                if (paramDescricao == null) paramDescricao = "";
                if (paramDuracao == null) paramDuracao = "";
            }

            catch (Exception) { };

            try
            {
                conexao.Open();
                String sql = "INSERT INTO curso (cod, nome, descricao, duracao) " + " VALUES (@cod,@nome,@descricao,@duracao)";
                command = new MySqlCommand(sql, conexao);

                command.Parameters.AddWithValue("@cod", paramCod);
                command.Parameters.AddWithValue("@nome", paramNome);
                command.Parameters.AddWithValue("@descricao", paramDescricao);
                command.Parameters.AddWithValue("@duracao", paramDuracao);
                command.Prepare();
                int qtde = command.ExecuteNonQuery();
                if (qtde == 0)
                {
                    confirmacao.Text = "Não foi possível adicionar o Curso!";
                }
                else
                {
                    confirmacao.Text = "Curso adicionado com sucesso!";
                }
            }
            catch (Exception exc)
            {
                confirmacao.Text = "Erro ao inserir. Verifique que não tenha outro curso com esse nome."
                    + " --- " + exc.Message;
            }
            finally
            {
                if (command != null) command.Dispose();
                if (conexao != null) conexao.Close();
            }
        }
        protected void BtnAlterar_Click(object sender, EventArgs e)
        {   //ALTERAR UM CURSO

            String paramCod = "";
            String paramNome = "";
            String paramDescricao = "";
            String paramDuracao = "";
            try
            {
                paramCod = Request["txtcod"];
                paramNome = Request["txtnome"];
                paramDescricao = Request["txtdescricao"];
                paramDuracao = Request["txtduracao"];
                if (paramCod == null) paramCod = "";
                if (paramNome == null) paramNome = "";
                if (paramDescricao == null) paramDescricao = "";
                if (paramDuracao == null) paramDuracao = "";
            }

            catch (Exception) { };

            try
            {
                conexao.Open();

                //Usando prepared statements:
                String sql = "UPDATE curso SET nome=@nome, descricao=@descricao, duracao=@duracao WHERE cod=@cod";
                command = new MySqlCommand(sql, conexao);

                command.Parameters.AddWithValue("@cod", paramCod);
                command.Parameters.AddWithValue("@nome", paramNome);
                command.Parameters.AddWithValue("@descricao", paramDescricao);
                command.Parameters.AddWithValue("@duracao", paramDuracao);
                command.Prepare();
                int qtde = command.ExecuteNonQuery();
                if (qtde == 0)
                {
                    confirmacao.Text = "Não foi possível adicionar o Curso!";
                }
                else
                {
                    confirmacao.Text = "Curso adicionado com sucesso!";
                }

                command.Dispose();
                conexao.Close();
            }
            catch (Exception exc)
            {
                confirmacao.Text = "Não foi possível alterar o Curso - " + exc.Message;
            }
        }
        protected void BtnDeletar_Click(object sender, EventArgs e)
        {   // ELIMINAR UM CURSO
            String paramCod = "";
            try
            {
                paramCod = Request["txtcod"];
                if (paramCod == null) paramCod = "-1";
            }
            catch (Exception) { };
            try
            {
                conexao.Open();
                stm = new MySqlCommand("DELETE FROM curso WHERE cod = @cod", conexao);
                stm.Parameters.AddWithValue("@cod", paramCod);
                stm.Prepare();
                int qtde = stm.ExecuteNonQuery();
                if (qtde == 0)
                {
                    confirmacao.Text = "Não foi possível deletar o curso com Codigo: " + paramCod + ".";
                }
                else
                {
                    confirmacao.Text = "Curso deletado com sucesso! Codigo: " + paramCod + ".";
                }
            }
            catch (Exception exc)
            {
                confirmacao.Text = "Erro: " + exc.Message;
            }
            finally
            {
                stm.Dispose();
                conexao.Close();
            }
        }

        protected void BtnAtualizar_Click(object sender, EventArgs e)
        {
            populaDataGrid();
        }
    }
}