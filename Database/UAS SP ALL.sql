
//LOGIN
ALTER PROCEDURE spLogin @Username varchar(50), @Passwd varchar(50)
AS 
	select name, foto, password, role from users where name = @Username and password = @Passwd
GO

EXEC spLogin 'Luthfiyah Sakinah','12'


//data user
CREATE PROC spDataUser
AS
	Select * from users
Go
EXEC spDataUser

CREATE PROC spAmbilIDUser
AS
	Select kd_user from users
Go
EXEC spIDUser


CREATE PROCEDURE spCariDataUser @Cari varchar(50)
AS 
	SELECT * FROM users WHERE kd_user LIKE '%' +@Cari+ '%' OR name LIKE '%' +@Cari+ '%' OR email LIKE '%' +@Cari+ '%' OR password LIKE '%' +@Cari+ '%'  OR role LIKE '%' +@Cari+ '%'
GO

EXECUTE spCariDataUser 'lu'


CREATE PROCEDURE spIdUser
AS 
	select kd_user from users where kd_user in(select max(kd_user) from users) order by kd_user desc
GO

EXECUTE spIdUser


ALTER PROC spInputUser @ID varchar(50), @NAMA varchar(50), @FOTO varchar(500),
						 @EMAIL varchar(50), @PASSWD varchar(50), @LEVEL varchar(50)
AS
	INSERT INTO users(kd_user,name,foto,email,password,role,created_at)
	VALUES(@ID, @NAMA, @FOTO, @EMAIL, @PASSWD, @LEVEL,GETDATE())
Go
EXEC spInputUser 'USR005', 'Pia','','piasan@gmail.com', 'pia1','Kasir'

ALTER PROC spUpdateUser @ID varchar(50), @NAMA varchar(50),@FOTO varchar(500),
						 @EMAIL varchar(50), @PASSWD varchar(50), @LEVEL varchar(50)
AS
	UPDATE users SET  name= @NAMA, foto= @FOTO,  email = @EMAIL, password=@PASSWD, role = @LEVEL
	WHERE kd_user= @ID
GO

EXEC spUpdateUser 'USR005', 'Piasan','','piasan@gmail.com', 'pia1','Kasir'


CREATE PROC spHapusUser @ID AS VARCHAR(50)
AS
	DELETE FROM users WHERE kd_user= @ID
GO

EXEC spHapusUser 'USR005'

//data dosen

CREATE PROC spDataDosen
AS
	Select * from dosen
Go
EXEC spDataDosen

CREATE PROC spAmbilIDDosen
AS
	Select nidn from dosen
Go
EXEC spAmbilIDDosen

ALTER PROCEDURE spCariDataDosen @Cari varchar(50)
AS 
	SELECT * FROM dosen WHERE nidn LIKE '%' +@Cari+ '%' OR nama_dosen LIKE '%' +@Cari+ '%' OR alamat_dosen LIKE '%' +@Cari+ '%' OR noHp_dosen LIKE '%' +@Cari+ '%'  OR email_dosen LIKE '%' +@Cari+ '%'
GO

EXECUTE spCariDataDosen 'nu'

ALTER PROC spInputDosen @ID varchar(50), @NAMA varchar(100), @JK varchar(50),
						 @ALAMAT varchar(500), @NO varchar(50), @EMAIL varchar(100),@AHLI varchar(1000)
AS
	INSERT INTO dosen(nidn,nama_dosen,jenis_kelamin,alamat_dosen,noHp_dosen,email_dosen,keahlian)
	VALUES(@ID, @NAMA,@JK, @ALAMAT, @NO, @EMAIL,@AHLI)
Go
EXEC spInputDosen '237492414', 'Pia','cwk','pwk','0183092','piasan@gmail.com','programming'

ALTER PROC spUpdateDosen @ID varchar(50), @NAMA varchar(100), @JK varchar(50),
						 @ALAMAT varchar(500), @NO varchar(50), @EMAIL varchar(100),@AHLI varchar(1000)
AS
	UPDATE dosen SET  nama_dosen= @NAMA, jenis_kelamin = @JK, alamat_dosen = @ALAMAT, noHp_dosen=@NO, email_dosen = @EMAIL, keahlian = @AHLI
	WHERE nidn= @ID
GO

EXEC spUpdateDosen '237492414', 'Pia','cwk','pwk','0183092','piasan@gmail.com','programming,database'


CREATE PROC spHapusDosen @ID AS VARCHAR(50)
AS
	DELETE FROM dosen WHERE nidn= @ID
GO

EXEC spHapusDosen '237492414'


//data hari

