using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog_itla.DataAcces
{
    public class USerDao : ConecionSql
    {
        public bool Login(String user, String pass)
        {
            using (var Connecion = GetSqlConnection())
            {
                Connecion.Open();

                using (var command = new SqlCommand())
                {
                    command.Connection = Connecion;
                    command.CommandText = "PS_Login";
                    command.Parameters.AddWithValue("@Usu", user);
                    command.Parameters.AddWithValue("@pass", pass);
                    command.CommandType = CommandType.StoredProcedure;
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }

            }
        }
        public bool Registro(String Nom, String User , String pass , int edad , String direcion)
        {
            using (var Connecion = GetSqlConnection())
            {
                Connecion.Open();

                using (var command = new SqlCommand())
                {
                    command.Connection = Connecion;
                    command.CommandText = "insert into blog_Usuario (Nombre , Usuario , password , Edad , Dirrecion) values (@Nom , @User , @pass ,@edad , @direcion)";
                    command.Parameters.AddWithValue("@Nom", Nom);
                    command.Parameters.AddWithValue("@User", User);
                    command.Parameters.AddWithValue("@pass", pass);
                    command.Parameters.AddWithValue("@edad", edad);
                    command.Parameters.AddWithValue("@direcion", direcion);
                    command.CommandType = CommandType.Text;
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }

            }
        }
    }
}

