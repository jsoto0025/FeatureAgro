# Ejecución de un proyecto derivado de FutureAgro

## Requisitos

1. Visual Studio 2017 Community Edition ó posterior.
2. .Net Core 2.1 instalado.
3. SQL Server 2015 o posterior.

## Creación de la Base de datos

1. Abrir Sql Server Management Studio.
2. Abrir el script 1-DB Creation.sql que se encuentra en la ruta: DB Scripts.
3. Ejecutar el script 1-DB Creation.sql.
4. Abrir el script 2-UserIdentity tables and initial user.sql que se encuentra en la ruta: DB Scripts.
5. Ejecutar el script 2-UserIdentity tables and initial user.sql.
6. Modificar el string de conexión del archivo appsettings.json que se encuentra en el directorio: DerivedProjects\Project1\Derivacion Completa\FutureAgro\appsettings.json

## Ejecución de un proyecto derivado.

1. Abrir el contenido de la carpeta: DerivedProjects\Project#\Derivacion Completa, donde # es el consecutivo del proyecto que se derivo.
2. Abrir Visual Studio.
3. Abrir la solució FutureAgro.sln que esta en la raiz del directorio del paso 1.
4. Limpiar la solución.
5. Compilar la solución.
6. Ejecutar el proyecto FutureAgro.Web.csproj.
7. Se abrira el proyecto en el Browser