CREATE PROC spDataHari
AS
	Select * from hari
Go
EXEC spDataHari

CREATE PROC spAmbilIDHari
AS
	Select kd_hari from hari
Go
EXEC spAmbilIDHari

CREATE PROCEDURE spCariDataHari @Cari varchar(50)
AS 
	SELECT * FROM hari WHERE kd_hari LIKE '%' +@Cari+ '%' OR nama_hari LIKE '%' +@Cari+ '%' 
GO
EXECUTE spCariDataHari 'u'

CREATE PROCEDURE spIdHari
AS 
	select kd_hari from hari where kd_hari in(select max(kd_hari) from hari) order by kd_hari desc
GO

EXECUTE spIdHari

CREATE PROC spInputHari @ID varchar(50), @NAMA varchar(50)
AS
	INSERT INTO hari(kd_hari,nama_hari)
	VALUES(@ID, @NAMA)
Go
EXEC spInputHari 'H006', 'Sabtu'

CREATE PROC spUpdateHari @ID varchar(50), @NAMA varchar(50)
AS
	UPDATE hari SET  nama_hari= @NAMA
	WHERE kd_hari= @ID
GO

EXEC spUpdateHari 'H006', 'Minggu'


CREATE PROC spHapusHari @ID AS VARCHAR(50)
AS
	DELETE FROM hari WHERE kd_hari= @ID
GO

EXEC spHapusHari 'H006'



//data matakuliah

CREATE PROC spDataMK
AS
	Select * from matakuliah
Go
EXEC spDataMK

CREATE PROC spAmbilIDMK
AS
	Select kd_matakuliah from matakuliah
Go
EXEC spAmbilIDMK

CREATE PROCEDURE spCariDataMK @Cari varchar(50)
AS 
	SELECT * FROM matakuliah WHERE kd_matakuliah LIKE '%' +@Cari+ '%' OR nama_matakuliah LIKE '%' +@Cari+ '%'  OR sks LIKE '%' +@Cari+ '%' OR semester LIKE '%' +@Cari+ '%' 
GO

EXECUTE spCariDataMK 'u'

CREATE PROCEDURE spIdMK
AS 
	select kd_matakuliah from matakuliah where kd_matakuliah in(select max(kd_matakuliah) from matakuliah) order by kd_matakuliah desc
GO

EXECUTE spIdMK

CREATE PROC spInputMK @ID varchar(50), @NAMA varchar(50),@SKS int, @SMT varchar(50)
AS
	INSERT INTO matakuliah(kd_matakuliah, nama_matakuliah, sks, semester)
	VALUES(@ID, @NAMA,@SKS, @SMT)
Go
EXEC spInputMK 'SE804', 'Sabtu',2,'8'

CREATE PROC spUpdateMK @ID varchar(50), @NAMA varchar(50),@SKS int, @SMT varchar(50)
AS
	UPDATE matakuliah SET  nama_matakuliah= @NAMA,sks = @SKS, semester=@SMT
	WHERE kd_matakuliah= @ID
GO

EXEC spUpdateMK 'SE804', 'Minggu',3,'8'


CREATE PROC spHapusMK @ID AS VARCHAR(50)
AS
	DELETE FROM matakuliah WHERE kd_matakuliah= @ID
GO

EXEC spHapusMK 'SE804'


//data prodi

CREATE PROC spDataProdi
AS
	Select * from prodi
Go
EXEC spDataProdi

CREATE PROC spAmbilIDProdi
AS
	Select kd_prodi from prodi
Go
EXEC spAmbilIDProdi

CREATE PROCEDURE spCariDataProdi @Cari varchar(50)
AS 
	SELECT * FROM prodi WHERE kd_prodi LIKE '%' +@Cari+ '%' OR nama_prodi LIKE '%' +@Cari+ '%'  OR keterangan LIKE '%' +@Cari+ '%' 
GO

EXECUTE spCariDataProdi 'u'

CREATE PROCEDURE spIdProdi
AS 
	select kd_prodi from prodi where kd_prodi in(select max(kd_prodi) from prodi) order by kd_prodi desc
GO

EXECUTE spIdProdi

CREATE PROC spInputProdi @ID varchar(50), @NAMA varchar(50),@KET varchar(50)
AS
	INSERT INTO prodi(kd_prodi, nama_prodi, keterangan)
	VALUES(@ID, @NAMA,@KET)
Go
EXEC spInputProdi 'PRD004', 'TEKNOLOGI INDUSTRI','IDS'

