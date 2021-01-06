# API y aplicación de escritorio

##### Este es un proyecto de prueba en el cual se consumen los servicioes expuestos por un API desde una aplicación de escritorio. Está creada en .NET Core y Postgres. Se utilzia en lenguaje C# y el CRUD en la base de datos es mediante Procedimientos Almacenados.

Requerimientos:
- .NET Core 3.1
- Postgres 13
- Nugets:
    - Npgsql.EntityFrameworkCore.PostgreSQL, 
    - Microsoft.EntityFrameworkCore,

La aplicación permite el registro de usuarios.

La carpeta <<Scripts Creacion, Schema y Registros de BD>> contiene 3 scripts para crear la base de datos, agregar todo el schema e insertar los parámetros correspondientes a los países, estados o departamentos y ciudades. 

Una vez se ejecuten los scripts de la base de datos se debe correr primero el servicio y luego la aplicación de escritorio como una nueva instancia.

Modelo Entidad Relación: La tabla de registro de Usuarios sólo se relaciona con la tabla de Ciudad. Ésta permite la relación a la table de los Estados o Departamentos y ésta a su vez con la tabla definida para los Países.
