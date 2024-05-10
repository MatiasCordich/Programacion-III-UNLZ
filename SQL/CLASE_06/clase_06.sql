--Creando la tabla animales

CREATE TABLE ANIMALES(
	ID INT PRIMARY KEY,
	NOMBRE VARCHAR(55)
)

-- Vamos a insertar algunos animales 
INSERT INTO ANIMALES VALUES 
(1, 'Kitty'),
(2, 'Cinnamoroll'),
(3, 'Pompompurin'),
(4, 'MyMelody'),
(5, 'Kuromi'),
(6, 'Pochacco'),
(7, 'Keroppi'),
(8, 'Chococat'),
(9, 'Badz Maru'),
(10, 'Tuxedosam')

-- Modificando la tabla ANIMALES 

ALTER TABLE ANIMALES 
ADD ESPECIE VARCHAR(30) NOT NULL 
DEFAULT 'Perro'

-- Insertamos devuelta pero borramos antes los registros anteriores (DELETE FROM ANIMALES)

INSERT INTO ANIMALES VALUES 
(1, 'Kitty', 'GATO'),
(2, 'Cinnamoroll', 'PERRO'),
(3, 'Pompompurin', 'PERRO'),
(4, 'MyMelody', 'CONEJO'),
(5, 'Kuromi', 'CONEJO'),
(6, 'Pochacco', 'PERRO'),
(7, 'Keroppi','RANA'),
(8, 'Chococat','GATO'),
(9, 'Badz Maru','PAJARO'),
(10, 'Tuxedosam','PAJARO')

SELECT * FROM ANIMALES