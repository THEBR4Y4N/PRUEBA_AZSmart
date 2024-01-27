---Libros
IF OBJECT_ID('Autor', 'U') IS NULL
BEGIN
	CREATE TABLE Autor (
		AutorID int IDENTITY(0,1) NOT NULL,
		Nombre varchar(100) ,
		CONSTRAINT Autor_PK PRIMARY KEY (AutorID)
	);
END
ELSE
BEGIN
    PRINT 'La tabla Autor ya existe.';
END	

---Libros
IF OBJECT_ID('Libros', 'U') IS NULL
BEGIN
	CREATE TABLE Libros (
		ID int IDENTITY(0,1) NOT NULL,
		Título varchar(100) ,
		autorID int NOT NULL,
		CONSTRAINT Libros_PK PRIMARY KEY (ID)
	);
	--llave foranea
	ALTER TABLE Libros ADD CONSTRAINT Libros_FK FOREIGN KEY (autorID) REFERENCES Autor(AutorID);
END
ELSE
BEGIN
    PRINT 'La tabla Libros ya existe.';
END	