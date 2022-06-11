
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;


namespace FinalPVDalila.Models
{
    public class RegistroBasedeDatos2
    {
        
            private SqlConnection connection;


            public RegistroBasedeDatos2()
            {
                connection = new SqlConnection(@"Data Source=ELRAFA81\SQLEXPRESS;Initial Catalog=FinalProgVisualDalila;Integrated Security=True");
            }

        public List<RegistroPiezaAnatomica> ObtenerRegistrosPiezasAnatomicas()
            {
                List<RegistroPiezaAnatomica> resultado = new List<RegistroPiezaAnatomica>();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = this.connection;
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "select * from RegistroPiezaAnatomica";

                try
                {
                    this.connection.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        RegistroPiezaAnatomica pa = new RegistroPiezaAnatomica();
                        pa.IdRegistroPA = Convert.ToInt32(reader["IdRegistroPA"]);
                        
                        pa.Paciente2 = new Paciente2();
                        pa.Paciente2.Nombre = reader["NombrePaciente2"].ToString();
                        pa.Paciente2.Apellido = reader["ApellidoPaciente2"].ToString();
                        pa.Edad2 = Convert.ToInt32(reader["Edad2"]);
                        pa.Internación2 = reader["Internación2"].ToString();
                        pa.Muestra2 = reader["Muestra2"].ToString();
                        pa.Método2 = reader["Método2"].ToString();
                        pa.Protocolo2 = Convert.ToInt32(reader["Protocolo2"]);
                        pa.Especialidad2 = reader["Especialidad2"].ToString();
                        pa.FechadeEntrega2 = Convert.ToDateTime(reader["FechadeEntrega2"]);


                        resultado.Add(pa);

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

            public bool Insertar2(RegistroPiezaAnatomica pa)
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = this.connection;
                cmd.CommandType = System.Data.CommandType.Text;

                string insert = "insert into RegistroPiezaAnatomica (NombrePaciente2,ApellidoPaciente2,Edad2,Internación2,Muestra2,Método2,Protocolo2,Especialidad2,FechadeEntrega2)" +
                                 "values ('{0}','{1}',{2},'{3}','{4}','{5}',{6},'{7}',{8})";


            


            insert = string.Format(insert, pa.Paciente2.Nombre, pa.Paciente2.Apellido, pa.Edad2, pa.Internación2, pa.Muestra2
               , pa.Método2, pa.Protocolo2, pa.Especialidad2, "CONVERT (DATE, '" + pa.FechadeEntrega2.ToShortDateString() + "' , 103)");



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


        public RegistroPiezaAnatomica ObtenerRegistroPiezaAnatomica(int IdRegistroPA)
            {
                RegistroPiezaAnatomica pa = new RegistroPiezaAnatomica();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = this.connection;
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "select * from RegistroPiezaAnatomica where IdRegistroPA=" + IdRegistroPA;

                try
                {
                    this.connection.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {

                    pa.IdRegistroPA = Convert.ToInt32(reader["IdRegistroPA"]);

                    pa.Paciente2 = new Paciente2();
                    pa.Paciente2.Nombre = reader["NombrePaciente2"].ToString();
                    pa.Paciente2.Apellido = reader["ApellidoPaciente2"].ToString();
                    pa.Edad2 = Convert.ToInt32(reader["Edad2"]);
                    pa.Internación2 = reader["Internación2"].ToString();
                    pa.Muestra2 = reader["Muestra2"].ToString();
                    pa.Método2 = reader["Método2"].ToString();
                    pa.Protocolo2 = Convert.ToInt32(reader["Protocolo2"]);
                    pa.Especialidad2 = reader["Especialidad2"].ToString();
                    pa.FechadeEntrega2 = Convert.ToDateTime(reader["FechadeEntrega2"]);
                    


                }
                    return pa;
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

            public bool Editar2(RegistroPiezaAnatomica pa)
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = this.connection;
                cmd.CommandType = System.Data.CommandType.Text;

                string update = "update RegistroPiezaAnatomica set  NombrePaciente2 ='{0}',ApellidoPaciente2 ='{1}',Edad2 ={2},Internación2 ='{3}',Muestra2 ='{4}',Método2 ='{5}',Protocolo2 ={6},Especialidad2 ='{7}',FechadeEntrega2 ={8}" +
                                 "where IdRegistroPA= {9}";


           


            

            update = string.Format(update, pa.Paciente2.Nombre, pa.Paciente2.Apellido, pa.Edad2, pa.Internación2, pa.Muestra2,pa.Método2, pa.Protocolo2, pa.Especialidad2,"CONVERT (DATE, '" + pa.FechadeEntrega2.ToShortDateString() + "' , 103)", pa.IdRegistroPA);

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



            public bool Eliminar2(int IdRegistroPA)
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = this.connection;
                cmd.CommandType = System.Data.CommandType.Text;

                string delete = "delete from RegistroPiezaAnatomica where idRegistroPA= " + IdRegistroPA;



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




