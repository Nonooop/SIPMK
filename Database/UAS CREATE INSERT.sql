CREATE TABLE dosen (
  nidn varchar(10) NOT NULL,
  nama_dosen varchar(100) NOT NULL,
  jenis_kelamin varchar(50) NOT NULL,
  alamat_dosen varchar(100) NOT NULL,
  noHp_dosen varchar(15) NOT NULL,
  email_dosen varchar(250) NOT NULL,
  keahlian varchar(1000) NOT NULL
);

drop table dosen;

INSERT INTO dosen (nidn, nama_dosen, jenis_kelamin, alamat_dosen, noHp_dosen, email_dosen, keahlian) VALUES
('0406107803', 'Halimil Fathi','Laki-laki', 'Purwakarta', '087079993011', 'halimil.fathi@pei.ac.id','Database'),
('0408057602', 'Widya Andayani Rahayu','Laki-laki', 'Koloni Indorama', '087879793432', 'widya.andayani@pei.ac.id','Bahasa Inggris'),
('0412128205', 'Musawarman', 'Laki-laki','Cikalong Wetan', '085795192182', 'musawarman@pei.ac.id','Programming'),
('0708098901', 'Muhammad Nugraha', 'Laki-laki','Purwakarta', '081222771911', 'nugraha@pei.ac.id','Programming'),
('1005128601', 'Heti Mulyani', 'Perempuan','Wanayasa', '085294854501', 'heti.mulyani@pei.ac.id','Data Science'),
('1017088502', 'Ricak Agus Setiawan','Laki-laki', '', '087821555203', 'ricak@pei.ac.id','System Analis'),
('1031212345', 'Ade Winarni', 'Perempuan','Wanayasa', '087862030400', 'adewina@pei.ac.id','Citra Digital');

CREATE TABLE hari (
  kd_hari varchar(10) NOT NULL,
  nama_hari varchar(10) NOT NULL
);

INSERT INTO hari (kd_hari, nama_hari) VALUES
('H001', 'Senin'),
('H002', 'Selasa'),
('H003', 'Rabu'),
('H004', 'Kamis'),
('H005', 'Jumat');



CREATE TABLE jadwal_kuliah (
  kd_jadwal varchar(10) NOT NULL,
  hari varchar(100) NOT NULL,
  jam varchar(100) NOT NULL,
  matakuliah varchar(100) NOT NULL,
  dosen varchar(100) NOT NULL,
  ruangan varchar(100) NOT NULL,
  prodi varchar(100) NOT NULL
);

DROP TABLE jadwal_kuliah;

INSERT INTO jadwal_kuliah (kd_jadwal, hari, jam, matakuliah, dosen, ruangan, prodi) VALUES
('JD0001', 'Senin','08.00-13.50', 'Sistem Terdistribusi',  'Ade', 'B7', 'Teknologi Rekayasa Perangkat Lunak'),
('JD0002', 'Senin', '14.00-17.00','Bahasa Inggris 5(Grammer)',  '0408057602', 'B7', 'Teknologi Rekayasa Perangkat Lunak'),
('JD0003', 'Selasa','08.00-13.50', 'Enterprise Resource Planning',  '1031212345', 'B5', 'Teknologi Rekayasa Perangkat Lunak'),
('JD0004', 'Selasa','14.00-17.00', 'Pengujian Perangkat Lunak', '1017088502', 'B5', 'Teknologi Rekayasa Perangkat Lunak'),
('JD0005', 'Rabu', '08.00-13.50','Pemrograman Web 3', 'SE504',  'B8', 'Teknologi Rekayasa Perangkat Lunak'),
('JD0006', 'Kamis','08.00-15.00', 'Pemrograman Visual', 'SE503', 'B5', 'Teknologi Rekayasa Perangkat Lunak'),
('JD0007', 'Jumat','08.00-13.50', 'Pemrograman Perangkat Bergerak', '0412128205', 'B8', 'Teknologi Rekayasa Perangkat Lunak');


CREATE TABLE matakuliah (
  kd_matakuliah varchar(10) NOT NULL,
  nama_matakuliah varchar(50) NOT NULL,
  sks int NOT NULL,
  semester varchar(10) NOT NULL
);



