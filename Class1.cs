using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//namespace reloj
//{
//    public class metodos
//    {
//        string cadenaConexion = "Data Source=LAPTOP-M0P6SDBJ\\SQLEXPRESS;Initial Catalog=carros;Integrated Security=True";

//        public string Error;


//        public SqlConnection AbrirConexion()
//        {
//            SqlConnection conexion = new SqlConnection();
//            try
//            {

//                //variable para crear conexion 
//                conexion = new SqlConnection(cadenaConexion);
//                conexion.Open();
//            }
//            catch (Exception ex)
//            {
//                Error = ex.Message;
//            }
//            return conexion;
//        }

//public bool InsertDatos(int Folio, string Cliente, string telefono, string domicilio, DateTime fecha_de_salida, DateTime fecha_de_entrega, string carro)
//{
//    bool Estado = false;
//    try
//    {
//        SqlConnection conn = AbrirConexion();
//        string Query = "INSERT INTO rentaDcarrro  (folio,Cliente, telefono,domicilio,fecha_de_salida, fecha_de_entrega,carro ) VALUES (@folio,@Cliente, @telefono, @domicilio,@fecha_de_salida,@fecha_de_entrega,@carro)";
//        SqlCommand command;
//        command = new SqlCommand(Query, conn);
//        command.Parameters.AddWithValue("@folio", 1);
//        command.Parameters.AddWithValue("@Cliente", Cliente);
//        command.Parameters.AddWithValue("@telefono", telefono);
//        command.Parameters.AddWithValue("@domicilio", domicilio);
//        command.Parameters.AddWithValue("@fecha_de_salida", fecha_de_salida);
//        command.Parameters.AddWithValue("@fecha_de_entrega", fecha_de_entrega);
//        command.Parameters.AddWithValue("@carro", carro);


//        command.ExecuteNonQuery();
//        conn.Close();
//        Estado = true;
//    }
//    catch (Exception ex)
//    {
//        Error = ex.Message;
//    }
//    return Estado;
//}
//    }
//}
