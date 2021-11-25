using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShop
{
    class PetShop
    {
        public string id { get; set; }
        public string nome { get; set; }
        public string login { get; set; }
        public string senha { get; set; }
        public string celular { get; set; }
        public string data_admissao { get; set; }
        public string genero { get; set; }

        SqlConnection con = new SqlConnection("Data Source=(LocalDB)//MSSQLLocalDB;AttachDbFilename=C://Users//Aluno//Desktop//petshop-51053e54a6a5f70c62de3d9699c0bc173f61c8a5//PetShop//dbPetShop.mdf;Integrated Security=True");

        public void InserirFunc(string nome, string login, string senha, string celular, string data_admissao, string genero)
        {
            string sql = "INSERT INTO Funcionario(nome,login,senha,celular,data_admissao,genero) VALUES ('" + nome + "','" + login + "','" + senha + "','" + celular + "','" + genero + "','" + data_admissao + "','" + genero + "')";
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public List<PetShop> listafuncionario()
        {
            List<PetShop> li = new List<PetShop>();
            string sql = "SELECT * FROM Funcionario";
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                PetShop f = new PetShop();
                f.id = Convert.ToInt32(dr["id"]);
                f.nome = dr["nome"].ToString();
                f.celular = dr["celular"].ToString();
                f.endereco = dr["endereco"].ToString();
                f.complemento = dr["complemento"].ToString();
                f.cidade = dr["cidade"].ToString();
                f.cep = dr["cep"].ToString();
                f.cpf = dr["cpf"].ToString();
                f.cc = dr["cc"].ToString();
                f.pix = dr["pix"].ToString();
                f.genero = dr["genero"].ToString();
                f.data_nascimento = dr["data_nascimento"].ToString();
                f.funcao = dr["funcao"].ToString();
                li.Add(f);
            }
            return li;
        }
    }
}
