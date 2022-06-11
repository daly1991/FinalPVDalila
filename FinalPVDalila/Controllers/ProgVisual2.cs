
 using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FinalPVDalila.Models;

namespace FinalPVDalila.Controllers
{
    public class ProgVisual2Controller : Controller
    {

        //GET: ProgVisual

        public ActionResult Index2()
        {
            RegistroBasedeDatos2 da = new RegistroBasedeDatos2();
            List<RegistroPiezaAnatomica> Registrospa= da.ObtenerRegistrosPiezasAnatomicas();

            return View(Registrospa);
        }

     


        public ActionResult ProgVisual2()
            {

                RegistroPiezaAnatomica pa = new RegistroPiezaAnatomica();
              
                pa.Paciente2 = new Paciente2();
                pa.Paciente2.Nombre = Request["txtPaciente2Nombre"];
                pa.Paciente2.Apellido = Request["txtPaciente2Apellido"];
                pa.Edad2 = Convert.ToInt32(Request["txtEdad2"]);
                pa.Internación2 = Request["txtInternación2"];
                pa.Muestra2 = Request["txtMuestra2"];
                pa.Método2 = Request["SelMétodo2"];
                pa.Protocolo2 = Convert.ToInt32(Request["txtProtocolo2"]);
                pa.Especialidad2 = Request["txtEspecialidad2"];
                pa.FechadeEntrega2 = Convert.ToDateTime(Request["dtpFechadeEntrega2"]);

            RegistroBasedeDatos2 da = new RegistroBasedeDatos2();
                da.Insertar2(pa);


                return RedirectToAction("Index2");

            }

            public ActionResult CargadeDatos2()
            {


                return View();

            }


            public ActionResult Editar2(int ID)
            {
            RegistroBasedeDatos2 da = new RegistroBasedeDatos2();
                RegistroPiezaAnatomica pa = da.ObtenerRegistroPiezaAnatomica(ID);

                return View(pa);


            }

            public ActionResult Edicion2()
            {
            RegistroPiezaAnatomica pa = new RegistroPiezaAnatomica();
            pa.IdRegistroPA= Convert.ToInt32(Request["hdnID"]);
            pa.Paciente2 = new Paciente2();
            pa.Paciente2.Nombre = Request["txtPaciente2Nombre"];
            pa.Paciente2.Apellido = Request["txtPaciente2Apellido"];
            pa.Edad2 = Convert.ToInt32(Request["txtEdad2"]);
            pa.Internación2 = Request["txtInternación2"];
            pa.Muestra2 = Request["txtMuestra2"];
            pa.Método2 = Request["SelMétodo2"];
            pa.Protocolo2 = Convert.ToInt32(Request["txtProtocolo2"]);
            pa.Especialidad2 = Request["txtEspecialidad2"];
            pa.FechadeEntrega2 = Convert.ToDateTime(Request["dtpFechadeEntrega2"]);

            RegistroBasedeDatos2 da = new RegistroBasedeDatos2();
                da.Editar2(pa);

                return RedirectToAction("Index2");


            }
            public ActionResult Eliminar2(int id)
            {

            RegistroBasedeDatos2 da = new RegistroBasedeDatos2();
                RegistroPiezaAnatomica pa = da.ObtenerRegistroPiezaAnatomica(id);

                return View(pa);


            }
            public ActionResult Eliminacion2()
            {
                int ID = Convert.ToInt32(Request["hdnID"]);
            RegistroBasedeDatos2 da = new RegistroBasedeDatos2();
                da.Eliminar2(ID);

                return RedirectToAction("Index2");




            }


        
    }
    
}












