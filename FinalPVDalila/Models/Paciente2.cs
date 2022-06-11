//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Web;
  using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace FinalPVDalila.Models
    //comentario en la liniea 12
{
    public class Paciente2
    {
      
            public String Nombre { get; set; }

            public String Apellido { get; set; }

            public String NombreApellido

            {
                get
                {


                    return this.Nombre + " " + this.Apellido;
                }




            }

        }
    }



