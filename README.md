# Punto2_PruebaTecnica_Pangea

## Requerimientos

<img src="./img_readme/requerimientos_punto2.png">

## Descripción

Se realizo una aplicacion web que permitiera la funcionalidad CRUD(Create, Read, Update, Delete) sobre la entidad "Etiquetas", la cual tenia los siguientes atributos: nombre(texto), referencia (texto), cantidad(numero entero). La aplicacion se desarrollo en la plataforma ASP.NET  con lenguaje C# y Razor (HTML + C#) para el frontend, la aplicacion se estucturo en arquitectura MVC y se conecto a una base de satos SQL por medio del ORM Entity Framework. el desarrollo de la aplicación se realizo en el IDE Visual Estudio 2019.

## Funcionamiento

Se muestra la pantalla inicial con los botones que permiten las funciones CRUD.

<img src="./img_readme/1.pantalla-inicial.png">

El usuario puede elegir la opcion de crear nuevo y se abrira un nuevo formulario donde se podran ingresar los datos de un nuevo elemento

<img src="./img_readme/2.formulario-crear.png">

Se muestra la lista de base de datos con un nuevo elemento incorporado

<img src="./img_readme/3.elemento-agregado.png">

Al elegir la opcion detalle, el programa mostrara en una nueva ventana todos los atributos del elemento consultado.

<img src="./img_readme/4.detalle-elemento.png">

Al elegir la opcio modificar, se mostrara una nueva vista con los datos del elemento permitiendo al usuario modificar estos datos.

<img src="./img_readme/5.formulario-modificado.png">

Se confirma al usuario que el elemento se modifico

<img src="./img_readme/6.confirmacion- modificado.png">

Se muestra la lista de los elementos de base de datos con los datos del elemento modificado anteriormente de forma actualizada.

<img src="./img_readme/7.vista-modificado.png">

Al usuario elegir el boton eliminar que esta en el elemento, este se eliminara de la base de datos, la aplicación lo confirmara y mostrara un vista actualizada sin el elemento eliminado.

<img src="./img_readme/8.elemento elimindao.png">