using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pryTP2BordigaGabriel
{
    internal class clsUsuario
    {
        private OleDbConnection conexion = new OleDbConnection();
        private OleDbCommand comando = new OleDbCommand();
        private OleDbDataAdapter adaptador = new OleDbDataAdapter();

        private string CadenaConexion = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=../../Archivos/BDusuarios.mdb";

        public string EstadoConexion { get; private set; } // Propiedad para almacenar el estado de la conexión

        public bool ValidarUsuario(string nombreUser, string passUser)
        {
            try
            {
                using (OleDbConnection conexionBD = new OleDbConnection(CadenaConexion))
                {
                    conexionBD.Open();

                    using (OleDbCommand comandoBD = new OleDbCommand("SELECT COUNT(*) FROM Usuario WHERE NombreUsuario = @NombreUsuario AND Contraseña = @Contraseña", conexionBD))
                    {
                        comandoBD.Parameters.AddWithValue("@NombreUsuario", nombreUser);
                        comandoBD.Parameters.AddWithValue("@Contraseña", passUser);
                        int count = Convert.ToInt32(comandoBD.ExecuteScalar());
                        if (count > 0)
                        {
                            return true; // Usuario válido
                        }
                    }
                }
                return false; // Usuario no encontrado o contraseña incorrecta
            }
            catch (OleDbException error)
            {
                // Manejo de excepciones
                return false;
            }
        }
    

        public bool VerificarConexion()
        {
            try
            {
                // Asignar la cadena de conexión
                conexion.ConnectionString = CadenaConexion;

                // Abrir la conexión
                conexion.Open();

                // Verificar el estado de la conexión
                if (conexion.State == ConnectionState.Open)
                {
                    return true; // Conexión establecida
                }
                else
                {
                    return false; // No se pudo establecer la conexión
                }
            }
            catch (Exception error)
            {
                // Manejar cualquier error al verificar la conexión
                Console.WriteLine("Error al verificar conexión: " + error.Message);
                return false;
            }
            finally
            {
                // Asegúrate de cerrar la conexión después de verificarla
                if (conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                }
            }
        }
    }
}