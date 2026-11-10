CREATE TABLE Tbl_GirisCikis (
    HareketID INT IDENTITY(1,1) PRIMARY KEY,
    UyeID INT NOT NULL,
    UyeAdSoyad VARCHAR(50) NOT NULL,
    TcKimlikNo VARCHAR(11),
    GirisSaati DATETIME,
    CikisSaati DATETIME,
    Durum VARCHAR(20)
	);