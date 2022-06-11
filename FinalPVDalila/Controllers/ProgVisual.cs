
 using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FinalPVDalila.Models;

namespace FinalPVDalila.Controllers
{
    public class ProgVisualController : Controller
    {

        //GET: ProgVisual

        public ActionResult Index()
        {
            RegistroBasedeDatos da = new RegistroBasedeDatos();
            List<RegistroBiopsia> Registros= da.ObtenerRegistrosBiopsias();

            return View(Registros);
        }

     


        public ActionResult ProgVisual()
            {

                RegistroBiopsia bi = new RegistroBiopsia();
              
                bi.Paciente = new Paciente();
                bi.Paciente.Nombre = Request["txtPacienteNombre"];
                bi.Paciente.Apellido = Request["txtPacienteApellido"];
                bi.Edad = Convert.ToInt32(Request["txtEdad"]);
                bi.Internación = Request["txtInternación"];
                bi.Muestra = Request["txtMuestra"];
                bi.Método = Request["SelMétodo"];
                bi.Protocolo = Convert.ToInt32(Request["txtProtocolo"]);
                bi.Especialidad = Request["txtEspecialidad"];
                bi.FechadeEntrega = Convert.ToDateTime(Request["dtpFechadeEntrega"]);

            RegistroBasedeDatos da = new RegistroBasedeDatos();
                da.Insertar(bi);


                return RedirectToAction("Index");

            }

            public ActionResult CargadeDatos()
            {


                return View();

            }


            public ActionResult Editar(int ID)
            {
            RegistroBasedeDatos da = new RegistroBasedeDatos();
                RegistroBiopsia bi = da.ObtenerRegistroBiopsia(ID);

                return View(bi);


            }

            public ActionResult Edicion()
            {
            RegistroBiopsia bi = new RegistroBiopsia();
            bi.IdRegistro= Convert.ToInt32(Request["hdnID"]);
            bi.Paciente = new Paciente();
            bi.Paciente.Nombre = Request["txtPacienteNombre"];
            bi.Paciente.Apellido = Request["txtPacienteApellido"];
            bi.Edad = Convert.ToInt32(Request["txtEdad"]);
            bi.Internación = Request["txtInternación"];
            bi.Muestra = Request["txtMuestra"];
            bi.Método = Request["SelMétodo"];
            bi.Protocolo = Convert.ToInt32(Request["txtProtocolo"]);
            bi.Especialidad = Request["txtEspecialidad"];
            bi.FechadeEntrega = Convert.ToDateTime(Request["dtpFechadeEntrega"]);

            RegistroBasedeDatos da = new RegistroBasedeDatos();
                da.Editar(bi);

                return RedirectToAction("Index");


            }
            public ActionResult Eliminar(int ID)
            {

            RegistroBasedeDatos da = new RegistroBasedeDatos();
                RegistroBiopsia bi = da.ObtenerRegistroBiopsia(ID);

                return View(bi);


            }
            public ActionResult Eliminacion()
            {
                int ID = Convert.ToInt32(Request["hdnID"]);
            RegistroBasedeDatos da = new RegistroBasedeDatos();
                da.Eliminar(ID);

                return RedirectToAction("Index");




            }


        
    }
    
}












