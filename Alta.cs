using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ElTrompo
{
    class Alta
    {
        //la implementacion de los metodos va a ser con un patron de diseño
        //de software. El patron que se implemento es data source architectural pattern.
        SqlDataReader rdr = null;
        SqlConnection con = null;
        SqlCommand cmd = null;


        public void Cliente()
        {
            var foo = System.Configuration.ConfigurationSettings.AppSettings["MyConnection"]; 
            //sql query
            con = new SqlConnection(foo);
            con.Open();
            string CommandText = "SELECT TOP 1 * FROM dbo.Cliente ORDER BY ClienteId DESC ";
            cmd = new SqlCommand(CommandText);
            cmd.Connection = con;
            rdr = cmd.ExecuteReader();
            rdr.Read();
            string valor = rdr.GetSqlValue(0).ToString(); //Es 0 porque se lee el valor [ClienteId] de la tabla dbo.Cliente
            int valorr = int.Parse(valor.Substring(9)) + 1;
            MessageBox.Show("TROMPOTIJ" + valorr.ToString()); con.Close();

            var myParameters = new SqlParameter[]
            {
                new SqlParameter("nombre", "valor")
            };

            var command = new SqlCommand()
            {
                CommandType = System.Data.CommandType.StoredProcedure,
                CommandText = "ClienteInsert",
                Connection = con
            };
            command.Parameters.Add(myParameters);
            cmd.ExecuteNonQuery();



        }

        public void Agenda()
        {
            //sql query
        }
    }
}
