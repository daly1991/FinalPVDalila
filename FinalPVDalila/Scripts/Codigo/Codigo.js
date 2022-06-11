function ValidarFormulario() {

    var divErrores = document.getElementById("divErrores");
    var inputPacienteNombre = document.getElementById("txtPacienteNombre");

    if (inputPacienteNombre.value == "") {

        //alert("Por favor, ingrese un valor");

        divErrores.innerHTML = "Por favor, ingrese un nombre";
        inputPacienteNombre.style.borderColor("red");

        return false;
    }

    function BorrarErrores() {

        var divErrores = document.getElementById("divErrores");
        var inputPacienteNombre = document.getElementById("txtPacienteNombre");
        inputPacienteNombre.style.borderColor("");
        divErrores.innerHTML = "";
    }

    function ValidarFormulario() {

        var divErrores = document.getElementById("divErrores");
        var inputPacienteApellido = document.getElementById("txtPacienteApellido");

        if (inputPacienteApellido.value == "") {


            divErrores.innerHTML = "Por favor, ingrese un apellido";
            inputPacienteApellido.style.borderColor("red");

            return false;
        }

    }


    function BorrarErrores() {

        var divErrores = document.getElementById("divErrores");
        var inputPacienteApellido = document.getElementById("txtPacienteApellido");
        inputPacienteApellido.style.borderColor("");
        divErrores.innerHTML = "";
    }



    function ValidarFormulario() {

        var divErrores = document.getElementById("divErrores");
        var inputEdad = document.getElementById("txtEdad");

        if (inputEdad.value == "") {


            divErrores.innerHTML = "Por favor, ingrese un edad";
            inputEdad.style.borderColor("red");

            return false;
        }

    }


    function BorrarErrores() {

        var divErrores = document.getElementById("divErrores");
        var inputEdad = document.getElementById("txtEdad");
        inputEdad.style.borderColor("");
        divErrores.innerHTML = "";
    }


    function ValidarFormulario() {

        var divErrores = document.getElementById("divErrores");
        var inputInternación = document.getElementById("txtInternación");

        if (inputInternación.value == "") {


            divErrores.innerHTML = "Por favor, ingrese un destino de internación";
            inputInternación.style.borderColor("red");

            return false;
        }

    }


    function BorrarErrores() {

        var divErrores = document.getElementById("divErrores");
        var inputInternación = document.getElementById("txtInternación");
        inputInternación.style.borderColor("");
        divErrores.innerHTML = "";
    }


    function ValidarFormulario() {

        var divErrores = document.getElementById("divErrores");
        var inputMuestra = document.getElementById("txtMuestra");

        if (inputMuestra.value == "") {


            divErrores.innerHTML = "Por favor, ingrese una muestra válida";
            inputMuestra.style.borderColor("red");

            return false;
        }

    }


    function BorrarErrores() {

        var divErrores = document.getElementById("divErrores");
        var inputMuestra = document.getElementById("txtMuestra");
        inputMuestra.style.borderColor("");
        divErrores.innerHTML = "";
    }


    function ValidarFormulario() {

        var divErrores = document.getElementById("divErrores");
        var inputMétodo = document.getElementById("txtMétodo");

        if (inputMétodo.value == "") {


            divErrores.innerHTML = "Por favor, ingrese un Método";
            inputMétodo.style.borderColor("red");

            return false;
        }

    }


    function BorrarErrores() {

        var divErrores = document.getElementById("divErrores");
        var inputMétodo = document.getElementById("txtMétodo");
        inputMétodo.style.borderColor("");
        divErrores.innerHTML = "";
    }

    function ValidarFormulario() {

        var divErrores = document.getElementById("divErrores");
        var inputProtocolo = document.getElementById("txtProtocolo");

        if (inputProtocolo.value == "") {


            divErrores.innerHTML = "Por favor, ingrese un número de protocolo";
            inputProtocolo.style.borderColor("red");

            return false;
        }

    }


    function BorrarErrores() {

        var divErrores = document.getElementById("divErrores");
        var inputProtocolo = document.getElementById("txtProtocolo");
        inputProtocolo.style.borderColor("");
        divErrores.innerHTML = "";
    }


    function ValidarFormulario() {

        var divErrores = document.getElementById("divErrores");
        var inputEspecialidad = document.getElementById("txtEspecialidad");

        if (inputEspecialidad.value == "") {


            divErrores.innerHTML = "Por favor, ingrese la especialidad que envia la muestra";
            inputEspecialidad.style.borderColor("red");

            return false;
        }

    }


    function BorrarErrores() {

        var divErrores = document.getElementById("divErrores");
        var inputEspecialidad = document.getElementById("txtEspecialidad");
        inputEspecialidad.style.borderColor("");
        divErrores.innerHTML = "";
    }

    function ValidarFormulario() {

        var divErrores = document.getElementById("divErrores");
        var inputFechadeEntrega = document.getElementById("txtFechadeEntrega");

        if (inputFechadeEntrega.value == "") {


            divErrores.innerHTML = "Por favor, ingrese la fecha de entrega";
            inputFechadeEntrega.style.borderColor("red");

            return false;
        }

    }


    function BorrarErrores() {

        var divErrores = document.getElementById("divErrores");
        var inputFechadeEntrega = document.getElementById("txtFechadeEntrega");
        inputFechadeEntrega.style.borderColor("");
        divErrores.innerHTML = "";
    }


}