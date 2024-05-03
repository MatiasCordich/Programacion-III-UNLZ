-- Actualizar la edad de todas las personas mayores de 20 a�os, sum�ndoles 2 a�os.

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