CREATE PROC spUpdateProdi @ID varchar(50), @NAMA varchar(50),@KET varchar(50)
AS
	UPDATE prodi SET  nama_prodi= @NAMA,keterangan = @KET
	WHERE kd_prodi= @ID
GO

EXEC spUpdateProdi 'PRD005', 'Minggu','MSN'


CREATE PROC spHapusProdi @ID AS VARCHAR(50)
AS
	DELETE FROM prodi WHERE kd_prodi= @ID
GO

EXEC spHapusProdi 'PRD005'



//data ruangan

CREATE PROC spDataRuangan
AS
	Select * from ruangan
Go
EXEC spDataRuangan

CREATE PROC spAmbilIDRuangan
AS
	Select kd_ruangan from ruangan
Go
EXEC spAmbilIDRuangan

CREATE PROCEDURE spCariDataRuangan @Cari varchar(50)
AS 
	SELECT * FROM ruangan WHERE kd_ruangan LIKE '%' +@Cari+ '%' OR nama_ruangan LIKE '%' +@Cari+ '%'  OR kapasitas LIKE '%' +@Cari+ '%'  OR keterangan LIKE '%' +@Cari+ '%' 
GO

EXECUTE spCariDataRuangan 'u'

CREATE PROCEDURE spIdRuangan
AS 
	select kd_ruangan from ruangan where kd_ruangan in(select max(kd_ruangan) from ruangan) order by kd_ruangan desc
GO

EXECUTE spIdRuangan

ALTER PROC spInputRuangan @ID varchar(50), @NAMA varchar(50),@KAP INT,@KET varchar(50)
AS
	INSERT INTO ruangan(kd_ruangan, nama_ruangan,kapasitas, keterangan)
	VALUES(@ID, @NAMA,@KAP,@KET)
Go
EXEC spInputRuangan 'R013', 'TEKNOLOGI INDUSTRI',30, 'YU'

CREATE PROC spUpdateRuangan @ID varchar(50), @NAMA varchar(50),@KAP INT,@KET varchar(50)
AS
	UPDATE ruangan SET  nama_ruangan= @NAMA,kapasitas = @KAP , keterangan = @KET
	WHERE kd_ruangan= @ID
GO

EXEC spUpdateRuangan 'R013', 'TEKNOLOGI ',40, 'YU'


CREATE PROC spHapusRuangan @ID AS VARCHAR(50)
AS
	DELETE FROM ruangan WHERE kd_ruangan= @ID
GO

EXEC spHapusRuangan 'R013'


//data tahun akademik
CREATE PROC spDataTA
AS
	Select * from tahun_akademik
Go
EXEC spDataTA

CREATE PROC spAmbilIDTA
AS
	Select kd_TA from tahun_akademik
Go
EXEC spAmbilIDTA

CREATE PROCEDURE spCariDataTA @Cari varchar(50)
AS 
	SELECT * FROM tahun_akademik WHERE kd_TA LIKE '%' +@Cari+ '%' OR tahun_akademik LIKE '%' +@Cari+ '%'  OR semester LIKE '%' +@Cari+ '%'  OR status LIKE '%' +@Cari+ '%' 
GO

EXECUTE spCariDataTA 't'

CREATE PROCEDURE spIdTA
AS 
	select kd_TA from tahun_akademik where kd_TA in(select max(kd_TA) from tahun_akademik) order by kd_TA desc
GO

EXECUTE spIdTA

CREATE PROC spInputTA @ID varchar(50), @NAMA varchar(50),@KAP varchar(50),@KET varchar(50)
AS
	INSERT INTO tahun_akademik(kd_TA, tahun_akademik,semester, status)
	VALUES(@ID, @NAMA,@KAP,@KET)
Go
EXEC spInputTA 'TA20222', 'TEKNOLOGN','genal', 'YU'

CREATE PROC spUpdateTA @ID varchar(50), @NAMA varchar(50),@KAP varchar(50),@KET varchar(50)
AS
	UPDATE tahun_akademik SET  tahun_akademik= @NAMA,semester = @KAP , status = @KET
	WHERE kd_TA= @ID
GO

EXEC spUpdateTA 'TA20222', 'TEKGI MSN','genap', 'YU'


CREATE PROC spHapusTA @ID AS VARCHAR(50)
AS
	DELETE FROM tahun_akademik WHERE kd_TA= @ID
GO

EXEC spHapusTA 'TA20222'




//data jadwal kuliah
CREATE PROC spDataJadwalKuliah
AS
	Select * from jadwal_kuliah
Go
EXEC spDataJadwalKuliah


