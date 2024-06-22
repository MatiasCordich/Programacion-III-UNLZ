-- Tabla Usuarios
CREATE TABLE Usuarios (
    UsuarioID INT PRIMARY KEY IDENTITY,
    NombreUsuario VARCHAR(255) NOT NULL,
    Clave VARCHAR(255) NOT NULL,
    Estado VARCHAR(10) NOT NULL DEFAULT 'Activo'
);

-- Aseguramos que Estado de Usuarios solo acepte 'Activo' o 'Inactivo'
ALTER TABLE Usuarios
ADD CONSTRAINT CHK_Estado CHECK (Estado IN ('Activo', 'Inactivo'));

-- Demas tablas
CREATE TABLE Clientes (
    ClienteID INT PRIMARY KEY IDENTITY,
    Nombre VARCHAR(255) NOT NULL,
    DNI INT NOT NULL,
    Estado VARCHAR(10) NOT NULL DEFAULT 'Activo'

-- Aseguramos que Estado de Clientes solo acepte 'Activo' o 'Inactivo'
ALTER TABLE Clientes
ADD CONSTRAINT CHK_EstadoCliente CHECK (Estado IN ('Activo', 'Inactivo'));

CREATE TABLE Animales (
    AnimalID INT PRIMARY KEY IDENTITY,
    Nombre VARCHAR(100) NOT NULL,
    Peso DECIMAL(5,2) NOT NULL,
    Edad INT NOT NULL,
	ClienteID INT, 
	EspecieID INT,
	FOREIGN KEY (ClienteID) REFERENCES Clientes(ClienteID),
	FOREIGN KEY (EspecieID) REFERENCES Especies(EspecieID),
	Estado VARCHAR(10) NOT NULL DEFAULT 'Vivo'
);

-- Aseguramos que Estado de Animales solo acepte 'Vivo' o 'Difunto'
ALTER TABLE Animales 
ADD CONSTRAINT CHK_EstadoAnimal CHECK (Estado IN ('Vivo', 'Difunto'));

CREATE TABLE Especies (
    EspecieID INT PRIMARY KEY IDENTITY,
    Nombre VARCHAR(255) NOT NULL,
    EdadMadurez INT NOT NULL,
	PesoPromedio  DECIMAL(5,2) NOT NULL,
);

select * from Especies

-- Usuario inicial 
INSERT INTO Usuarios (NombreUsuario, Clave)
VALUES ('pepe', '1234');

-- Cliente inicial
INSERT INTO Clientes (Nombre, DNI)
VALUES ('kali uchis', 38545676);

-- Especie inicial
INSERT INTO Especies(Nombre, EdadMadurez, PesoPromedio)
VALUES ('canino', 4, 15);