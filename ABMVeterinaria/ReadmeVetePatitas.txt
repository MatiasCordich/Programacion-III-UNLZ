ABMVETERINARIA

Es una aplicación de Windows Forms diseñada para ofrecer a los usuarios una solución eficiente para el registro y la edición de entidades asociadas, tales como clientes, animales, especies y usuarios. La aplicación facilita el almacenamiento y la organización de estos datos, mejorando la gestión y el acceso a la información crítica para la operación diaria de una veterinaria.

CARACTERÍSTICAS PRINCIPALES
La aplicación ofrece las siguientes funcionalidades:

Inicio de sesión: Acceso de usuarios mediante un nombre y clave.
Altas: Registro de nuevas entidades en la base de datos mediante formularios estructurados.
Bajas: Eliminación  de entidades, mediante un estado inactivo/difunto..
Reactivaciones: Restauración de entidades desactivadas previamente para asegurar la continuidad de acciones..
Reportes: Generación de 2 informes personalizados basados en datos almacenados.


REQUISITOS

Brindaremos información para setear el windows forms app junto a su acceso a la base de datos creada en SQL Management Server. Para asegurar el correcto funcionamiento de ABM Veterinaria, el sistema debe cumplir con los siguientes requisitos mínimos:

Sistema Operativo: Windows 7 o superior.
Framework: .NET Framework 4.7.2 o superior.

INSTRUCTIVO DE INSTALACIÓN

Paso 1: Descargar el comprimido .ZIP
Descargar el archivo .zip pertinente, una vez hecho descomprimimos el archivo. 

Paso 2: Creación de la base de datos
Se crea la base de datos en el SQL Management Studio, el nombre es a elección del usuario

Paso 3: Creación de las tablas
A la base de datos creada con click derecho vamos a crear una nueva Query. 
Vamos a copiar las querys  del archivo SQL que hay en la carpeta de ABM Veterinaria. 
Además de las tablas se crearán valores iniciales en las tablas:
Usuarios: Se crea de primera el usuario pepe cuya contraseña es 1234
Especies: El primer registro será ‘Sin especificar’, 0, 0.0

Paso 4: Ejecución de la Aplicación en Visual Studio. 
Ejecutamos la aplicación en visual studio, tendremos un login donde ingresamos el usuario ya cargado. 

Posible caso de error de ejecución
En el caso que aparezca el siguiente error:

No se puede procesar el archivo FormularioPrincipal.resx porque está en Internet o en una zona restringida, o bien tiene la marca de la Web. Quite esta marca si desea procesar los archivos. VeterinariaClient
Para resolver este problema, debemos eliminar la marca de seguridad del archivo, siguiendo estos pasos:
Ubica el archivo FormularioPrincipal.resx en tu sistema de archivos:
Navega hasta la carpeta del proyecto donde está ubicado el archivo FormularioPrincipal.resx.
Elimina la marca de seguridad:
Haz clic derecho sobre el archivo FormularioPrincipal.resx.
Selecciona "Propiedades" en el menú contextual.
En la pestaña "General", busca una sección que dice "Seguridad" o "Security" cerca de la parte inferior.
Si ves un botón que dice "Desbloquear" o "Unblock", haz clic en él.
Haz clic en "Aplicar" y luego en "Aceptar" para cerrar la ventana de propiedades.
Reinicia Visual Studio:
Cierra y vuelve a abrir Visual Studio para asegurarte de que los cambios surtan efecto.
Con estos pasos se debería resolver el problema en caso de suceder. 

CONTACTO 
Para consultas o soporte técnico, por favor, contacte a través de los siguientes correos electrónicos [mscordich@gmail.com, abril.olivera2003@gmail.com, buggenthin15@gmail.com].
