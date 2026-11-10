CREATE TABLE Tbl_Uyeler (
    UyeId INT IDENTITY(1,1) PRIMARY KEY,
    Ad NVARCHAR(50),
    Soyad NVARCHAR(50),
    Telefon NVARCHAR(20),
    UyelikTipi NVARCHAR(50),
    KayitTarihi DATE
);