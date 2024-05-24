using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Dapper;

namespace Semana13BDk
{
    public class DataAccess
    {
        public const string CONNECTION_STRING = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\Pineda's\\source\\repos\\Semana13BDk\\Semana13BDk\\Escuela.mdf\";Integrated Security=True";

        public const string CADENA_SQL_SERVER = "Server=DESKTOP-3C889HT\\SQLEXPRESS01;Integrated Security=true;Initial Catalog=master";

        public List<Alumno> GetAllAdoNet()
        {
            List<Alumno> alumnos = new List<Alumno>();
            try
            {
                SqlConnection conn = new SqlConnection(CONNECTION_STRING);
                conn.Open();
                string query = "SELECT id, nombres, apellidos, carnet, telefono FROM Alumno";
                SqlCommand sqlCommand = new SqlCommand(query, conn);
                SqlDataReader reader = sqlCommand.ExecuteReader();

                while (reader.Read())
                {
                    Alumno a = new Alumno
                    {
                        Id = reader.GetInt32(0),
                        Nombres = reader.GetString(1),
                        Apellidos = reader.GetString(2),
                        Carnet = reader.GetString(3),
                        Telefono = reader.GetString(4)
                    };
                    alumnos.Add(a);
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            return alumnos;
        }

        public List<Alumno> GetAllDapper()
        {
            
                List<Alumno> alumnos = new List<Alumno>();
                try
                {
                    SqlConnection conn = new SqlConnection(CADENA_SQL_SERVER);
                    conn.Open();
                string query = "SELECT a.id, a.nombres, a.apellidos, a.carnet, a.telefono, a.idCarrera, c.nombre as nombreCarrera FROM Alumno a JOIN Carrera c ON a.idCarrera = c.id";
                alumnos = conn.Query<Alumno>(query).ToList();
                    conn.Close();

            }

                catch (SqlException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                return alumnos;
            }

            public int Create(Alumno alumno)
            {
                int result = 0;
                try
                {
                    SqlConnection conn = new SqlConnection(CADENA_SQL_SERVER);
                    conn.Open();
                    string query = @"INSERT INTO Alumno (id, nombres, apellidos, carnet, telefono, idCarrera)
                                              VALUES (@id, @nombres, @apellidos, @carnet, @telefono, @idCarrera) 
";
                //Para guardar, actualizar o eliminar se usa execute.
                result = conn.Execute(query, new
                {
                    id = alumno.Id,
                    nombres = alumno.Nombres,
                    apellidos = alumno.Apellidos,
                    carnet = alumno.Carnet,
                    telefono = alumno.Telefono,
                    idCarrera = alumno.IdCarrera

                });
                conn.Close();

            }
            catch (SqlException ex)
                {
                    Console.WriteLine(ex.Message);
                    MessageBox.Show(ex.Message);
            }

                return result;
            }
        public Alumno GetById(int idAlumno)
        {
            Alumno alumno = new Alumno();
            try
            {
                SqlConnection conn = new SqlConnection(CADENA_SQL_SERVER);
                conn.Open();
                string query = "SELECT id, nombres, apellidos, carnet, telefono, idCarrera FROM Alumno WHERE id=@id";
                alumno = conn.QuerySingle<Alumno>(query, new { id = idAlumno });
                conn.Close();

            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            return alumno;
        }
        public int Update(Alumno alumno)
        {
            int result = 0;
            try
            {
                SqlConnection conn = new SqlConnection(CADENA_SQL_SERVER);
                conn.Open();
                string query = @"UPDATE Alumno SET nombres=@nombres, apellidos=@apellidos, carnet=@carnet, telefono=@telefono, idCarrera=@idCarrera
                                WHERE id= @id";
                //Para guardar, actualizar o eliminar se usa execute.
                result = conn.Execute(query, new
                {
                    id = alumno.Id,
                    nombres = alumno.Nombres,
                    apellidos = alumno.Apellidos,
                    carnet = alumno.Carnet,
                    telefono = alumno.Telefono,
                    idCarrera = alumno.IdCarrera

                });
                conn.Close();

            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show(ex.Message);
            }

            return result;
        }


        public int Delete(int id)
        {
            int result = 0;
            try
            {
                SqlConnection conn = new SqlConnection(CADENA_SQL_SERVER);
                conn.Open();
                string query = @"DELETE FROM Alumno WHERE id= @id";
                //Para guardar, actualizar o eliminar se usa execute.
                result = conn.Execute(query, new
                {
                    id = id
                });
                conn.Close();

            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show(ex.Message);
            }

            return result;
        }

        public List<Carrera> GetCarreras()
        {
            List<Carrera> carreras = new List<Carrera>();
            try
            {
                SqlConnection conn = new SqlConnection(CADENA_SQL_SERVER);
                conn.Open();
                string query = "SELECT id, nombre FROM carrera";
                carreras = conn.Query<Carrera>(query).ToList();
                conn.Close();

            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            return carreras;
        }

        public List<Producto> GetAllProductos()
        {
            using (var conn = new SqlConnection(CONNECTION_STRING))
            {
                string query = "SELECT Id, Nombre, Precio FROM Productos";
                return conn.Query<Producto>(query).ToList();
            }
        }

        public int InsertProducto(Producto producto)
        {
            using (var conn = new SqlConnection(CONNECTION_STRING))
            {
                string query = "INSERT INTO Productos (Nombre, Precio) VALUES (@Nombre, @Precio)";
                return conn.Execute(query, producto);
            }
        }

        public int UpdateProducto(Producto producto)
        {
            using (var conn = new SqlConnection(CONNECTION_STRING))
            {
                string query = "UPDATE Productos SET Nombre = @Nombre, Precio = @Precio WHERE Id = @Id";
                return conn.Execute(query, producto);
            }
        }

        public int DeleteProducto(int id)
        {
            using (var conn = new SqlConnection(CONNECTION_STRING))
            {
                string query = "DELETE FROM Productos WHERE Id = @Id";
                return conn.Execute(query, new { Id = id });
            }
        }

        // Métodos para ventas
        public List<Venta> GetAllVentas()
        {
            using (var conn = new SqlConnection(CONNECTION_STRING))
            {
                string query = "SELECT Id, FechaVenta, IdProducto, Cantidad FROM Ventas";
                return conn.Query<Venta>(query).ToList();
            }
        }

        public int InsertVenta(Venta venta)
        {
            using (var conn = new SqlConnection(CONNECTION_STRING))
            {
                string query = "INSERT INTO Ventas (FechaVenta, IdProducto, Cantidad) VALUES (@FechaVenta, @IdProducto, @Cantidad)";
                return conn.Execute(query, venta);
            }
        }

        // Otros métodos CRUD para ventas según sea necesario
    }
}

