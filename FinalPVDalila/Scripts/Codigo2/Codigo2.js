function ValidarFormulario2() {

    var divErrores = document.getElementById("divErrores");
    var inputPaciente2Nombre = document.getElementById("txtPaciente2Nombre");

    if (inputPaciente2Nombre.value == "") {

        //alert("Por favor, ingrese un valor");

        divErrores.innerHTML = "Por favor, ingrese un nombre";
        inputPaciente2Nombre.style.borderColor("red");

        return false;
    }

    function BorrarErrores2() {

        var divErrores = document.getElementById("divErrores");
        var inputPaciente2Nombre = document.getElementById("txtPaciente2Nombre");
        inputPaciente2Nombre.style.borderColor("");
        divErrores.innerHTML = "";
    }

    function ValidarFormulario2() {

        var divErrores = document.getElementById("divErrores");
        var inputPaciente2Apellido = document.getElementById("txtPaciente2Apellido");

        if (inputPaciente2Apellido.value == "") {


            divErrores.innerHTML = "Por favor, ingrese un apellido";
            inputPaciente2Apellido.style.borderColor("red");

            return false;
        }

    }


    function BorrarErrores2() {

        var divErrores = document.getElementById("divErrores");
        var inputPaciente2Apellido = document.getElementById("txtPaciente2Apellido");
        inputPaciente2Apellido.style.borderColor("");
        divErrores.innerHTML = "";
    }



    function ValidarFormulario2() {

        var divErrores = document.getElementById("divErrores");
        var inputEdad2 = document.getElementById("txtEdad2");

        if (inputEdad2.value == "") {


            divErrores.innerHTML = "Por favor, ingrese un edad";
            inputEdad2.style.borderColor("red");

            return false;
        }

    }


    function BorrarErrores2() {

        var divErrores = document.getElementById("divErrores");
        var inputEdad2 = document.getElementById("txtEdad2");
        inputEdad2.style.borderColor("");
        divErrores.innerHTML = "";
    }


    function ValidarFormulario2() {

        var divErrores = document.getElementById("divErrores");
        var inputInternación2 = document.getElementById("txtInternación2");

        if (inputInternación2.value == "") {


            divErrores.innerHTML = "Por favor, ingrese un destino de internación";
            inputInternación2.style.borderColor("red");

            return false;
        }

    }


    function BorrarErrores2() {

        var divErrores = document.getElementById("divErrores");
        var inputInternación2 = document.getElementById("txtInternación2");
        inputInternación2.style.borderColor("");
        divErrores.innerHTML = "";
    }


    function ValidarFormulario2() {

        var divErrores = document.getElementById("divErrores");
        var inputMuestra2 = document.getElementById("txtMuestra2");

        if (inputMuestra2.value == "") {


            divErrores.innerHTML = "Por favor, ingrese una muestra válida";
            inputMuestra2.style.borderColor("red");

            return false;
        }

    }


    function BorrarErrores2() {

        var divErrores = document.getElementById("divErrores");
        var inputMuestra2 = document.getElementById("txtMuestra2");
        inputMuestra2.style.borderColor("");
        divErrores.innerHTML = "";
    }


    function ValidarFormulario2() {

        var divErrores = document.getElementById("divErrores");
        var inputMétodo2 = document.getElementById("txtMétodo2");

        if (inputMétodo2.value == "") {


            divErrores.innerHTML = "Por favor, ingrese un Método";
            inputMétodo2.style.borderColor("red");

            return false;
        }

    }


    function BorrarErrores2() {

        var divErrores = document.getElementById("divErrores");
        var inputMétodo2 = document.getElementById("txtMétodo2");
        inputMétodo2.style.borderColor("");
        divErrores.innerHTML = "";
    }

    function ValidarFormulario2() {

        var divErrores = document.getElementById("divErrores");
        var inputProtocolo2 = document.getElementById("txtProtocolo2");

        if (inputProtocolo2.value == "") {


            divErrores.innerHTML = "Por favor, ingrese un número de protocolo";
            inputProtocolo2.style.borderColor("red");

            return false;
        }

    }


    function BorrarErrores2() {

        var divErrores = document.getElementById("divErrores");
        var inputProtocolo2 = document.getElementById("txtProtocolo2");
        inputProtocolo2.style.borderColor("");
        divErrores.innerHTML = "";
    }


    function ValidarFormulario2() {

        var divErrores = document.getElementById("divErrores");
        var inputEspecialidad2 = document.getElementById("txtEspecialidad2");

        if (inputEspecialidad2.value == "") {


            divErrores.innerHTML = "Por favor, ingrese la especialidad que envia la muestra";
            inputEspecialidad2.style.borderColor("red");

            return false;
        }

    }


    function BorrarErrores2() {

        var divErrores = document.getElementById("divErrores");
        var inputEspecialidad2= document.getElementById("txtEspecialidad2");
        inputEspecialidad2.style.borderColor("");
        divErrores.innerHTML = "";
    }

    function ValidarFormulario2() {

        var divErrores = document.getElementById("divErrores");
        var inputFechadeEntrega2 = document.getElementById("txtFechadeEntrega2");

        if (inputFechadeEntrega2.value == "") {


            divErrores.innerHTML = "Por favor, ingrese la fecha de entrega2";
            inputFechadeEntrega2.style.borderColor("red");

            return false;
        }

    }


    function BorrarErrores2() {

        var divErrores = document.getElementById("divErrores");
        var inputFechadeEntrega2 = document.getElementById("txtFechadeEntrega2");
        inputFechadeEntrega2.style.borderColor("");
        divErrores.innerHTML = "";
    }


}