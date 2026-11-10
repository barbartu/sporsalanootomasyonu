CREATE TABLE Tbl_Egitmenler (
    EgitmenId INT PRIMARY KEY IDENTITY(1,1),
    EgitmenAdi VARCHAR(50) NOT NULL,
    EgitmenSoyadi VARCHAR(50) NOT NULL,
    Telefon VARCHAR(20),
    Uzmanlik VARCHAR(50)
);