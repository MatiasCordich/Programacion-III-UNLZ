-- Crear la tabla PERSONAS

CREATE TABLE PERSONAS (
	NOMBRE VARCHAR(25),
	APELLIDO VARCHAR(25),
	EDAD INT,
	ESTATURA DECIMAL(3,2)
)

/*
Definir decimales con el tipo de dato DECIMAL

Los valores de tipo DECIMAL se leen de la siguiente manera 
(3,2) esto nos quiere decir lo sigiente: 

- 3: Van a ser la cantidad de digitos totales
- 2: De esos 3 digitos, 2 van a estar reservados para la parte decimal 
*/

--------------------------------------------------------------------------------------------------------------------------------------------------

-- Cargar entre 10 y 20 personas

INSERT INTO PERSONAS
VALUES
    ('Juan', 'P�rez', 25, 1.75),
    ('Mar�a', 'Gonz�lez', 17, 1.60),
    ('Luis', 'Mart�nez', 22, 1.80),
    ('Ana', 'L�pez', 28, 1.65),
    ('Carlos', 'Rodr�guez', 40, 1.70),
    ('Laura', 'S�nchez', 22, 1.55),
    ('Pedro', 'Hern�ndez', 15, 1.75),
    ('Sof�a', 'D�az', 14, 1.70),
    ('Miguel', 'Ruiz', 17, 1.80),
    ('Luc�a', 'Torres', 25, 1.60); 

/*
Recordemos que los varchar (strings en SQL) se escriben siempre con COMILLAS SIMPLES
*/

--------------------------------------------------------------------------------------------------------------------------------------------------

-- A) Mostrar todas las personas con 18 a�os o mas

SELECT * FROM PERSONAS WHERE EDAD >= 18;

--------------------------------------------------------------------------------------------------------------------------------------------------

-- B) Mostrar un listado completo ordenado por estatura

-- La ESTATURA podemos ordenarla de dos formas 

-- ORDENAR DE FORMA ASCENDENTE (si no le especificamos ordena de forma ascendente por defecto)
SELECT * FROM PERSONAS ORDER BY ESTATURA;

-- ORDENAR DE FORMA DESCENDENTE
SELECT * FROM PERSONAS ORDER BY ESTATURA DESC;

--------------------------------------------------------------------------------------------------------------------------------------------------

-- C)  Mostrar el listado completo ordenado por apellido y nombre

SELECT * FROM PERSONAS ORDER BY APELLIDO, NOMBRE;

/*
Como no le especificamos va a ordenar de forma ASCENDENTE
Primero ordena por APELLIDO y por su NOMBRE respectivo
El orden ASCENDENTE empieza de la A (menor valor) hasta la Z (mayor valor)
*/

--------------------------------------------------------------------------------------------------------------------------------------------------

-- D) MOSTRAR todas las personas con 18 A�OS O M�S y mostrar su NOMBRE, APELLIDO, EDAD y ESTATURA, ORDENADAS por APELLIDO y NOMBRE.

SELECT * FROM PERSONAS WHERE EDAD >= 18 ORDER BY APELLIDO, NOMBRE;

/*
Tenemos la condicion donde EDAD debe ser MAYOR O IGUAL que 18, se incluye el 18.
Como me pide mostrar nombre, apellido, edad y estatura utilizo el ASTERISCO *
Ordeno por APELLIDO y NOMBRE, si no especifico sera de forma ASCENDENTE
*/ 

--------------------------------------------------------------------------------------------------------------------------------------------------

-- E) Eliminar todas las personas cuya edad sea exactamente 30 a�os.

DELETE FROM PERSONAS WHERE EDAD = 30;

/*
La condicion es eliminar a todas las personas cuya EDAD sea IGUAL a 30 que se eliminen
*/ 

--------------------------------------------------------------------------------------------------------------------------------------------------

-- F) Actualizar la estatura de todas las personas mayores de 1.75 metros, reduci�ndola en 0.05 metros.

UPDATE PERSONAS
SET ESTATURA = ESTATURA - 0.05
WHERE ESTATURA > 1.75;

