# Gestor de Equipos de Fútbol

Este proyecto consiste en el desarrollo de una aplicación de escritorio utilizando WPF (Windows Presentation Foundation) y C# para administrar equipos de fútbol que participarán en un campeonato semestral. La aplicación permite realizar operaciones básicas como agregar, listar, actualizar y eliminar equipos de la competición.

## Requerimientos del Cliente

El gobierno de una región ha encargado el desarrollo de esta aplicación para gestionar los equipos de fútbol que participarán en un campeonato semestral. Se deben cumplir los siguientes requisitos:

- Utilizar WPF (Windows Presentation Foundation) y C# para el desarrollo, con XAML como lenguaje de interfaz de usuario.
- Crear una pantalla principal con un menú que incluya las opciones de "Equipo" y "Información".
- Desarrollar las siguientes pantallas:
  - AgregarEquipo
  - ListarEquipos
  - ActualizarEquipo
  - AcercaDe
- Implementar una clase estática para almacenar los equipos.
- La pantalla AgregarEquipo debe tener un formulario para ingresar nuevos equipos.
- La pantalla ListarEquipos debe mostrar todos los equipos en una grilla de datos con botones de actualizar y eliminar.
- La pantalla AcercaDe debe mostrar información del desarrollador y el año de desarrollo.
- Todos los controles deben tener nombres descriptivos.
- El campo CantidadJugadores debe aceptar solo números.

## Instalación

Para ejecutar la aplicación, se requiere Visual Studio con soporte para desarrollo de aplicaciones WPF y SQL Server Management Studio (SSMS) para la gestión de la base de datos MSSQL Server 2022.

1. Clona o descarga el repositorio en tu máquina local.
2. Abre el proyecto en Visual Studio.
3. Configura la conexión a la base de datos MSSQL Server 2022 en la configuración de la aplicación.
4. Compila y ejecuta el proyecto.

## Uso

Una vez ejecutada la aplicación, podrás realizar las siguientes acciones:

- **Agregar Equipo:** Ingresa los datos de un nuevo equipo en la pantalla AgregarEquipo.
- **Listar Equipos:** Visualiza todos los equipos registrados y realiza acciones de actualización y eliminación en la pantalla ListarEquipos.
- **Actualizar Equipo:** Modifica los datos de un equipo existente en la pantalla ActualizarEquipo.
- **Acerca De:** Obtiene información sobre el desarrollador y el año de desarrollo de la aplicación en la pantalla AcercaDe.

## Autor

Jose Contreras Stoltze
