-- BEGIN TRAN y ROLLBACK

-- Vamos a hacer un caso donde hacemos un DELETE sin WHERE y tenemos que usar el WHERE

-- Iniciamos la transacci�n
BEGIN TRAN;

-- Hacemos un DELETE sin WHERE
DELETE FROM Rectangulos; -- Esta sentencia es incorrecta y me va a borrar todos los registros

-- Verificamos que hay en la DB
SELECT * FROM Rectangulos; -- Como la sentencia anterior esta mal no va a haber ningun registro, hay un error

-- Algo sali� mal, deshacemos los cambios
ROLLBACK;

-- Verificamos si se aplic� el ROLLBACK
SELECT * FROM Rectangulos;
