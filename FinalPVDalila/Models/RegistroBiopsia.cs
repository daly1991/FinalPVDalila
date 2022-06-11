
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace FinalPVDalila.Models
{
    public class RegistroBiopsia
    {

            public int IdRegistro { get; set; }
           
            public Paciente Paciente { get; set; }

            public int Edad { get; set; }

            public string Internación { get; set; }  
            public string Muestra { get; set; }
            public string Método { get; set; }

            public int Protocolo { get; set; }

            public string Especialidad { get; set; }

            public DateTime FechadeEntrega { get; set; }

        }


    }

