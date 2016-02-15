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
            //sql query
            con = new SqlConnection("Data Source=SERVER;Initial Catalog=TROMPO_EysCommerciaNet;User ID=sa;Password=eys");
            con.Open();
            string CommandText = "SELECT TOP 1 * FROM dbo.Cliente ORDER BY ClienteId DESC ";
            cmd = new SqlCommand(CommandText);
            cmd.Connection = con;
            rdr = cmd.ExecuteReader();
            rdr.Read();
            string valor = rdr.GetSqlValue(0).ToString(); //Es 0 porque se lee el valor [ClienteId] de la tabla dbo.Cliente
            int valorr = int.Parse(valor.Substring(9)) + 1;
            MessageBox.Show("TROMPOTIJ" + valorr.ToString());
            con.Close();
        }

        public void Agenda()
        {
            //sql query
        }
    }
}
