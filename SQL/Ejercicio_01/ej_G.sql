-- Mostrar el nombre y apellido de la persona más joven.

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
- El primer lugar del orden ascente por EDAD es la persona más joven

*/