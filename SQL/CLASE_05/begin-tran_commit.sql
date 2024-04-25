-- BEGIN TRAN y COMMIT

-- Vamos a hacer un caso donde hacemos un UPDATE

-- Iniciamos la transacción
BEGIN TRAN;

-- Hacemos un UPDATE
UPDATE Rectangulos
SET ALTURA = 28,
	BASE = 17
WHERE ID = 4; -- Esta sentencia es incorrecta y me va a editar el registro con ID 4 de la tabla rectangulo

-- Verificamos si la actualizacion se realizó bien 
SELECT * FROM Rectangulos WHERE ID = 4;

-- Si todo salió bien, confirmo los cambios
COMMIT;

-- Verificamos si se aplicó el COMMIT correctamente
SELECT * FROM Rectangulos;