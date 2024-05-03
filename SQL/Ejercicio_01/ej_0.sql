-- Crear la tabla PERSONAS

CREATE TABLE PERSONAS (
    NOMBRE VARCHAR(25),
    APELLIDO VARCHAR(25),
    EDAD INT,
    ESTATURA DECIMAL(3,2)
);

/*
Definir decimales con el tipo de dato DECIMAL

Los valores de tipo DECIMAL se leen de la siguiente manera 
(3,2) esto nos quiere decir lo sigiente: 

- 3: Van a ser la cantidad de digitos totales
- 2: De esos 3 digitos, 2 van a estar reservados para la parte decimal 
*/