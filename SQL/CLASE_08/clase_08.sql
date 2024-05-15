-- Creamos la tabla
CREATE TABLE ANIMALES(
	ID INT PRIMARY KEY,
	NOMBRE VARCHAR(50)
)

SELECT * FROM ANIMALES

-- Modificamos la tabla para agregarle el campo ESPECIE
-- Tiene que ser NO NULO 
-- Los registros previos, donde su valor es NULO, su default Perro
ALTER TABLE ANIMALES 
ADD ESPECIE VARCHAR(20) NOT NULL DEFAULT 'Perro'

-- Nuevos registros ahora con el valor ESPECIE
INSERT INTO ANIMALES VALUES 
(1, 'Kitty', 'Gato'),
(2, 'Cinammoroll', 'Perro'),
(3, 'Pompompurin', 'Perro'),
(4, 'MyMelody', 'Conejo'),
(5, 'Kuromi', 'Conejo'),
(6, 'Pochacco', 'Perro'),
(7, 'Keroppi', 'Rana'),
(8, 'Chococat', 'Gato'),
(9, 'Badz Maru', 'Pajaro'),
(10, 'Tuxedosam', 'Pajaro')

-- Modificamos la tabla para agregarle el campo EDAD
-- Tiene que ser NO NULO 
-- Los registros previos, donde su valor es NULO, su default es 0
ALTER TABLE ANIMALES 
ADD EDAD INT NOT NULL DEFAULT 0

-- Todo lo que agregemos ahora debe tener edad 
INSERT INTO ANIMALES VALUES 
(11, 'Pirulina', 'Marmota', 20),
(12, 'Trotsky', 'Gato', 10),
(13, 'Shamoun', 'Ballena', 35),
(14, 'Keiko', 'Ballena', 40)

-- Agrupame por ESPECIE
-- De cada grupo que muestre: el mas viejo y con el ID mas bajo
SELECT ESPECIE, MAX(EDAD) AS [MAS VIEJITO], MIN(ID) AS [MIN ID]
FROM ANIMALES
GROUP BY ESPECIE

-- Agrupame por especie
-- Cuenta la cantidad que hay en cada grupo
-- Que me ordene por orden descendente
SELECT ESPECIE, COUNT(*) AS [CANTIDAD]
FROM ANIMALES
GROUP BY ESPECIE
ORDER BY CANTIDAD DESC

--  Agrupame por especie
-- Dame la cantidad de cada grupo
-- Mostrame el promedio de edad de cada grupo
-- Mostrame el mas viejo de cada grupo
-- Que la cantidad de cada grupo sea de mayor a menor
SELECT ESPECIE, 
COUNT(*) AS CANTIDAD, 
AVG(EDAD) AS PROMEDIO_EDAD,
MAX(EDAD) AS MAX_EDAD
FROM ANIMALES
GROUP BY ESPECIE
ORDER BY CANTIDAD DESC; 

-- Mostrame un TOP 3 de la especie gato que son mas viejos
SELECT TOP 3 * FROM ANIMALES WHERE ESPECIE = 'GATO'
ORDER BY EDAD DESC

-- Muestra los primeros 3 nombres de la tabla animales
-- Que sean los mas viejos
-- Donde la especie sea gato o perro
-- Los ordena por edad 
SELECT TOP 3 NOMBRE
FROM ANIMALES 
WHERE ESPECIE in ('GATO', 'PERRO')
ORDER BY EDAD DESC

-- Muestra los primeros 3 nombres de la tabla animales
-- Donde la especie NO SEA gato o perro
-- Los ordena por edad 
SELECT TOP 3 NOMBRE
FROM ANIMALES 
WHERE ESPECIE NOT IN ('GATO', 'PERRO')
ORDER BY EDAD DESC




