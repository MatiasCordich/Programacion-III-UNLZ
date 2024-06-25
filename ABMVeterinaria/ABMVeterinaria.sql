-- Tabla Usuarios
CREATE TABLE Usuarios (
    UsuarioID INT PRIMARY KEY IDENTITY,
    NombreUsuario VARCHAR(255) NOT NULL,
    Clave VARCHAR(255) NOT NULL,
    Estado VARCHAR(10) NOT NULL DEFAULT 'Activo',
    CHECK (Estado IN ('Activo', 'Inactivo'))
);

-- Tabla Clientes
CREATE TABLE Clientes (
    ClienteID INT PRIMARY KEY IDENTITY,
    Nombre VARCHAR(255) NOT NULL,
    DNI INT NOT NULL UNIQUE,
    Estado VARCHAR(10) NOT NULL DEFAULT 'Activo',
    CHECK (Estado IN ('Activo', 'Inactivo'))
);

-- Tabla Especies
CREATE TABLE Especies (
    EspecieID INT PRIMARY KEY IDENTITY,
    Nombre VARCHAR(255) NOT NULL,
    EdadMadurez INT NOT NULL,
    PesoPromedio DECIMAL(5,2) NOT NULL
);

-- Tabla Animales
CREATE TABLE Animales (
    AnimalID INT PRIMARY KEY IDENTITY,
    Nombre VARCHAR(100) NOT NULL,
    Peso DECIMAL(5,2) NOT NULL,
    Edad INT NOT NULL,
    ClienteID INT NOT NULL, 
    EspecieID INT NOT NULL,
    FOREIGN KEY (ClienteID) REFERENCES Clientes(ClienteID),
    FOREIGN KEY (EspecieID) REFERENCES Especies(EspecieID),
    Estado VARCHAR(10) NOT NULL DEFAULT 'Vivo',
    CHECK (Estado IN ('Vivo', 'Difunto'))
);

-- Valores Iniciales 

-- Usuario inicial 
INSERT INTO Usuarios (NombreUsuario, Clave)
VALUES ('pepe', '1234');

-- Cliente inicial
INSERT INTO Clientes (Nombre, DNI)
VALUES ('kali uchis', 38545676);

-- Especie inicial
INSERT INTO Especies(Nombre, EdadMadurez, PesoPromedio)
VALUES ('Sin especificar', 0.00, 0);