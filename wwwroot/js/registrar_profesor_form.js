$(function () {
    $("#profesor_form").validate({
        rules: {
            NoEmpleado: {
                required: true
            },
            Nombre: {
                required: true
            },
            Carrera: {
                required: true
            },
            Telefono: {
                required: true,
                digits: true
            }
        },
        messages: {
            NoEmpleado: {
                required: "Introduce el número de empleado del profesor"
            },
            Nombre: {
                required: "Introduce el nombre completo del profesor"
            },
            Carrera: {
                required: "Introduce la carrera del profesor"
            },
            Telefono: {
                required: "Introduce el teléfono del profesor",
                digits: "Introduce un número válido"
            }
        }
    });
});