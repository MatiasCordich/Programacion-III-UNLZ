-- Actualizar la edad de todas las personas mayores de 20 años, sumándoles 2 años.

UPDATE PERSONAS 
SET EDAD = EDAD + 2
WHERE EDAD > 20;

/*
- ACTUALIZAMOS la tabla PERSONAS
- Vamos a indicar qué COLUMNA (CAMPO) de la tabla vamos a actualizar sus valores
(EDAD) y de qué forma (sumándole al valor 2 unidades)
- Solo se modificaran los campos de las FILAS (REGISTROS) que cumplan con la siguiente
condición (que EDAD sea mayor a 20 (este no incluido) )
*/