ALTER PROCEDURE spCariDataJadwalKuliah @Cari varchar(50)
AS 
	SELECT * FROM jadwal_kuliah WHERE kd_jadwal LIKE '%' +@Cari+ '%' OR hari LIKE '%' +@Cari+ '%'  OR jam LIKE '%' +@Cari+ '%'  OR matakuliah LIKE '%' +@Cari+ '%' 
	  OR dosen LIKE '%' +@Cari+ '%'  OR ruangan LIKE '%' +@Cari+ '%' OR prodi LIKE '%' +@Cari+ '%' 
GO

EXECUTE spCariDataJadwalKuliah 't'

CREATE PROCEDURE spIdJadwalKuliah
AS 
	select kd_jadwal from jadwal_kuliah where kd_jadwal in(select max(kd_jadwal) from jadwal_kuliah) order by kd_jadwal desc
GO

EXECUTE spIdJadwalKuliah

ALTER PROC spInputJadwalKuliah @ID varchar(500), @HARI varchar(500),@JAM varchar(500),@MK varchar(500),
								@NIDN varchar(500), @R varchar(500),@PRODI varchar(500)
AS
	INSERT INTO jadwal_kuliah(kd_jadwal, hari, jam, matakuliah, dosen,ruangan, prodi)
	VALUES(@ID, @HARI,@JAM,@MK, @NIDN,@R,@PRODI)
Go
EXEC spInputJadwalKuliah 'JD0008', 'H005', 'J001', 'SE501', '0412128205', 'R004', 'PRD004'

ALTER PROC spUpdateJadwalKuliah @ID varchar(50), @HARI varchar(50),@JAM varchar(50),@MK varchar(50),
								@NIDN varchar(50), @R varchar(50),@PRODI varchar(50)
AS
	UPDATE jadwal_kuliah SET  hari= @HARI,jam = @JAM , matakuliah = @MK,dosen= @NIDN,ruangan = @R , prodi = @PRODI
	WHERE kd_jadwal= @ID
GO

EXEC spUpdateJadwalKuliah 'JD0008', 'H005', 'J001', 'SE501', '0412128205', 'R001', 'PRD003'


CREATE PROC spHapusJadwalKuliah @ID AS VARCHAR(50)
AS
	DELETE FROM jadwal_kuliah WHERE kd_jadwal= @ID
GO

EXEC spHapusJadwalKuliah 'JD0008'


CREATE PROC spDashboard
AS
SELECT jadwal_kuliah.kd_jadwal, jadwal_kuliah.jam, jadwal_kuliah.hari, jadwal_kuliah.matakuliah, matakuliah.sks,matakuliah.semester, jadwal_kuliah.dosen, jadwal_kuliah.ruangan, jadwal_kuliah.prodi  from jadwal_kuliah 
join matakuliah
on jadwal_kuliah.matakuliah=matakuliah.nama_matakuliah
GO

ALTER PROC spFilterMK  @CariSMT varchar(100),@CariPRD varchar(100)
AS
SELECT jadwal_kuliah.kd_jadwal, jadwal_kuliah.jam, jadwal_kuliah.hari, jadwal_kuliah.matakuliah, matakuliah.sks,matakuliah.semester, jadwal_kuliah.dosen, jadwal_kuliah.ruangan, jadwal_kuliah.prodi  from jadwal_kuliah 
join matakuliah
on jadwal_kuliah.matakuliah=matakuliah.nama_matakuliah
where matakuliah.semester like '%'+@CariSMT+'%'  and jadwal_kuliah.prodi like '%'+ @CariPRD +'%'
GO

EXEC spFilterMK '5','Teknologi '


CREATE PROC spCariDb  @Cari varchar(100)
AS
SELECT jadwal_kuliah.kd_jadwal, jadwal_kuliah.jam, jadwal_kuliah.hari, jadwal_kuliah.matakuliah, matakuliah.sks,matakuliah.semester, jadwal_kuliah.dosen, jadwal_kuliah.ruangan, jadwal_kuliah.prodi  from jadwal_kuliah 
join matakuliah
on jadwal_kuliah.matakuliah=matakuliah.nama_matakuliah
where 
jadwal_kuliah.kd_jadwal like '%'+@Cari+'%'  or jadwal_kuliah.jam like '%'+@Cari+'%'  or jadwal_kuliah.hari like '%'+@Cari+'%' or jadwal_kuliah.matakuliah like '%'+@Cari+'%' or matakuliah.semester like '%'+@Cari+'%' or matakuliah.sks like '%'+@Cari+'%' or jadwal_kuliah.ruangan like '%'+@Cari+'%' or jadwal_kuliah.prodi like '%'+ @Cari +'%'
GO

EXEC spCariDb ''
