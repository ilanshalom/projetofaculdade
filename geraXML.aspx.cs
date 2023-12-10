using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjetoInter
{
    public partial class geraXML : System.Web.UI.Page
    {
        MySqlConnection conexao = new MySqlConnection
        ("server=localhost; port=3306; user id=root; password=12345; database=faculdade;SSL Mode = None; ");

        protected void Page_Load(object sender, EventArgs e)
        {
            string xmlString = "<aluno>";
            conexao.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM aluno", conexao);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string nome = reader.GetString("nome");
                int idade = reader.GetInt32("idade");
                int rgm = reader.GetInt32("rgm");
                string curso = reader.GetString("curso");
                xmlString += "<alunos>";
                xmlString += "<nome>" + nome + "</nome>";
                xmlString += "<idade>" + idade + "</idade>";
                xmlString += "<rgm>" + rgm + "</rgm>";
                xmlString += "<curso>" + rgm + "</curso>";
                xmlString += "</alunos>";
            }
            xmlString += "</aluno>";
            Response.AddHeader("Access-Control-Allow-Origin", "*");
            Response.AddHeader("Access-Control-Allow-Methods", "GET, POST");
            Response.ContentType = "text/xml";
            Response.Charset = "UTF-8";
            Response.ContentEncoding = System.Text.Encoding.UTF8;
            Response.Cache.SetCacheability(HttpCacheability.NoCache);
            Response.Write(xmlString);
            Response.End();
        }
    }
}