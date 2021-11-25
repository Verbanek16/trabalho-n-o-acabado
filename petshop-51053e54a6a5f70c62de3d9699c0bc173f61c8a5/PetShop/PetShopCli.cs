using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShop
{
    class PetShopCli
    {
        public int Id { get; set; }
        public string nome { get; set; }
        public string endereco { get; set; }
        public string cidade { get; set; }
        public string celular { get; set; }
        public string email { get; set; }
        public string data_nascimento { get; set; }

        SqlConnection con = new SqlConnection("Data Source=(LocalDB)//MSSQLLocalDB;AttachDbFilename=C://Users//Aluno//Desktop//petshop-51053e54a6a5f70c62de3d9699c0bc173f61c8a5//PetShop//dbPetShop.mdf;Integrated Security=True");

        public void InserirCli(string nome, string endereco, string cidade, string celular, string email, string data_nascimento)
        {
            string sql = "INSERT INTO  Cliente(nome,endereco,cidade,celular,email,data_nascimento)VALUES('" + nome + "','" + endereco + "','" + cidade + "','" + celular + "','" + email + "','" + data_nascimento + "')";
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public List<PetShopCli> Listacliente()
        {
            List<PetShopCli> li = new List<PetShopCli>();
            string sql = "SELECT * FROM Cliente";
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                PetShopCli f = new PetShopCli();
                f.Id = Convert.ToInt32(dr["Id"]);
                f.nome = dr["nome"].ToString();
                f.endereco = dr["endereco"].ToString();
                f.cidade = dr["cidade"].ToString();
                f.celular = dr["celular"].ToString();
                f.email = dr["email"].ToString();
                f.data_nascimento = dr["data_nascimento"].ToString();
                li.Add(f);
            }
            return li;
        }
        public void ExcluirCli(int id)
        {
            string sql = "DELETE FROM Cliente WHERE Id = '" + id + "'";
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public void LocalizaCli(int id)
        {
            con.Open();
            string sql = "SELECT * FROM Cliente WHERE Id = '" + id + "'";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader dr = cmd.ExecuteReader();
            string data = Convert.ToString(data_nascimento);
            while (dr.Read())
            {
                nome = dr["nome"].ToString();
                endereco = dr["endereco"].ToString();
                cidade = dr["cidade"].ToString();
                celular = dr["celular"].ToString();
                email = dr["email"].ToString();
                data_nascimento = dr["data_nascimento"].ToString();
            }
            dr.Close();
            con.Close();
        }
        public void AtualizarCli(string nome, string endereco, string cidade, string celular, string email, string data_nascimento)
        {
            string sql = "UPDATE Cliente SET nome='" + nome + "',endereco='" + endereco + "',cidade='" + cidade + "',celular='" + celular + "',email='" + email + "',data_nascimento='" + data_nascimento + "' WHERE Id='" + Id + "'";
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
        
        
}

