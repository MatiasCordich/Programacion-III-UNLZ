-- SELECT

-- Es un sentencia donde me devuelve los datos de una DB
-- Esta misma la realizo desde una DB seleccionando una columna en especifico
-- Su estrcutura es SELECT columna_1, columna_2, columna_2 FROM nombredb.nombretabla
-- Existen varias maneras de hacer un select 

-- Supongamos que tenemos la DB databasestack cuya DB tiene la tabla llamada users y esa tabla esta conformada de la siguiente manera 

/*
TABLA users
+---------+--------+---------+-----+------------+--------------------+
| id_user | name   | surname | age | init_date  | email              |
+---------+--------+---------+-----+------------+--------------------+
|    1    | Juan   | Perez   |  30 | 1990-05-15 | juan@example.com   |
|    2    | Maria  | NULL    | NULL| 1995-06-04 | maria@example.com  |
|    3    | Alfredo| NULL    |  25 | 1999-02-06 | alfredo@example.com|
|    4    | Esteban| Gómez   | NULL| 1988-11-25 | esteban@example.com|
|    5    | Ester  | NULL    |  35 | 1989-02-10 | ester@example.com  |
+---------+--------+---------+-----+------------+--------------------+
*/

-- Traer todos los datos (usamos para no poner todos los campos de la tabla utilizamos un asterisco *)
SELECT * FROM users;

-- Traer un dato en especifico (solo traera el name)
SELECT name FROM users;

-- Traer dos o mas datos segun la necesidad (va a traer el id_user y el name de la tabla)
SELECT id_user, name FROM users;