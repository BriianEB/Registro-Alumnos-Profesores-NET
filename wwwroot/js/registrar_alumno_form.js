$().ready(function () {
    $("#alumno_form").validate({
        rules: {
            Matricula: {
                required: true
            },
            Nombre: {
                required: true
            },
            Carrera: {
                required: true
            },
            Email: {
                required: true,
                email: true
            },
            Telefono: {
                required: true,
                digits: true
            }
        },
        messages: {
            Matricula: {
                required: "Introduce la matrícula del alumno"
            },
            Nombre: {
                required: "Introduce el nombre completo del alumno"
            },
            Carrera: {
                required: "Introduce la carrera del alumno"
            },
            Email: {
                required: "Introduce el correo electrónico del alumno",
                email: "Introduce un correo electrónico válido"
            },
            Telefono: {
                required: "Introduce el teléfono del alumno",
                digits: "Introduce un número válido"
            }
        }
    });
});