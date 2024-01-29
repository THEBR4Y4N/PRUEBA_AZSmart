# Prueba Técnica para Desarrollador Junior .NET

**Presentado por: Brayan Andres Garzón Lopez**

**Objetivo:**

Desarrollar una aplicación web simplificada de gestión de biblioteca utilizando ASP.NET MVC que permita a los usuarios ver, agregar libros y autores.
### Configuración del proyecto:

Para el correcto funcionamiento de este proyecto, se deben tener instalados los siguientes elementos en el equipo:
1. SQL SERVER
2. Visual Studio
2.1. tener instalado y configurado el paquete de compatibilidad del [.NET 6.0](https://dotnet.microsoft.com/es-es/download/dotnet/6.0 ".NET 6.0")
3. Git
   
### **Instrucciones**: 

#### 1. Clonar el repositorio


Para clonar el repositorio deberá seguir los siguientes pasos:

  -  Abrir Git Bash.

  -   Cambia el directorio de trabajo actual a la ubicación en donde quieres clonar el directorio.

  -   Escribir el siguiente comando:

  ***git clone https://github.com/THEBR4Y4N/PRUEBA_AZSmart.git***

  -   Presionar enter y esperar a que se descargue completamente el proyecto.

#### 2. Configuración de la base de datos:

Para la configuración de la base de datos, se deberán seguir los siguientes pasos: 

   - Ejecutar el SQL SERVER
     
**Nota:** En esta se deberá tener una instancia local creada (para este proyecto se utilizó una llamada **"localhost"**) y en esta tener una base de datos llamada **Pruebas** (de ser requerido se deberá crear).
En caso de no querer utilizar dichas instancias, se pueden usar las que estén disponibles en el momento, pero tanto el nombre de la instancia como el nombre de la base de datos, se deben tener en cuenta para más adelante.

   - Una vez establecida la conexión con el servidor o instancia del punto anterior, se deberá ejecutar un Script para crear las respectivas tablas, para ello, deberá descargar el siguiente [Archivo](https://drive.google.com/uc?export=download&id=1P69PCjlECmlz2NvWF9CddG8mkNoFckzj "Archivo").
   
   **Nota:** el contenido de este archivo puede ser ejecutado directamente desde el SQL SERVER o abriéndolo con un editor de texto  y copiando su contenido y ejecutarlo directamente en el editor de Scripts del SQL Server.
   
   - Una vez ejecutado el Script anterior, podrá validar la existencia de las tablas ejecutando los siguientes comandos:
   
   		   Select * from Autor
     
   		   Select * from Libros

#### 3. Configuración y Ejecución del proyecto:

Una vez realizados los ítems anteriores,  podremos ejecutar el proyecto, para ello:

- Ejecutaremos el visual Studio

- Buscaremos la solución del proyecto, para ello localizaremos el proyecto descargado en el ítem **1**

- Una vez abierto el proyecto, buscaremos el archivo llamado **"appsettings.json"** , y en el buscaremos el apartado llamado **"ConnectionStrings"**.

- Una vez situados en esta parte, deberemos editar la siguiente línea:
  
      "Conexion": "Server=localhost;Database=Pruebas;Trusted_Connection=True;"

Donde reemplazaremos **Database** = **"Nombre de la base de datos creada"** y **Server** = **"Nombre de la instancia local seleccionada"**

**Nota:** En caso de no haber tenido en cuenta las indicaciones del ítem **2** o de no haber sido ser requerido, saltar al paso siguiente. 

- Ejecutar el proyecto presionando el botón **F5** en el teclado o ejecutando de la manera tradicional en el Visual Studio.


### Funcionalidades:
1) **Home** (pantalla de inicio).
[![HOME.png](https://i.postimg.cc/x1cQsJMB/HOME.png)](https://postimg.cc/18hbXzWK)
2) **Libros** (Lista de los libros registrados en el sistema).
[![Libros.png](https://i.postimg.cc/13nx0xZQ/Libros.png)](https://postimg.cc/CRg6YQ1P)
3) **Registro de libros** (Formulario para el ingreso de libros con su respectivo autor).
[![Registrar-Libro.png](https://i.postimg.cc/d3tpLp9g/Registrar-Libro.png)](https://postimg.cc/ftpBPHpv)
4) **Autores** (Lista de los libros registrados en el sistema).
[![Autores.png](https://i.postimg.cc/tCcw4rnm/Autores.png)](https://postimg.cc/crQXDBmQ)
5) **Registro de libros** (Formulario para el ingreso de un autor a la base de datos).
[![Registrar-autor.png](https://i.postimg.cc/zDtPxd7X/Registrar-autor.png)](https://postimg.cc/5jz30SDZ)
### Repositorio:
En el siguiente [Enlace](https://github.com/THEBR4Y4N/PRUEBA_AZSmart "Enlace"), encontraras el repositorio de este proyecto.
### Diagrama Entidad Relación:
A continuación, veremos el diagrama entidad relación de este proyecto:
[![Diagrama-entidad-relaci-n.png](https://i.postimg.cc/tCFWsJsQ/Diagrama-entidad-relaci-n.png)](https://postimg.cc/mt2tqb38)