INSERT INTO matakuliah (kd_matakuliah, nama_matakuliah, sks, semester) VALUES
('GC101', 'Bahasa Inggris 1 (VOCAB)', 2, '1'),
('GC201', 'Bahasa Inggris 2 ( Speaking)', 2, '2'),
('GC301', 'Bahasa Inggris 3 ( Reading)', 2, '3'),
('GC401', 'Bahasa Inggris 4 (Writing)', 2, '4'),
('GC501', 'Bahasa Inggris 5 (Tenses)', 2, '5'),
('GC601', 'Bahasa Inggris 6 (TOEIC)', 2, '6'),
('GC701', 'Bahasa Indonesia', 2, '7'),
('GC702', 'Statistik', 3, '7'),
('GC801', 'Kewarganegaraan', 2, '8'),
('GC802', 'Pancasila', 2, '8'),
('GC803', 'Pendidikan Agama', 2, '8'),
('SE101', 'Algoritma & Pemrograman', 3, '1'),
('SE102', 'Aljabar Linear', 2, '1'),
('SE103', 'Kalkulus', 2, '1'),
('SE104', 'Komunikasi Data & Jaringan Komputer', 3, '1'),
('SE105', 'Pengantar Teknologi Informasi & Komunikasi', 2, '1'),
('SE106', 'Praktek Magang DTY 1', 1, '1'),
('SE107', 'Sistem Operasi', 3, '1'),
('SE201', 'Arsitektur Komputer', 2, '2'),
('SE202', 'Dasar-Dasar Keamanan Komputer', 3, '2'),
('SE203', 'Design dan Pemrograman Database SQL', 3, '2'),
('SE204', 'Pengantar Interaksi Manusia dan Komputer', 2, '2'),
('SE205', 'Pengantar Rekayasa Perangkat Lunak', 2, '2'),
('SE206', 'Praktek Magang DTY 2', 1, '2'),
('SE207', 'Struktur Data', 3, '2'),
('SE301', 'Analisis & Desain Perangkat Lunak', 3, '3'),
('SE302', 'Pemrograman Database PL/SQL', 4, '3'),
('SE303', 'Pemrograman Berorientasi Objek', 4, '3'),
('SE304', 'Pemrograman WEB 1', 3, '3'),
('SE305', 'Matematika Diskrit', 2, '3'),
('SE401', 'Pemrograman XML', 3, '4'),
('SE402', 'Keamanan Perangkat Lunak', 2, '4'),
('SE403', 'Oracle Application Express (APEX)', 3, '4'),
('SE404', 'Pemrograman Berorientasi Objek Lanjut', 4, '4'),
('SE405', 'Pemrograman WEB 2 (PHP)', 3, '4'),
('SE406', 'Rekayasa Kebutuhan Perangkat Lunak', 2, '4'),
('SE501', 'Pemrograman Perangkat Bergerak 1', 3, '5'),
('SE502', 'Pengujian Perangkat Lunak', 2, '5'),
('SE503', 'Pemrograman Visual', 4, '5'),
('SE504', 'Pemrograman WEB 3 (Framework)', 3, '5'),
('SE505', 'Sistem Terdistribusi', 3, '5'),
('SE506', 'Enterprise Resource Planning (ERP)', 3, '5'),
('SE601', 'Data Mining', 3, '6'),
('SE602', 'Pemrograman Perangkat Bergerak 2', 3, '6'),
('SE603', 'Jaminan Kualitas Perangkat Lunak (SOA)', 3, '6'),
('SE604', 'Manajemen Proyek Perangkat Lunak', 3, '6'),
('SE605', 'Cloud Computing', 3, '6'),
('SE606', 'Sistem Pendukung Keputusan', 3, '6'),
('SE701', 'Metodologi Penelitian', 2, '7'),
('SE702', 'Pemrograman IOS', 4, '7'),
('SE703', 'Praktik Kerja Lapang', 6, '7'),
('SE801', 'Etika Profesi', 2, '8'),
('SE802', 'Tugas Akhir', 6, '8'),
('SE803', 'Technopreneur', 2, '8');

