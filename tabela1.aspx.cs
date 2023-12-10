using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySqlConnector;
using System.Reflection.Emit;
using System.Data.Common;

namespace ProjetoInter
{
    public partial class WebForm2 : System.Web.UI.Page
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
            MySqlCommand cmd = new MySqlCommand("SELECT nome, idade, rgm, curso FROM aluno", conexao);
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
            Response.Redirect("tabela2.aspx");
        }
        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("geraXML.aspx");
        }

        protected void BtnInserir_Click(object sender, EventArgs e)
        { //INSERIR UM ALUNO

            String paramNome = "";
            String paramIdade = "";
            String paramRgm = "";
            String paramCurso = "";
            try
            {
                paramNome = Request["txtnome"];
                paramIdade = Request["txtidade"];
                paramRgm = Request["txtrgm"];
                paramCurso = Request["txtcurso"];
                if (paramNome == null) paramNome = "";
                if (paramIdade == null) paramIdade = "";
                if (paramRgm == null) paramRgm = "";
                if (paramCurso == null) paramCurso = "";
            }
        
            catch (Exception) { };

                try
            {
                conexao.Open();
                String sql = "INSERT INTO aluno (nome, idade, rgm, curso) " + " VALUES (@nome,@idade,@rgm,@curso)";
                command = new MySqlCommand(sql, conexao);
                command.Parameters.AddWithValue("@nome", paramNome);
                command.Parameters.AddWithValue("@idade", paramIdade);
                command.Parameters.AddWithValue("@rgm", paramRgm);
                command.Parameters.AddWithValue("@curso", paramCurso);
                command.Prepare();
                int qtde = command.ExecuteNonQuery();
                if (qtde == 0)
                {
                    confirmacao.Text = "Não foi possível adicionar o Aluno!";
                }
                else
                {
                    confirmacao.Text = "Aluno adicionado com sucesso!";
                }
            }
            catch (Exception exc)
            {
                confirmacao.Text = "Erro ao inserir. Verifique que não tenha outro aluno com esse código."
                    + " --- " + exc.Message;
            }
            finally
            {
                if (command != null) command.Dispose();
                if (conexao != null) conexao.Close();
            }
        }
        protected void BtnAlterar_Click(object sender, EventArgs e)
        {   //ALTERAR UM ALUNO

            String paramNome = "";
            String paramIdade = "";
            String paramRgm = "";
            String paramCurso = "";
            try
            {
                paramNome = Request["txtnome"];
                paramIdade = Request["txtidade"];
                paramRgm = Request["txtrgm"];
                paramCurso = Request["txtcurso"];
                if (paramNome == null) paramNome = "";
                if (paramIdade == null) paramIdade = "";
                if (paramRgm == null) paramRgm = "";
                if (paramCurso == null) paramCurso = "";
            }

            catch (Exception) { };

            try
            {
                conexao.Open();

                //Usando prepared statements:
                String sql = "UPDATE aluno SET nome=@nome , idade=@idade, curso=@curso WHERE rgm=@rgm";
                command = new MySqlCommand(sql, conexao);

                command.Parameters.AddWithValue("@nome", paramNome);
                command.Parameters.AddWithValue("@idade", paramIdade);
                command.Parameters.AddWithValue("@rgm", paramRgm);
                command.Parameters.AddWithValue("@curso", paramCurso);
                command.Prepare();
                int qtde = command.ExecuteNonQuery();

                if (qtde == 0)
                {
                    confirmacao.Text = "Naõ foi possível alterar o aluno com RGM: " + paramRgm + ".";
                }
                else
                {
                    confirmacao.Text = "Aluno alterado com sucesso! RGM: " + paramRgm + ".";
                }

                command.Dispose();
                conexao.Close();
            }
            catch (Exception exc)
            {
                confirmacao.Text = "Não foi possível alterar o Aluno - " + exc.Message;
            }
        }
        protected void BtnDeletar_Click(object sender, EventArgs e)
        {   // ELIMINAR UM ALUNO
            String paramRgm = "";
            try
            {
                paramRgm = Request["txtrgm"];
                if (paramRgm == null) paramRgm = "-1";
            }
            catch (Exception) { };
            try
            {
                conexao.Open();
                stm = new MySqlCommand("DELETE FROM aluno WHERE rgm = @rgm", conexao);
                stm.Parameters.AddWithValue("@rgm", paramRgm);
                stm.Prepare();
                int qtde = stm.ExecuteNonQuery();
                if (qtde == 0)
                {
                    confirmacao.Text = "Não foi possível deletar o aluno com RGM: " + paramRgm + ".";
                }
                else
                {
                    confirmacao.Text = "Aluno deletado com sucesso! RGM: " + paramRgm + ".";
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