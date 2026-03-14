CREATE DATABASE CENTRORECARGA

USE CENTRORECARGA

CREATE TABLE Operadora
(
OperadoraID INT PRIMARY KEY IDENTITY(1,1),
NombreOperadora VARCHAR(20) UNIQUE NOT NULL,
Comision DECIMAL(5,2) CHECK (Comision >= 0),
Estado BIT NOT NULL DEFAULT 1
)

CREATE TABLE Vendedor 
(
VendedorID INT IDENTITY(1,1) PRIMARY KEY,
Nombre NVARCHAR(150) NOT NULL,
Documento NVARCHAR(20) NOT NULL UNIQUE,
Telefono NVARCHAR(20),
Activo BIT NOT NULL DEFAULT 1
)

Drop Table Recarga

CREATE TABLE Recarga
(
RecargaID INT PRIMARY KEY IDENTITY(1,1),
VendedorID INT FOREIGN KEY REFERENCES Vendedor(VendedorID),
OperadoraID INT FOREIGN KEY REFERENCES Operadora(OperadoraID),
Monto INT NOT NULL,
FechaRecarga DATE NOT NULL DEFAULT GETDATE()
)

SELECT 
r.RecargaID, 
v.Nombre AS Vendedor, 
o.NombreOperadora AS Operadora, 
r.Monto,
r.FechaRecarga AS Fecha
FROM Recarga r
INNER JOIN Vendedor v ON r.VendedorID = v.VendedorID 
INNER JOIN Operadora o ON r.OperadoraID = o.OperadoraID 
ORDER BY r.RecargaID

INSERT INTO Recarga(VendedorID, OperadoraID, Monto)
VALUES ('1', '1', '750')

DROP TABLE CierreCaja

CREATE TABLE CierreCaja
(
CierreID INT PRIMARY KEY IDENTITY(1,1),
VendedorID INT FOREIGN KEY REFERENCES Vendedor(VendedorID),
OperadoraID INT FOREIGN KEY REFERENCES Operadora(OperadoraID),
RecargaID INT FOREIGN KEY REFERENCES Recarga(RecargaID),
FechaCierre DATE NOT NULL DEFAULT GETDATE(),
Monto INT NOT NULL,
)
SELECT*FROM CierreCaja

INSERT INTO CierreCaja(VendedorID, OperadoraID, RecargaID, Monto)
SELECT VendedorID, OperadoraID, RecargaID, Monto
From Recarga
Where VendedorID = 1 AND OperadoraID = 1