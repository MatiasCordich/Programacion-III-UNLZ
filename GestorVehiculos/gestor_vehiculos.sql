CREATE TABLE VEHICULOS(
	ID INT IDENTITY NOT NULL PRIMARY KEY,
	PATENTE VARCHAR(10) UNIQUE NOT NULL,
	TIPO_ID INT, 
	VELOCIDAD DECIMAL (18,2)
)