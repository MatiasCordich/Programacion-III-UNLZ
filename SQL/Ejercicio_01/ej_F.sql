/*
Actualizar la estatura 
de todas las personas mayores de 1.75 metros, 
reduciéndola en 0.05 metros.
*/

UPDATE PERSONAS
SET ESTATURA = ESTATURA - 0.05
WHERE ESTATURA > 1.75;

/*
- ACTUALIZAMOS de la tabla PERSONAS
- Vamos a indicar qué COLUMNA queremos actualizar y cómo (restándole 0.05)
- Aplicamos la condición que deben cumpliar las filas para que se aplique la actualización
*/
