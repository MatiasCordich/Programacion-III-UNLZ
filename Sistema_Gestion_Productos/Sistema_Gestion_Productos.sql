-- Tabla Categorias
CREATE TABLE Categorias (
    CategoriaID INT PRIMARY KEY IDENTITY(1,1),
    Nombre VARCHAR(255) NOT NULL
);

-- Tabla Productos
CREATE TABLE Productos (
    ProductoID INT PRIMARY KEY IDENTITY(1,1),
    Codigo VARCHAR(50) NOT NULL UNIQUE,
    Descripcion VARCHAR(255) NOT NULL,
    Valor DECIMAL(18,2) NOT NULL,
    CategoriaID INT NOT NULL,
    Estado VARCHAR(15) NOT NULL DEFAULT 'En Stock' CHECK (Estado IN ('En Stock', 'Sin Stock')),
    Cantidad INT NOT NULL DEFAULT 0,
    FOREIGN KEY (CategoriaID) REFERENCES Categorias(ID)
);