-- SELECT

-- Esta query nos permite buscar y obtener registros de nuestra DB

-- El asterisco es un comodin que me indica que me traiga TODOS los campos de la tabla
SELECT * FROM Rectangulos;

-- Yo puedo elegir que campos quiero que me traiga 
SELECT BASE FROM Rectangulos;

-- Si quiero traer más campos simplemente lo separo con coma
SELECT ID, BASE FROM Rectangulos;

-- Tambien podemos hacer formulas dentro del SELECT
SELECT BASE * ALTURA FROM Rectangulos;

-- Tambien podemos traer los datos de la tabla original junto con la tabla de resultados 
SELECT *, BASE * ALTURA FROM Rectangulos;

-- Podemos complejizarlo AUN más agregando perímetro 
SELECT *, BASE * ALTURA, 2*(BASE * ALTURA) FROM Rectangulos;

-- Podemos darles nombres a las columnas de resultados utilizando la query AS 
SELECT *, 
base * altura AS [AREA], 
2*(base * altura) AS [PERIMETRO] 
FROM Rectangulos;

-- Uso del WHERE para filtrar la busqueda 
SELECT * FROM Rectangulos WHERE ID = 1;

-- Uso del WHERE con los distintos operadores 
SELECT * FROM Rectangulos WHERE BASE > 30;
SELECT * FROM Rectangulos WHERE ALTURA < 30;
SELECT * FROM Rectangulos WHERE BASE != 33;

-- Uso del WHERE con las querys AND o OR
SELECT * FROM Rectangulos WHERE base = 17 OR altura = 5;
SELECT * FROM Rectangulos WHERE ID = 3 AND altura > 64;

-- Uso del WHERE con la query ORDER BY
SELECT *, base * altura AS [AREA] FROM Rectangulos ORDER BY AREA;

-- Uso del WHERE con la query ORDER BY y le sumamos ASC o DESC
SELECT *, base * altura AS [AREA] FROM Rectangulos ORDER BY BASE DESC;
SELECT *, base * altura AS [AREA] FROM Rectangulos WHERE base = 40 OR altura = 25 ORDER BY AREA ASC;