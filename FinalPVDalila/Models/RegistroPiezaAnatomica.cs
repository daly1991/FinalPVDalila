
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace FinalPVDalila.Models
{
    public class RegistroPiezaAnatomica
    {

            public int IdRegistroPA { get; set; }
           
            public Paciente2 Paciente2 { get; set; }

            public int Edad2 { get; set; }

            public string Internación2 { get; set; }  
            public string Muestra2 { get; set; }
            public string Método2 { get; set; }

            public int Protocolo2 { get; set; }

            public string Especialidad2 { get; set; }

            public DateTime FechadeEntrega2 { get; set; }

        }


    }