/*
- ACTUALIZAMOS la tabla PERSONAS
- Vamos a indicar qu� COLUMNA (CAMPO) de la tabla vamos a actualizar sus valores
(ESTATURA) y de qu� forma (rest�ndole 0.05)
- Solo se modificaran los campos de las FILAS (REGISTROS) que cumplan con la siguiente
condici�n (que la ESTATURA sea mayor a 1.75 (este no incluido))
*/

--------------------------------------------------------------------------------------------------------------------------------------------------

-- G) Mostrar el nombre y apellido de la persona m�s joven.

SELECT TOP 1 NOMBRE, APELLIDO FROM PERSONAS ORDER BY EDAD;

/*
Para realizar esta consulta miremosla primero como una consulta de este estilo

SELECT NOMBRE, APELLIDO FROM PERSONAS ORDER BY EDAD;

Si seleccionarmos esa consulta lo que va a pasar es lo siguiente:

- Nos va a traer a TODAS las personas de la tabla
- Con su NOMBRE y APELLIDO
- Ordenados por su EDAD de forma ASCENDENTE (de menor a mayor)

Al agregarle TOP 1 hago que

- Me devuelva SOLO el registro que ocupe el primer lugar del orden ascendente 
- El primer lugar del orden ascente por EDAD es la persona m�s joven

*/

--------------------------------------------------------------------------------------------------------------------------------------------------

-- H) Eliminar todas las personas cuya estatura sea menor o igual a 1.60 metros.

DELETE FROM PERSONAS WHERE ESTATURA <= 1.60;

/*
- Hacemos un DELETE de la tabla PERSONAS 
- La condici�n: eliminamos las personas cuya ESTATURA sea MENOR O IGUAL que 1.60 
- El 1.60 est� inclu�do tambi�n
*/

--------------------------------------------------------------------------------------------------------------------------------------------------

-- I) Actualizar la edad de todas las personas mayores de 20 a�os, sum�ndoles 2 a�os.

UPDATE PERSONAS 
SET EDAD = EDAD + 2
WHERE EDAD > 20;

/*
- ACTUALIZAMOS la tabla PERSONAS
- Vamos a indicar qu� COLUMNA (CAMPO) de la tabla vamos a actualizar sus valores
(EDAD) y de qu� forma (sum�ndole al valor 2 unidades)
- Solo se modificaran los campos de las FILAS (REGISTROS) que cumplan con la siguiente
condici�n (que EDAD sea mayor a 20 (este no incluido) )
*/

--------------------------------------------------------------------------------------------------------------------------------------------------

-- J) Mostrar el nombre, apellido y edad de todas las personas cuya edad est� entre 25 y 35 a�os, ordenadas por edad de forma descendente.

SELECT NOMBRE, APELLIDO, EDAD FROM PERSONAS 
WHERE EDAD > 25 AND EDAD < 35 
ORDER BY EDAD DESC;

/*
- Vamos a SELECCIONAR 3 campos de la tabla PERSONAS:
	- NOMBRE
	- APELLIDO
	- EDAD
- Que me muestre a las personas con dichos campos pero con la siguiente condicion:
	- Su edad debe estar entre 25 y 35 a�os
	- Para especificar un rango necesitamos: 
		- Un valor m�nimo, es decir, que acepte valores mayores al mismo 
		- Un valor m�ximo, es decir, que acepte valores MENORES al mismo
	- Para que se cumpla el rango, ambas condiciones DEBEN CUMPLIRSE SI O SI

- Ordenar los resultados por su edad de forma DESCENDETE (Mayor a Menor)
*/

--------------------------------------------------------------------------------------------------------------------------------------------------

-- K) Eliminar todas las personas cuyo nombre sea 'Juan'.

DELETE FROM PERSONAS WHERE NOMBRE = 'Juan';

/*
Como recordatorio: NUNCA HACER UN DELETE SIN WHERE
Los varchar (Strings en SQL) SIEMPRE SE TRABAJAN CON COMILLAS SIMPLES
*/