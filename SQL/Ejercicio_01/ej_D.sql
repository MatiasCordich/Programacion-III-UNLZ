/*
Mostrar todas las personas con 18 años o más 
y mostrar su nombre, apellido, edad y estatura, 
ordenadas por apellido y nombre.
*/ 

SELECT * FROM PERSONAS WHERE EDAD >= 18 ORDER BY APELLIDO, NOMBRE;

/*
Tenemos la condicion donde EDAD debe ser MAYOR O IGUAL que 18, se incluye el 18
Como me pide mostrar nombre, apellido, edad y estatura utilizo el ASTERISCO *
Ordeno por APELLIDO y NOMBRE, si no especifico sera de forma ASCENDENTE
*/ 