using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Script.Serialization;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjetoInter
{
    public partial class geraJSON : System.Web.UI.Page
    {
        private MySqlConnection conexao = new MySqlConnection
                ("server = localhost; port = 3306; user id = root; password=12345; database = faculdade;");

        public string ToJSON(object obj)
        {
            JavaScriptSerializer serializer = new JavaScriptSerializer();
            return serializer.Serialize(obj);
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            conexao.Open();
            List<Curso> cursos = new List<Curso>();
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM curso", conexao);
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                int id = reader.GetInt32("cod");
                string nome = reader.GetString("nome");
                string descricao = reader.GetString("descricao");
                string duracao = reader.GetString("duracao");
                Curso curso = new Curso(id, nome, descricao, duracao);
                cursos.Add(curso); //adicionamos o produto prod na List produtos
            }
            string jsonString = ToJSON(cursos); //conversão da List produtos para JSON
            Response.AddHeader("Access-Control-Allow-Origin", "*");
            Response.AddHeader("Access-Control-Allow-Methods", "GET, POST");
            Response.ContentType = "text/json"; //esta página .aspx retorna formato JSON
            Response.Charset = "UTF-8";
            Response.ContentEncoding = System.Text.Encoding.UTF8;
            Response.Cache.SetCacheability(HttpCacheability.NoCache);
            Response.Write(jsonString);
            Response.End();
        }
    }
}