CREATE TABLE prodi (
  kd_prodi varchar(10) NOT NULL,
  nama_prodi varchar(50) NOT NULL,
  keterangan varchar(15) NOT NULL
)

INSERT INTO prodi (kd_prodi, nama_prodi, keterangan) VALUES
('PRD001', 'Teknologi Mesin', 'MSN'),
('PRD002', 'Teknik Mekatronika', 'MKT'),
('PRD003', 'Teknologi Listrik', 'ELKT'),
('PRD004', 'Teknologi Rekayasa Perangkat Lunak', 'TRPL');


CREATE TABLE ruangan (
  kd_ruangan varchar(10) NOT NULL,
  nama_ruangan varchar(25) NOT NULL,
  kapasitas int NOT NULL,
  keterangan varchar(50) NOT NULL
);


INSERT INTO ruangan (kd_ruangan, nama_ruangan, kapasitas, keterangan) VALUES
('R001', 'B1', 30, 'Kelas'),
('R002', 'B2', 30, 'Kelas'),
('R003', 'B3', 30, 'Kelas'),
('R004', 'B4', 30, 'Kelas'),
('R005', 'B5', 30, 'Kelas'),
('R006', 'B7', 30, 'Laboratorium Komputer'),
('R007', 'B8', 30, 'Laboratorium Komputer'),
('R008', 'Lab Kimia', 30, 'Laboratorium'),
('R009', 'Lab Fisika', 30, 'Laboratorium'),
('R010', 'Bengkel Mesin', 30, 'Workshop'),
('R011', 'Bengkel Mekatronika', 30, 'Workshop'),
('R012', 'Bengkel Elektro', 30, 'Workshop');



CREATE TABLE tahun_akademik (
  kd_TA varchar(10) NOT NULL,
  tahun_akademik varchar(10) NOT NULL,
  semester varchar(10) NOT NULL,
  status varchar(10) NOT NULL
);

INSERT INTO tahun_akademik (kd_TA, tahun_akademik, semester, status) VALUES
('TA20181', '2018', 'Ganjil', 'Aktif'),
('TA20182', '2018', 'Genap', 'Aktif'),
('TA20191', '2019', 'Ganjil', 'Aktif'),
('TA20192', '2019', 'Genap', 'Aktif'),
('TA20201', '2020', 'Ganjil', 'Aktif'),
('TA20202', '2020', 'Genap', 'Aktif'),
('TA20211', '2021', 'Ganjil', 'Aktif'),
('TA20212', '2021', 'Genap', 'Aktif'),
('TA20221', '2022', 'Ganjil', 'Aktif');

CREATE TABLE users (
  kd_user varchar(15),
  name varchar(255),
  foto varchar(500),
  email varchar(255),
  password varchar(255),
  role varchar(15),
  created_at datetime, PRIMARY KEY( kd_user)
);
drop table users
/*
INSERT INTO users (kd_user, name, foto, email,  password, role,created_at) VALUES
('USR001', 'Luthfiyah Sakinah','', 'piaasan@gmail.com', '12','Administrator',GETDATE()),
('USR002', 'Ayu Siti Rohmah','', 'ayu@gmail.com', '12', 'Pengguna',GETDATE()),
('USR003', 'Adila','', 'adila@gmail.com', '12','Pengguna',GETDATE()),
('USR004', 'Nopi Rahmawati','', 'nopiraa01@gmail.com', '12',  'Administrator',GETDATE());
*/
INSERT INTO users (kd_user, name, email,  password, role,created_at) VALUES
('USR001', 'Luthfiyah Sakinah', 'piaasan@gmail.com', '12','Administrator',GETDATE()),
('USR002', 'Ayu Siti Rohmah', 'ayu@gmail.com', '12', 'Pengguna',GETDATE()),
('USR003', 'Adila','adila@gmail.com', '12','Pengguna',GETDATE()),
('USR004', 'Nopi Rahmawati', 'nopiraa01@gmail.com', '12',  'Administrator',GETDATE());