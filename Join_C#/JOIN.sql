-- Creando las tablas
CREATE TABLE Casas (
	ID INT PRIMARY KEY IDENTITY,
	Direccion VARCHAR(100) 
)

CREATE TABLE Personas (
	ID INT PRIMARY KEY IDENTITY, 
	Nombre VARCHAR(55) NOT NULL,
	CasaID INT,
	FOREIGN KEY (CasaID) REFERENCES Casas(ID)
) 

-- Insertando registros en la tabla Casas
INSERT INTO Casas (Direccion)
VALUES 
('123 Calle Principal'),
('456 Avenida Secundaria'),
('789 Calle Tercera'),
('1010 Boulevard Central');

-- Insertando registros en la tabla Personas
INSERT INTO Personas (Nombre, CasaID)
VALUES 
('Juan P�rez', 1),
('Mar�a Garc�a', 2),
('Carlos L�pez', 2),
('Ana Fern�ndez', 3),
('Luis Mart�nez', 1),
('Sof�a Gonz�lez', 2),
('Pedro Rodr�guez', 4),
('Laura Hern�ndez', 4),
('Miguel S�nchez', 1),
('Elena Ram�rez', 1);

SELECT * FROM Personas
SELECT * FROM Casas

-- Unir las dos tablas mediante el ID de Casa
SELECT * FROM Personas as p
JOIN Casas as c
ON p.CasaID = c.ID

-- Hacer un JOIN con un WHERE
SELECT * FROM Personas as p
JOIN Casas as c
ON p.CasaID = c.ID
WHERE p.ID = 1

-- Agrupar y contabilizar cada grupo con un JOIN
SELECT c.ID, MIN(c.Direccion) as Direccion, COUNT(*) as Cantidad FROM Personas as p
JOIN Casas as c
ON p.CasaID = c.ID
GROUP BY c.ID