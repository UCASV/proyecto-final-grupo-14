# SINAVACC-19 / proyecto-final-grupo-14

_Este proyecto tiene como fin poner en práctica lo aprendido en Programación Orientada a Objetos y Bases de Datos durante el ciclo 01/2021. El proyecto consiste en realizar una
aplicación de escritorio conectada a una base de datos que pueda ser usada en cabinas de atención a lo largo del territorio nacional para la programación y seguimiento de citas
de vacunación contra el COVID-19, esto para acelerar el proceso de inmunización de la población salvadoreña y para poder llegar a aquellas zonas con ciudadanos vulnerables que
no disponen de acceso a recursos tecnologicos. Nuestra plataforma consiste, principalmente, en cuatro modulos que servirán para registrar a los ciudadanos y determinar si 
pertenecen o no a grupos de riesgo o primera línea, generar citas para que estos sean vacunados, visualizar la información y las citas almacenadas del ciudadano y dar seguimiento
al proceso de vacunación._ 

## Detalles técnicos 🛠️

### Sistema Operativo de 64bits 💻

Construido con:

* [Jetbrains RIDER](https://www.jetbrains.com/es-es/rider/) - _IDE .NET, usado para desarrollar el proyecto V 2021.1.3_
* [Microsoft SQL SERVER](https://go.microsoft.com/fwlink/?linkid=866658) - _Usado para la configuración y administración de la base de datos V SSMS 18_
* [.NET CORE](https://dotnet.microsoft.com/download/dotnet/5.0) - _Framework utilizado V 5.0
* [MS Entity Framework Core](https://www.nuget.org/packages/Microsoft.EntityFrameworkCore/5.0.7) - _Usado para la conexión de nuestra plataforma con la BD V 5.0.7_

Patrón de diseño imprementado: **Repository**
Para los servicios de los modulos, porque hace mas facil el uso y manipulacion del context y mas sencillo manipular datos de la base de datos.



Manual de Usuario 📖

_Consultalo en:_
[SINAVACC-19 MANUAL DE USUARIO](https://github.com/UCASV/proyecto-final-grupo-14/blob/master/PROYECTO%20BASES-POO%202021/POO/SINAVACC-19%20Manual%20de%20Usuario.pdf) 



## Instalación 🔧

_Para ejecutar el proyecto necesitas:_
* Jetbrains Rider
* SQL EXPRESS, SSMS
* .NET CORE 5.0
* Paquete nuget: Microsoft.EntityFrameworkCore, Microsoft.EntityFrameworkCore.SqlServer, Microsoft.EntityFrameworkCore.Design

💡 Descarga [SINAVACC-19](https://github.com/UCASV/proyecto-final-grupo-14/releases/tag/v1.0) - _contiene los archivos que necesitas para ejecutar el proyecto_

💡 Abre en el SSMS el archivo COVIDVACCDB.script y LoginRecord_StoredProcedure.sql, ejecutalos

💡 Abre la solución COVIDVACCSYSTEM en JETBRAINS RIDER

💡 En DATABASE, en la barra derecha, añade un nuevo DATASOURCE con SQLEXPRESS como instancia y COVIDVACCDB como base de datos.
O copia y pega lo siguiente en URL:

```
jdbc:sqlserver://localhost\SQLEXPRESS;database=COVIDVACCDB
```
💡 Ejecuta y disfruta 🌈

## Autores ✒️

* **Edwin Gonzalez** - [edwinma3046](https://github.com/edwinma3046)
* **Joel Barrera** - [cyfer2410](https://github.com/cyfer2410)
* **Felipe Araujo** - [FPG02](https://github.com/FPG02)
* **Alicia Linares** - [aligra](https://github.com/aligra)

## Gracias 🎁

* De parte de todo el equipo, agradecemos a los catedraticos de ambas materias y a los instructores por compartir su conocimiento con nosotros ♥

---
