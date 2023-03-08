$.ajax({
    // la URL para la petición
    url : 'mipagweb',

    // la información a enviar
    // (también es posible utilizar una cadena de datos)
    data : { id : 123 },

    // especifica si será una petición POST o GET
    type : 'GET',

    // el tipo de información que se espera de respuesta
    dataType : 'json',

    // código a ejecutar si la petición es satisfactoria;
    // la respuesta es pasada como argumento a la función
    success : function(json) {
        $('<h1/>').text(json.title).appendTo('body');
        $('<div class="content"/>')
            .html(json.html).appendTo('body');
    },

    // código a ejecutar si la petición falla;
    // son pasados como argumentos a la función
    // el objeto de la petición en crudo y código de estatus de la petición
    error : function(xhr, status) {
        alert('Disculpe, existió un problema');
    },

    // código a ejecutar sin importar si la petición falló o no
    complete : function(xhr, status) {
        alert('Petición realizada');
    }
});         


/*

$.get Realiza una petición GET a una URL provista.
$.post Realiza una petición POST a una URL provista.
$.getScript Añade un script a la página.
$.getJSON Realiza una petición GET a una URL provista y espera que un dato JSON sea devuelto.

*/

//Utilizar el método $.fn.load para rellenar un elemento

$('#newContent').load('/foo.html');
//Utilizar el método $.fn.load para rellenar un elemento basado en un selector

$('#newContent').load('/foo.html #myDiv h1:first', function(html) {
  alert('Contenido actualizado');
});



// obtiene texto plano o html
$.get('/mipagina', { userId : 1234 }, function(resp) {
    console.log(resp);
});

// añade un script a la página y luego ejecuta la función especificada
$.getScript('/static/js/myScript.js', function() {
    functionFromMyScript();
});

// obtiene información en formato JSON desde el servidor
$.getJSON('/mipagina', function(resp) {
    $.each(resp, function(k, v) {
        console.log(k + ' : ' + v);
}); });