
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;


namespace FinalPVDalila.Models
{
    public class RegistroBasedeDatos
    {
        
            private SqlConnection connection;


            public RegistroBasedeDatos()
            {
                connection = new SqlConnection(@"Data Source=ELRAFA81\SQLEXPRESS;Initial Catalog=FinalProgVisualDalila;Integrated Security=True");
            }

        public List<RegistroBiopsia> ObtenerRegistrosBiopsias()
            {
                List<RegistroBiopsia> resultado = new List<RegistroBiopsia>();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = this.connection;
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "select * from RegistroBiopsia";

                try
                {
                    this.connection.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        RegistroBiopsia bi = new RegistroBiopsia();
                        bi.IdRegistro = Convert.ToInt32(reader["IdRegistro"]);
                        bi.Paciente = new Paciente();
                        bi.Paciente.Nombre = reader["NombrePaciente"].ToString();
                        bi.Paciente.Apellido = reader["ApellidoPaciente"].ToString();
                        bi.Edad = Convert.ToInt32(reader["Edad"]);
                        bi.Internación = reader["Internación"].ToString();
                        bi.Muestra = reader["Muestra"].ToString();
                        bi.Método = reader["Método"].ToString();
                        bi.Protocolo = Convert.ToInt32(reader["Protocolo"]);
                        bi.Especialidad = reader["Especialidad"].ToString();
                        bi.FechadeEntrega = Convert.ToDateTime(reader["FechadeEntrega"]);


                        resultado.Add(bi);

                    }
                    return resultado;
                }

                catch (Exception ex)
                {
                    throw ex;
                }

                finally

                {
                    this.connection.Close();

                }

            }

        public bool Insertar(RegistroBiopsia bi)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = this.connection;
            cmd.CommandType = System.Data.CommandType.Text;

            string insert = "insert into RegistroBiopsia (NombrePaciente,ApellidoPaciente,Edad,Internación,Muestra,Método,Protocolo,Especialidad,FechadeEntrega)" +
                             " values ('{0}','{1}',{2},'{3}','{4}','{5}',{6},'{7}', {8})";


            //string fecha = li.FechadeEdicion.Day + "/" + li.FechadeEdicion.Month + "/" + li.FechadeEdicion.Year;


            insert = string.Format(insert, bi.Paciente.Nombre, bi.Paciente.Apellido, bi.Edad, bi.Internación, bi.Muestra,
                bi.Método, bi.Protocolo, bi.Especialidad, "CONVERT (DATE, '" + bi.FechadeEntrega.ToShortDateString() + "' , 103)");



            cmd.CommandText = insert;

            try
            {
                this.connection.Open();
                int resultado = cmd.ExecuteNonQuery();

                return (resultado > 0);

            }

            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                this.connection.Close();

            }



        }






        public RegistroBiopsia ObtenerRegistroBiopsia(int IdRegistro)
            {
                RegistroBiopsia bi = new RegistroBiopsia();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = this.connection;
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "select * from RegistroBiopsia where IdRegistro=" + IdRegistro;

                try
                {
                    this.connection.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {

                    bi.IdRegistro = Convert.ToInt32(reader["IdRegistro"]);

                    bi.Paciente = new Paciente();
                    bi.Paciente.Nombre = reader["NombrePaciente"].ToString();
                    bi.Paciente.Apellido = reader["ApellidoPaciente"].ToString();
                    bi.Edad = Convert.ToInt32(reader["Edad"]);
                    bi.Internación = reader["Internación"].ToString();
                    bi.Muestra = reader["Muestra"].ToString();
                    bi.Método = reader["Método"].ToString();
                    bi.Protocolo = Convert.ToInt32(reader["Protocolo"]);
                    bi.Especialidad = reader["Especialidad"].ToString();
                    bi.FechadeEntrega = Convert.ToDateTime(reader["FechadeEntrega"]);



                }
                    return bi;
                }

                catch (Exception ex)
                {
                    throw ex;
                }

                finally

                {
                    this.connection.Close();

                }

            }

            public bool Editar(RegistroBiopsia bi)
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = this.connection;
                cmd.CommandType = System.Data.CommandType.Text;

                string update = "update RegistroBiopsia set  NombrePaciente ='{0}',ApellidoPaciente ='{1}',Edad ={2},Internación ='{3}',Muestra ='{4}',Método ='{5}',Protocolo ={6},Especialidad ='{7}',FechadeEntrega ={8}" +
                "where IdRegistro= {9}";


                //string fecha = li.FechadeEdicion.Day + "/" + li.FechadeEdicion.Month + "/" + li.FechadeEdicion.Year;


            

            update = string.Format(update, bi.Paciente.Nombre, bi.Paciente.Apellido, bi.Edad, bi.Internación, bi.Muestra
                , bi.Método, bi.Protocolo, bi.Especialidad, "CONVERT (DATE, '" + bi.FechadeEntrega.ToShortDateString() + "' , 103)",bi.IdRegistro);

            cmd.CommandText = update;

                try
                {
                    this.connection.Open();
                    int resultado = cmd.ExecuteNonQuery();

                    return (resultado > 0);

                }

                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    this.connection.Close();

                }



            }



            public bool Eliminar(int IdRegistro)
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = this.connection;
                cmd.CommandType = System.Data.CommandType.Text;

                string delete = "delete from RegistroBiopsia where IdRegistro= " + IdRegistro;



                cmd.CommandText = delete;

                try
                {
                    this.connection.Open();
                    int resultado = cmd.ExecuteNonQuery();

                    return (resultado > 0);

                }

                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    this.connection.Close();

                }



            }

        }
    }




