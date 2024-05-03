/*
Actualizar la estatura 
de todas las personas mayores de 1.75 metros, 
reduci�ndola en 0.05 metros.
*/

UPDATE PERSONAS
SET ESTATURA = ESTATURA - 0.05
WHERE ESTATURA > 1.75;

/*
- ACTUALIZAMOS de la tabla PERSONAS
- Vamos a indicar qu� COLUMNA queremos actualizar y c�mo (rest�ndole 0.05)
- Aplicamos la condici�n que deben cumpliar las filas para que se aplique la actualizaci�n
*/
