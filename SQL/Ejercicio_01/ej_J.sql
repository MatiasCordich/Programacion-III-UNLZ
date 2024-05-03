/*
Mostrar el nombre, apellido y edad 
de todas las personas 
cuya edad est� entre 25 y 35 a�os, 
ordenadas por edad de forma descendente.
*/

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